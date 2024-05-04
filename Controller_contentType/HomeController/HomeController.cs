using Markdig;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CONTROLLER_CONTENTTYPE.controller
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public string Index()
        {
            return "";
        }

        [Route("About")]
        public ContentResult About()
        {
            // string fileContent = System.IO.File.ReadAllText(@"HomeController\DataScience Theory.md");
            string fileContent = System.IO.File.ReadAllText(@"HomeController/main.html");

            string htmlContent = fileContent;

            return new ContentResult
            {
                Content = htmlContent,
                ContentType = "text/html"
            };
        }

        [Route("JSON")]
        public ContentResult employee()
        {
            return Content("{'name':'rohan'}", "application/json");
        }
    }
}