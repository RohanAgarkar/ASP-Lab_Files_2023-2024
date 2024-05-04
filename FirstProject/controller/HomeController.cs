using Microsoft.AspNetCore.Mvc;

namespace FIRSTPROJECT.controller
{
	public class HomeController
    {
        [Route("Home")]
	    [Route("/")]
        public string Index()
        {
            return "This is index action of controller";
        }

        [Route("AboutUS")]
        public string AboutUs()
        {
            return "This is AboutUS action of controlelr";
        }

        [Route("/product/{id:int:min(1000):max(9999)}")]
        public string Products()
        {
            return "This is my product page";
        }
    }
}