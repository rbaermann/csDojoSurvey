using Microsoft.AspNetCore.Mvc;
using dojoSurveyy.Models;

namespace dojoSurveyy
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Info(Survey userSurvey)
        {
            return View("Info", userSurvey);
        }
    }
}