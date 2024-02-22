using Microsoft.AspNetCore.Mvc;
using Mission06_Imerlishvili.Models;
using SQLitePCL;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Mission06_Imerlishvili.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
       public HomeController(MovieApplicationContext name)
        { 
            _context = name;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View() ;
        }
        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieApplication(Application response)
        {
            response.Lent = response.Lent ?? ""; // Replace null with empty string
            response.Note = response.Note ?? "";
            _context.Applications.Add(response); // add record to database 
            _context.SaveChanges(); //permanently add 
            return View("Confirmation",response);
        }
    }
}
