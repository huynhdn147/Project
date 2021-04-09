using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using TLU.BusinessFee.Application.Catalog.ChiPhiChucVus;
using TLU.BusinessFee.Application.Catalog.ChiPhis;
using TLU.BusinessFee.Application.Catalog.ChucVu;
using TLU.BusinessFee.Application.Catalog.ChucVus;
using TLU.BusinessFee.Application.Catalog.ChuyenCongTacs;
using TLU.BusinessFee.Application.Catalog.DeXuatThanhToans;
using TLU.BusinessFee.Application.Catalog.DuyetDeXuat;
using TLU.BusinessFee.Application.Catalog.NhanVienCongTacs;
using TLU.BusinessFee.Application.Catalog.NhanViens;
using TLU.BusinessFee.Application.Catalog.PhongBans;
using TLU.BusinessFee.Application.Catalog.ThanhToans;
using TLU.BusinessFee.Application.Common;
using TLU.BusinessFee.Application.System;
using TLU.BusinessFee.Application.System.Users;
using TLU.BusinessFee.Data.EF;
using TLU.BusinessFee.Data.Entities;
using TLU.BusinessFee.Utilities.Constants;

namespace TLU.BusinessFee.BackendApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TLUBusinessFeeDbContext>(options => options.UseSqlServer
            (Configuration.GetConnectionString(SystemConstant.MainConnectionString)));
            services.AddHttpClient();
            //declare DI
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<TLUBusinessFeeDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IPublicPhongBanService, PublicPhongBanService>();
            services.AddTransient<IManagerPhongBanService, ManagePhongBanService>();
            services.AddTransient<IManagerCapBacSerVice, ManagerCapBacService>();
            services.AddTransient<IManagerNhanVienService, ManagarNhanVienService>();
            services.AddTransient<IManagerChiPhiService, ManagerChiPhiService>();
            services.AddTransient<IManagerDinhMucService, ManagerDinhMucService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IChuyenCongTacSerVice, ChuyenCongTacSerVice>();
            services.AddTransient<IManagerNhanVienCongTacService, ManagerNhanVienCongTacService>();
            services.AddTransient < UserManager<User>, UserManager<User>>();
            services.AddTransient<SignInManager<User>, SignInManager<User>>();
            services.AddTransient<RoleManager<Role>, RoleManager<Role>>();
            services.AddTransient<IValidator<LoginRequest>,LoginRequestValidator>();
            services.AddTransient<IManagerDeXuatThanhToanService, ManagerDeXuatThanhToanService>();
            services.AddTransient<IManagerChucvuService, ManagerChucvuService>();
            services.AddTransient<IStorageService, StorageService>();
            services.AddTransient<IDuyetDeXuatService,DuyetDeXuatService>();
            services.AddTransient<IThanhToanManagerService, ThanhToanManagerService>();
            //services.AddTransient<RoleManager<Role>, RoleManager<UserRole>>();
            services.AddControllers().
                AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>()
                );

            //swagger
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "swaggerdemo", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });


            });
            string issuer = Configuration.GetValue<string>("Tokens:Issuer");
            string signingKey = Configuration.GetValue<string>("Tokens:Key");
            byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = issuer,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            //app.UseCors(x => x.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod().WithOrigins("http://localhost:3000"));
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "swagger TLUBusinessFee demov 1");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
