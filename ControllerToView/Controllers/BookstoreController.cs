using Microsoft.AspNetCore.Mvc;

namespace ControllerToView.Controllers{
    public class BookstoreController: Controller{
        public IActionResult Index(){
            List<int> years = new List<int> {2004,2005,2006};
            string[] names = {"Rohan", "King", "Siddharth"};
            ViewData["Name"] = names;
            ViewData["Author"] = "Mcgrow Hills";
            ViewData["Price"] = 5000;
            ViewBag.years = years;
            return View();
        }
    }
}