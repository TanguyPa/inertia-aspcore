using InertiaAspNetCore.MVC.React.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;

namespace InertiaAspNetCore.MVC.React.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("counter")]
    public IActionResult Counter()
    {
        return Inertia.Render("Counter");
    }

    [HttpGet("users/{id}/display")]
    public IActionResult DisplayUser(int id)
    {
        User user = new User
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe"
        };
        return Inertia.Render("DisplayUser", user);
    }


    [HttpGet("users/{id}/edit")]
    public IActionResult EditUser(int id)
    {
        User user = new User
        {
            Id = 2,
            FirstName = "Joe",
            LastName = "Doe"
        };
        return Inertia.Render("EditUser", user);
    }

    [HttpPost("users/{id}/edit")]
    public IActionResult EditUser(User model, int id)
    {
        // Do something with form data
        //.....

        // Redirect to ASP MVC view
        return Inertia.Location(Url.Action("Index"));
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
