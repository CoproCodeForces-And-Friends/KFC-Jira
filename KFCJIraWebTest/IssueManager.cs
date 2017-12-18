using System.Collections.Generic;
using KFCJira.Models;

namespace KFCJIraWebTest
{
    public interface IIssueManager
    {
        void SaveIssue(KFCIssue issue);
        KFCIssue[] GetAllIssues();
    }
    public class IssueManager: IIssueManager
    {
        private readonly List<KFCIssue> _issues = new List<KFCIssue>();
        public void SaveIssue(KFCIssue issue)
        {
           _issues.Add(issue);
        }

        public KFCIssue[] GetAllIssues()
        {
            return _issues.ToArray();
        }
    }
}