using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    // Needed for Many-to-Many association entity
    // StudentCourse entity has 2 attributes as the primary key.
    // This code tells EF Core that StudentID and CourseID combine for the primary key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MemberContact>().HasKey(s => new {s.ContactID, s.MemberID});
    }

    public DbSet<Member> Members {get; set;}
    public DbSet<Contact> Contacts {get; set;}
    public DbSet<MemberContact> MemberContacts {get; set;}
}