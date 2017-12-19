using Microsoft.AspNetCore.Rewrite.Internal;

namespace JiraConfigurationService.Models
{
    public class WebHookModel
    {
        public string JiraUrl { get; set; }
        public string WebHookName { get; set; }
        public string WebHookUrl { get; set; }
        public WebHookEventType[] Events { get; set; }
        public string JqlFilter { get; set; }
        public bool ExcludeIssueDetails { get; set; }
    }
}