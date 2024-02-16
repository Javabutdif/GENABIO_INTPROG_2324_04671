using Microsoft.AspNetCore.Mvc;
using ProjectFile.Models;
using System.Diagnostics;

namespace ProjectFile.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }
        
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm1(GuestInvite guest)
        {
            Invite.AddResponse(guest);
            
            return View(Invite.response);
        }




    }
}
