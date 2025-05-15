using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite key for MemberContact
        modelBuilder.Entity<MemberContact>().HasKey(mc => new { mc.ContactID, mc.MemberID });
    }

    public DbSet<Member> Members { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<MemberContact> MemberContacts { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
}
