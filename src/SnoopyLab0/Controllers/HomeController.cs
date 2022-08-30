using Microsoft.AspNetCore.Mvc;

namespace SnoopyLab0.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Search([FromBody]String srchType)
    {
        return Ok();
    }
}