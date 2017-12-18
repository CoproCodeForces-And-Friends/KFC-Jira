using System;

namespace KFCJira.Models.JiraIssue
{
    public class CommentModel
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        
    }
}