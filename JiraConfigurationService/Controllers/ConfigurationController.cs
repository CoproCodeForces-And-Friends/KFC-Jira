using System;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using JiraConfigurationService.Models;
using JiraConfigurationService.Services;
using Microsoft.AspNetCore.Mvc;

namespace JiraConfigurationService.Controllers
{
    [Route("api/[controller]")]
    public class ConfigurationController:Controller
    {
        private readonly IJiraConfigurationService _jiraConfiguration;
        public ConfigurationController(IJiraConfigurationService jiraConfiguration)
        {
            _jiraConfiguration = jiraConfiguration;
        }
        [HttpPost("CreateHook")]
        public async Task CreateWebhook([FromBody] WebHookModel model)
        {
            var url = model.JiraUrl;
            var settings = MapToSettings(model);
            await _jiraConfiguration.CreateWebhook(url, settings);
        }
    
        
        //TODO вынести отсюда
        private WebHookSettings MapToSettings(WebHookModel model)
        {
            return new WebHookSettings()
            {
                Url = model.WebHookUrl,
                Name = model.WebHookName,
                JqlFilter = model.JqlFilter,
                ExcludeIssueDetails = model.ExcludeIssueDetails,
                Events = model.Events.Select(GetWebhookEventByType).ToArray()
            };
        }

        //TODO вынести отсюда
        private string GetWebhookEventByType(WebHookEventType type)
        {
            switch (type)
            {
                 case WebHookEventType.IssueCreated:
                     return "jira:issue_created";
                 case WebHookEventType.IssueUpdated:
                     return "jira:issue_updated";
                 default:
                     //TODO реализовать остальные эвенты
                     throw new NotImplementedException();
            }
        }
    }
}