using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using KFCJira.Models;
using KFCJira.Models.Issue;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace KFCJira.Services
{
    public class JiraService:IJiraService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseJiraUrl;
        
        public JiraService(IOptionsSnapshot<AppSettings> settings)
        {
            _httpClient = new HttpClient();
            //TODO убрать это нахрен отсюда
            var byteArray = Encoding.ASCII.GetBytes("testuser:testpass");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            _baseJiraUrl = $"{settings.Value.JiraUrl}";
        }

        public async Task<IssueModel> GetIssue(string key)
        {
            var getIssueUrl = API.Jira.GetIssue(_baseJiraUrl, key);
            var data = await _httpClient.GetStringAsync(getIssueUrl);
            var issue = (IssueModel) JsonConvert.DeserializeObject(data, typeof(IssueModel));
            return issue;
        }
    }
}