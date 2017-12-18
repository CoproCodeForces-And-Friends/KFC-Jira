using System;
using KFCJira.Models.Issue;

namespace KFCJira.Models.JiraIssue
{
    public class IssueFieldsModel
    {
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Description { get; set; }
        public CreatorModel Creator { get; set; }
        public AssigneeDeveloperModel Assignee { get; set; }
        public IssueStatusModel Status { get; set; }
        public IssueLinkModel[] IssueLinks { get; set; }
    }
}