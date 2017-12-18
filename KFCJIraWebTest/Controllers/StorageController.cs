using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using KFCJira.Models;
using Microsoft.AspNetCore.Mvc;

namespace KFCJIraWebTest.Controllers
{
    [Route("api/[controller]")]

    public class StorageController : Controller
    {
        private readonly IIssueManager _manager;
        public StorageController(IIssueManager manager)
        {
            _manager = manager;
        }
        
        // POST api/jira/webhook
        [HttpPost("SaveIssue")]
        public void SaveIssue([FromBody] KFCIssue value)
        {
            _manager.SaveIssue(value);
        }
    }
}