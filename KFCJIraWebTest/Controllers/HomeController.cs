using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using KFCJIraWebTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace KFCJIraWebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIssueManager _manager;

        public HomeController(IIssueManager manager)
        {
            _manager = manager;
        }
        
        public IActionResult Index()
        {
            var model = new IssueCollectionModel()
            {
                Issues = _manager.GetAllIssues()
            };
            
            return View(model);
        }
    }
}