using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Contact
{
    public int ContactID { get; set; } // Primary Key

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Message { get; set; } = string.Empty;

    [Required]
    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; } = string.Empty;

    // Optional: Contacting a specific member
    public int? MemberID { get; set; }
    public Member? Member { get; set; }

    // Optional: Requesting a specific pricing tier
    public int? PricingID { get; set; }
    public Pricing? Pricing { get; set; }

    // Many-to-many through MemberContact (if applicable)
    public List<MemberContact>? MemberContacts { get; set; } = default!;
}

public class MemberContact
{
    public int ContactID { get; set; } // Composite PK/FK
    public int MemberID { get; set; }  // Composite PK/FK

    public Member Member { get; set; } = default!;
    public Contact Contact { get; set; } = default!;
}
