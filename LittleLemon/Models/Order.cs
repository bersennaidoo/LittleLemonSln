using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LittleLemon.Models;

public class Order
{
    [Column("OrderId")]
    public int Id { get; set; }

    [Display(Name= "Order Date")]
    [DataType(DataType.Date)]
    public DateTime OrderDate { get; set; }

    [Required(ErrorMessage = "OrderQuantity is a required field.")]
    public int OrderQuantity { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal OrderCost { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public Customer? Customer { get; set; }
}







