using System;
using System.ComponentModel.DataAnnotations;

namespace tech_bytes_demo.Dtos.Books;

public class CreateUpdateBookRequest
{
    [Required(ErrorMessage = "Title is required.")]
    [StringLength(100, ErrorMessage = "Title must be between 1 and 100 characters.")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "Author is required.")]
    [StringLength(100, ErrorMessage = "Author name must be between 1 and 100 characters.")]
    public required string Author { get; set; }

    [Required(ErrorMessage = "ISBN is required.")]
    [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Invalid ISBN format.")]
    [StringLength(20, ErrorMessage = "ISBN must be up to 20 characters.")]
    public required string ISBN { get; set; }

    [DataType(DataType.Date)]
    public DateTime? PublishedDate { get; set; }

    [Range(1, 10000, ErrorMessage = "Pages must be between 1 and 10,000.")]
    public int? Pages { get; set; }
}
