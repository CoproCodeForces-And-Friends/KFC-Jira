using KFCJira.Models.JiraIssue;

namespace KFCJira.Models.Issue
{
    public class IssueModel
    {
        public string Key { get; set; }
        public  IssueFieldsModel Fields { get; set; }
    }
}