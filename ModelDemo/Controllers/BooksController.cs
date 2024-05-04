using Microsoft.AspNetCore.Mvc;

namespace MODELDEMO.Controllers
{
    public class BookController: Controller
    {
        // [Route("/Books")]
        [Route("/books/{bookid}/{author}")]
        public IActionResult Book(int? bookid, string? author){
            // int? bookid = Convert.ToInt32(Request.Query["bookid"]);
            // string? author = Convert.ToString(Request.Query["author"]);
            return Content($"book id is: {bookid} \n book authoer is: {author}", "text/plain");
        }
    }
}