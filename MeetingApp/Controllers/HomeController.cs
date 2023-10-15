using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MetingApp.Controllers
{

public class HomeController : Controller
{

    public IActionResult Index()
    {

        ViewData["Selamlama"] = DateTime.Now.Hour > 12 ? "İyi günler" : "Günaydın";
        int UserCount = Repository.Users.Where(info => info.willatend == true).Count();
        var meetingInfo = new MeetingInfo()
        {
            Id = 1,
            Location = "Malatya , Teknokent",
            Date = new DateTime(2024 , 01 ,20 , 20 , 0, 0), //Burada Datetime modülü ile tarih ve saati içeren metodu kullandım
            NumberofPeople = UserCount
        };
        return View(meetingInfo);
    }

}

    
}