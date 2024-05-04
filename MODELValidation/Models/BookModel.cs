using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MODELValidation.Models;
public class BookModel
{
    [Required(ErrorMessage = "Book name is required")]
    [Display(Name = "Java")]
    [StringLength(100, MinimumLength = 5, ErrorMessage = "Book name must be between 5 and 100 characters long.")]
    [RegularExpression(@"^[A-Z]+$", ErrorMessage = "Book name must consist of one or more uppercase letters.")]
    public required string BookName { get; set; }
    public int? BookId { get; set; }
    public string Author { get; set; }

    [Range(1, 99.99, ErrorMessage = "Price out of range")]
    public decimal? Price {get; set;}
}