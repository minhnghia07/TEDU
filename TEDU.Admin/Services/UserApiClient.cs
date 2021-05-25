﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TEDU.ViewModels.System.Users;

namespace TEDU.Admin.Services
{
    public class UserApiClient : IUserApiClient
    {
       

        public readonly IHttpClientFactory _httpClientFactory;
        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri("https://localhost:5001/");

            var reponse = await client.PostAsync("/api/users/authenticate/", httpContent);
            var token = await reponse.Content.ReadAsStringAsync();
            return token;
        }
    }
}
