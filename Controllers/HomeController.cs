using System;
using ASPIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPIntro.Controllers
{
    public class HomeController : Controller
    {
        Destination[] travelDestinations = new Destination[]
        {
            new Destination("Longyearbyen", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.arctictoday.com%2Fwp-content%2Fuploads%2F2018%2F02%2Fnorway-svalbard-longyearbyen_tommy-dahl-markussen-sysselmannen-.jpg&f=1&nofb=1"),
            new Destination("Solovetsky Islands", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.airpano.ru%2Ffiles%2Fsolovki-russia%2Fimages%2Fimage1.jpg&f=1&nofb=1"),
            new Destination("Socotra", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fs-media-cache-ak0.pinimg.com%2F736x%2F85%2F2f%2Fc2%2F852fc232f5a5a750405df098b9ff4e1c.jpg&f=1&nofb=1"),
            new Destination("Bhutan", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.worldtravelguide.net%2Fwp-content%2Fuploads%2F2016%2F08%2Fshu-Bhutan-TaktshangGoemba-512983621-Kai19-copy.jpg&f=1&nofb=1"),
            new Destination("Hell", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Fsmashverse%2Fimages%2F7%2F73%2FHell.jpg%2Frevision%2Flatest%3Fcb%3D20160408012921&f=1&nofb=1"),
        };

        [HttpGet("/")]
        public ViewResult Index()
        {
            ViewBag.TravelDestinations = travelDestinations;

            User tourist = new User("Lousy", "Tourist");

            HomePage homePageModel = new HomePage(tourist, travelDestinations);

            return View(homePageModel);
        }

        [HttpGet("/travel/{destinationName}")]
        public ViewResult Destination(string destinationName)
        {
            Console.WriteLine("******************************");
            Console.WriteLine(destinationName);
            Console.WriteLine("******************************");

            Destination chosenDestination = null;
            foreach (Destination dest in travelDestinations)
            {
                if (destinationName == dest.Name)
                {
                    chosenDestination = dest;
                }
            }

            // Redirect to Index method / 'action'
            return View("Destination", chosenDestination);
        }

        [HttpGet("/register")]
        public ViewResult Register()
        {
            return View();
        }

        [HttpPost("/register/process")]
        public RedirectToActionResult Register(User newUser)
        {
            Console.WriteLine(newUser.FirstName);
            return RedirectToAction("Index");
        }
    }
}