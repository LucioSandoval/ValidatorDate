using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidadorFecha.Models;

namespace ValidadorFecha.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    [Route("/fecha")]
    public IActionResult Fecha(ValidatorDate modelo)
    {
        if (ModelState.IsValid)
        {
        
            return RedirectToAction("Privacy", modelo);
        }

        return View("Index");
    }


    public IActionResult Privacy(ValidatorDate modelo)
    {
        return View("Privacy", modelo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
