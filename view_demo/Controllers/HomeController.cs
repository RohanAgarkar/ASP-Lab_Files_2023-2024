using Microsoft.AspNetCore.Mvc;

namespace view_demo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
    }
}