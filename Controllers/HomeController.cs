using Microsoft.AspNetCore.Mvc;
using dojoSurveyy.Models;

namespace dojoSurveyy
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public IActionResult Info(Survey userSurvey)
        {
            System.Console.WriteLine("Hello");
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("Its valid");
                return View("Info", userSurvey);
            }
            else
            {
                System.Console.WriteLine("Its not valid");
                return View("Index");
            }
        }
    }
}