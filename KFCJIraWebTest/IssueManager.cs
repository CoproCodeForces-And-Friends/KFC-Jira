using System.Collections.Generic;
using KFCJIraWebTest.Models;

namespace KFCJIraWebTest
{
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