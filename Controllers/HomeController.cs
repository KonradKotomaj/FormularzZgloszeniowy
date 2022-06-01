using Microsoft.AspNetCore.Mvc;
using ApplicationFormular.Models;
using System.Linq;

namespace ApplicationFormular.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ApplicationForm()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult ApplicationForm(ParticipantDetails participantDetails)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(participantDetails);
                return View("ThankYou", participantDetails);
            }
            else
            {
                return View();
            }    
        }

        public ViewResult ParticipantList()
        {
            return View(Repository.Details.Where(r => r.WillParticipate == true));
        }
    }
}
