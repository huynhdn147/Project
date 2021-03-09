using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TLU.BusinessFee.Application.System;

namespace TLU.BusinessFee.AdminApp.Service
{
    public class UserApiClient : IUserApiClient
    {
        private IHttpClientFactory _factory;
        public UserApiClient(IHttpClientFactory factory)
        {
            _factory = factory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client= _factory.CreateClient();
            //client.BaseAddress=new Uri("https://localhost:5001");
            var response = await client.PostAsync("https://localhost:5000/api/Users/authenticate", httpContent);

            var token = await response.Content.ReadAsStringAsync();
            return token;

        }
    }
}
