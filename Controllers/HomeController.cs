using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Money = new string[] { "Рубль", "Тенге", "Доллар" };
            ViewBag.Cities = new string[] { "Ульяновск", "Казань", "Москва" };
            string message = "Что за текст? <input>";
            return View((object)message);
            //return Viev(); 
        }
     
        [HttpGet]
        public ViewResult Form() => View();

        [HttpPost]
        public ViewResult Form(HomeModels x)
        {
            if (ModelState.IsValid) 
            {
                return View("Last", x);
            }
            else
            {
                return View();
            }
        }

    }
}

