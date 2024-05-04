using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MVCTemplate.Models
{
public class BookModel
{
    public required string BookName { get; set; }
    public int? BookId { get; set; }
    public string Author { get; set; }

    [Range(1,99.99, ErrorMessage = "Price is out of range")]
    public decimal? Price {get; set;}
}
}