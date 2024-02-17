using Microsoft.AspNetCore.Mvc;

namespace Vela.Presentation.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();
}
