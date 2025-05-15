using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Pricing
{
    public int PricingID { get; set; }

    [Required]
    [Display(Name = "Service Description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Service Location")]
    public string Location { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Currency)]
    [Display(Name = "Price")]
    public decimal Price { get; set; }

    public List<Contact>? Contacts { get; set; }
}
