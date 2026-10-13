using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;


namespace RegistrationApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
[HttpPost]
public IActionResult Register(RegisterModel model)
{
    if (!ModelState.IsValid)
    {
        return View("Index");
    }

    ViewBag.FullName = model.FullName;

    return View("RegistrationSuccess");
}

}
