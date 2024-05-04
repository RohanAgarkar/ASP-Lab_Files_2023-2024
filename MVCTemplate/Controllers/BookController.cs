using Microsoft.AspNetCore.Mvc;
using MVCTemplate.Models;

namespace MVCTemplates.Controllers
{
    public class BookController: Controller
    {
        [Route("books/{BookId?}/{BookName?}/{Price?}")]
        public ViewResult BookData(BookModel b1)
        {
            ViewData["BookID"] = b1.BookId.Value.ToString();
            ViewData["Author"] = b1.BookName;
            ViewData["Price"] = b1.Price;
            return View();
        }
        [Route("NextBook")]
        public ViewResult NextBook(BookModel b1)
        {
            return View(b1);
        }
    }
}