using System.Threading.Tasks;
using JiraConfigurationService.Models;

namespace JiraConfigurationService.Services
{
    public interface IJiraConfigurationService
    {
        Task CreateWebhook(string url,string password, string login,  WebHookSettings settings);
    }
}