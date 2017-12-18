using System.Threading.Tasks;
using KFCJira.Models;
using KFCJira.Models.Issue;
using KFCJira.Models.JiraIssue;

namespace KFCJira.Services
{
    public interface IStorageService
    {
        Task SendIssueToStorage(KFCIssue issue);
    }
}