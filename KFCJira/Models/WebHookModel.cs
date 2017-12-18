using KFCJira.Models.Issue;
using KFCJira.Models.JiraIssue;

namespace KFCJira.Models
{
    public class WebHookModel
    {
        public IssueModel Issue { get; set; }
        public CommentModel Comment { get; set; }
        public string WebhookEvent { get; set; }
    }
}