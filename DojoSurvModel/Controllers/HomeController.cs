using Microsoft.AspNetCore.Mvc;
using DojoSurvModel.Models;

namespace DojoSurvModel.Controllers
{
  public class HomeController : Controller
{

   [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

[HttpPost("survey")]
public IActionResult Results(Survey survey)
{
    // Handle your form submission here
    return View(survey);
    
}


}



}

