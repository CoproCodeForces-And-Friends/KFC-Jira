using KFCJira.Models.Issue;
 
 namespace KFCJira.Models.JiraIssue
 {
     public class IssueLinkModel
     {
         public IssueLinkTypeModel  Type { get; set; }
         public IssueModel OutwardIssue { get; set; }
     }
 }