namespace KFCJira
{
    public static class API
    {
        public static class Jira
        {
            public static string GetIssue(string baseUrl, string key)
            {
                return $"{baseUrl}/rest/api/2/issue/{key}";
            }
        }

        public static class Storage
        {
            public static string SendToStorage(string baseUrl)
            {
                return $"{baseUrl}/saveissue";
            }
        }
    }
}