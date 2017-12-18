using System.Threading.Tasks;
using KFCJira.Models;
using KFCJira.Models.Issue;

namespace KFCJira.Services
{
    public interface IJiraService
    {
        Task<IssueModel> GetIssue(string key);
    }
}