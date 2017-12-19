namespace JiraConfigurationService.Models
{
    public class WebHookSettings
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string[] Events { get; set; }
        public string JqlFilter { get; set; }
        public bool ExcludeIssueDetails { get; set; }
    }
}