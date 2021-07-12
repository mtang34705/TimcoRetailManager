using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TRMWPFUserInterface.Models;

namespace TRMWPFUserInterface.Helpers
{
    public class ApiHelper : IApiHelper
    {
        public ApiHelper()
        {
            InitializeClient();
        }
        private HttpClient _apiClient { get; set; }
        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["api"];
            _apiClient = new HttpClient();
            _apiClient.BaseAddress = new System.Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("grant_type","password"),
                new KeyValuePair<string,string>("username",username),
                new KeyValuePair<string,string>("password",/*password*/ "Pwd12345 ")
            });

            using (HttpResponseMessage response = await _apiClient.PostAsync("https://localhost:44381/Token", data))//"/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
