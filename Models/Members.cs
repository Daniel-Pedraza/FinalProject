using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Member
{
    public int MemberID {get; set;} // Primary Key

    [Display(Name = "Name")]
    public string Name {get; set;} = string.Empty;
    
    [Display(Name = "Biography")]
    public string Bio {get; set;} = string.Empty;

    public List<MemberContact>? MemberContacts {get; set;} = default!;
}