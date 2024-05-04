using Microsoft.AspNetCore.Mvc;

namespace MODELDEMO.Controllers{
    public class HomeController : Controller
    {
        [Route("Index")]
        [Route("/")]
        public string Index(){
            return "Hello world";
        }
    }
}