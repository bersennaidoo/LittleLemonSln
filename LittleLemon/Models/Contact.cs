using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LittleLemon.Models;

public class Contact
{
    [Column("ContactId")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Contact number is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for Contact number is 30 characters.")]
    public string? ContactNumber { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
}
