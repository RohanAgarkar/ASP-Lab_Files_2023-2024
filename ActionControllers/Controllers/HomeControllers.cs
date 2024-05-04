using Microsoft.AspNetCore.Mvc;

namespace ACTIONCONTROLLERS.Controllers
{
    public class HomeControllers : Controller
    {
        [ActionName("il")]       
        public string Index()
        {
            return "This is my index page";
        }

        [ActionName("Modify")]
        public string Edit()
        {
            
            return "Hello from updated method";
        }

        [HttpPost]
        public string Delete()
        {
            return "Hello from delete Method";
        }

        // [HttpPost]
        // public string Delete()
        // {
        //     return "Hello from delete Methods";
        // }
    }
}