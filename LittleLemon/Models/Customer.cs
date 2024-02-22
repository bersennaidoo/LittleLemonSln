using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LittleLemon.Models;

public class Customer
{
    [Column("CustomerId")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Customer fname is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the FName is 60 characters.")]
    public string? FName { get; set; }
    
    [Required(ErrorMessage = "Customer lname is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the LName is 60 characters.")]
    public string? LName { get; set; }

    public ICollection<Contact>? Contacts { get; set; }
    public ICollection<Order>? Orders { get; set; }
}


