using System;
using Microsoft.AspNetCore.Mvc;

namespace ASPIntro.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("travel/{Path}")]
        public RedirectToActionResult Unkown(string path)
        {
            Console.WriteLine("******************************");
            Console.WriteLine(path);
            Console.WriteLine("******************************");
            // Redirect to Index method / 'action'
            return RedirectToAction("Index");
        }
    }
}