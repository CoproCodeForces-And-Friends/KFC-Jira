namespace JiraConfigurationService
{
    public static class API
    {
        public static class Jira
        {
            public static string CreateWebhook(string baseUrl)
            {
                return $"{baseUrl}/rest/webhooks/1.0/webhook";
            }
        }
    }
}