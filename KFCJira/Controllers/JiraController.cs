using System;
using System.Threading.Tasks;
using KFCJira.Models;
using KFCJira.Models.Issue;
using KFCJira.Models.JiraIssue;
using KFCJira.Services;
using Microsoft.AspNetCore.Mvc;

namespace KFCJira.Controllers
{
    [Route("api/[controller]")]

    public class JiraController : Controller
    {
        private readonly IJiraService _jiraService;
        private readonly IStorageService _storageService;

        public JiraController(IJiraService jiraService, IStorageService storageService)
        {
            _jiraService = jiraService;
            _storageService = storageService;
        }
        
        // POST api/jira/webhook
        [HttpPost("Webhook")]
        public async Task PostWebhook([FromBody] WebHookModel value)
        {
//            var key = value.Issue.Key;
//            var issue = await _jiraService.GetIssue(key);
            var simpleIssue = MapToSimpleIssue(value.Issue);
            await _storageService.SendIssueToStorage(simpleIssue);
        }
        
        //TODO вынести отсюда
        private KFCIssue MapToSimpleIssue(IssueModel issue)
        {
            var fields = issue.Fields;
            return new KFCIssue()
            {
                CreationDate = fields.Created,
                Description = fields.Description,
                Name = issue.Key,
                Status = fields.Status.Name,
            };
        }

    }
}