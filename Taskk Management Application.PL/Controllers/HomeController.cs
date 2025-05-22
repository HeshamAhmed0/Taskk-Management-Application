using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Taskk_Management_Application.PL.Models;

namespace Taskk_Management_Application.PL.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
       public IActionResult Index()
        {
            return View();
        }
    }
}
