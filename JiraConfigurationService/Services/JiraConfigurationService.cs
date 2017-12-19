using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JiraConfigurationService.Models;
using Newtonsoft.Json;

namespace JiraConfigurationService.Services
{
    public class JiraConfigurationService:IJiraConfigurationService
    {
        private readonly HttpClient _httpClient;

        public JiraConfigurationService()
        {
            _httpClient = new HttpClient();
            //TODO убрать это нахрен отсюда
            var byteArray = Encoding.ASCII.GetBytes("testuser:testpass");
            _httpClient.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }

        public async Task CreateWebhook(string url, WebHookSettings settings)
        {
            var content = new StringContent(JsonConvert.SerializeObject(settings), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync(url, content);
        }
    }
}