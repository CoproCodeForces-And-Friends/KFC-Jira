using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using KFCJira.Models;
using KFCJira.Models.Issue;
using KFCJira.Models.JiraIssue;
using Microsoft.AspNetCore.Server.Kestrel.Internal.System.Buffers;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace KFCJira.Services
{
    public class StorageService:IStorageService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseStorageUrl;

        public StorageService(IOptionsSnapshot<AppSettings> settings)
        {
            _httpClient = new HttpClient();
            _baseStorageUrl = settings.Value.StorageUrl;
        }
        
        public async Task SendIssueToStorage(KFCIssue issue)
        {
            var storageUrl = API.Storage.SendToStorage(_baseStorageUrl);
            //TODO спрятать в отдельном классе
            var content = new StringContent(JsonConvert.SerializeObject(issue), Encoding.UTF8, "application/json");
            await _httpClient.PostAsync(storageUrl, content);
        }
    }
}