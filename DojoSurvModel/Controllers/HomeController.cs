using Microsoft.AspNetCore.Mvc;
using DojoSurvModel.Models;

namespace DojoSurvModel.Controller
{
  public class HomeController : Controller
{

   [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

[HttpPost("survey")]
public IActionResult View(string name, string location, string language, string comment )
{
    // Handle your form submission here
    
}


}



}

