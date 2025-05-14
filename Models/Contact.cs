namespace FinalProject.Models;

public class Contact
{
    public int ContactID {get; set;} // Primary Key
    public string Name {get; set;} = string.Empty;

    public string Email {get; set;} = string.Empty;

    public string Message {get; set;} = string.Empty;

    public List<MemberContact>? MemberContacts {get; set;} = default!;
}

public class MemberContact
{
    public int ContactID {get; set;} // Composite Primary Key, Foreign Key 1
    public int MemberID {get; set;} // Composite Primary Key, Foreign Key 2
    public Member Member {get; set;} = default!; // Navigation Property
    public Contact Contact {get; set;} = default!; // Navigation Property
}