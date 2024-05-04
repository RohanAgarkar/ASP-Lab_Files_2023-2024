using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Database.Controllers;

public class HomeController : Controller
{
    private readonly EmployeeDBContext employeeDB;

    // public EmployeeDBContext employeeDB { get; private set; }

    // private readonly ILogger<HomeController> _logger;

    // public HomeController(ILogger<HomeController> logger)
    // {
    //     _logger = logger;
    // }

    public HomeController(EmployeeDBContext employeeDB)
    {
        this.employeeDB = employeeDB;
    }

    public IActionResult Index()
    {
        var eData = employeeDB.Employees.ToList();
        return View(eData);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Employee std)
    {
        if (ModelState.IsValid){
            await employeeDB.Employees.AddAsync(std);
            await employeeDB.SaveChangesAsync();
            TempData["insert"] = "Database successfully updated";
            return RedirectToAction("Index", "Home");
        }
        return View(std);
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
