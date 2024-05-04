using Microsoft.AspNetCore.Mvc;
using MODELValidation.Models;

namespace MODELValidation.Controllers
{
    public class BookController: Controller
    {
        [Route("books/{BookId?}/{BookName?}/{Price}")]
        public IActionResult BookData(BookModel b1)
        {
            if  (b1.BookId.HasValue == false){
                return Content("Book id is  not assign", "text/ plain");
            }
            if (!ModelState.IsValid)
            {
                List<String> errors = new List<string>();
                foreach (var values in ModelState.Values)
                {
                foreach (var error in values.Errors){errors.Add(error.ErrorMessage);}
                }
                string errormsg = String.Join("\n", errors);
                return BadRequest(errormsg);
            }
            return Content("Book id is "+b1.BookId.Value.ToString()+"\nBook price is "+b1.Price, "text/plain");
        }
    }
}