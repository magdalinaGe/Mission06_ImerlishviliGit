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
        public IActionResult MovieList()
        {
            var applications= _context.Applications.ToList();
   
            return View(applications);
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Applications
                .Single(x => x.ApplicationId == id);
            return View("MovieApplication", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            updatedInfo.Lent = updatedInfo.Lent ?? ""; // Replace null with empty string
            updatedInfo.Note = updatedInfo.Note ?? "";
            _context.SaveChanges ();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Applications
                .Single(x => x.ApplicationId == id);
            return View("Delete", recordToDelete);

        }
        [HttpPost]
        public IActionResult Delete(Application deletedInfo)
        {
         
           // deletedInfo.Lent = deletedInfo.Lent ?? ""; // Replace null with empty string
          //  deletedInfo.Note = deletedInfo.Note ?? "";
            _context.Applications.Remove(deletedInfo);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}
