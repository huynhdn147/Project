using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TLU.BusinessFee.Data.EF
{
    
    public class TLUBusinessFeeDbContextFactory : IDesignTimeDbContextFactory<TLUBusinessFeeDbContext>
    {
        public TLUBusinessFeeDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            var ConnectionString = configuration.GetConnectionString("TLU_BusinessFeeDb");
            
            var optionBuilder = new DbContextOptionsBuilder<TLUBusinessFeeDbContext>();
            optionBuilder.UseSqlServer(ConnectionString);
            return new TLUBusinessFeeDbContext(optionBuilder.Options);
        }
    }
}
