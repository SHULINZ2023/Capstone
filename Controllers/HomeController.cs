using System.Diagnostics;
using Services;
using Microsoft.AspNetCore.Mvc;
using myDotNetMVCApp.Models;

namespace myDotNetMVCApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IndexService _IndexService;

    public HomeController(ILogger<HomeController> logger, IndexService indexService)
    {
        _logger = logger;
        _IndexService=indexService;
    }

    public IActionResult Index()
    {
        _logger.LogInformation("In controller home Index action");
        var indexModel = _IndexService.GetData4Index();
         string message = "Welcome to the Home Page!";
         ViewBag.Message = message;
        return View(indexModel);
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
}
