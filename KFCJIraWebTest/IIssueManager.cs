using KFCJIraWebTest.Models;

namespace KFCJIraWebTest
{
    public interface IIssueManager
    {
        void SaveIssue(KFCIssue issue);
        KFCIssue[] GetAllIssues();
    }
}