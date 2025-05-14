using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Members.Any())
        {
            return;
        }

        // Add Students, Courses, and StudentCourses below
        
List<Member> Members = new List<Member>
{
        new Member
    {
        Name = "John Doe",
        Bio = "As one of the newest additions to the group, John brings a deep respect for tradition and a strong sense of rhythm. His enthusiasm and dedication add fresh energy to every performance."
    },
    new Member
    {
        Name = "Jane Smith",
        Bio = "Jane captivates audiences with her warm vocal tone and graceful stage presence. Her passion for mariachi music shines through every heartfelt performance."
    },
    new Member
    {
        Name = "Michael Johnson",
        Bio = "Michael’s technical skill and bold trumpet sound give the group its signature flair. He blends power and precision in a way that lights up every stage he steps on."
    },
    new Member
    {
        Name = "Emily Davis",
        Bio = "Emily brings elegance and soul to the violin, weaving melody and emotion into every song. Her artistry helps elevate the ensemble’s sound to new heights."
    },
    new Member
    {
        Name = "Daniel Garcia",
        Bio = "Daniel’s strong foundation in traditional mariachi guitar makes him the group’s rhythmic cornerstone. His musical knowledge and leadership help keep the group grounded and in sync."
    },
    new Member
    {
        Name = "Sophia Martinez",
        Bio = "With her powerhouse vocals and natural charisma, Sophia commands attention every time she sings. She’s a storyteller at heart, bringing emotion to each lyric."
    },
    new Member
    {
        Name = "William Rodriguez",
        Bio = "William is the steady pulse of the ensemble on guitarrón. His deep, resonant bass lines give each song depth and drive that audiences can feel."
    },
    new Member
    {
        Name = "Olivia Wilson",
        Bio = "Olivia’s joyful spirit and musical versatility make her an essential part of the group. Whether on vihuela or harmonies, she adds color and warmth to every performance."
    },
    new Member
    {
        Name = "James Anderson",
        Bio = "James is a seasoned multi-instrumentalist with a love for mariachi history. His creative arrangements and attention to detail help shape the group’s signature sound."
    },
    new Member
    {
        Name = "Isabella Thomas",
        Bio = "Isabella brings youthful energy and a beautiful soprano voice to the group. Her dedication to the craft and natural talent make her a rising star in mariachi."
    },
    new Member
    {
        Name = "Alexander Lee",
        Bio = "Alexander’s bold trumpet solos and confident stage presence electrify audiences. His precision and flair bring a modern edge to traditional tunes."
    },
    new Member
    {
        Name = "Mia Perez",
        Bio = "Mia’s voice carries both strength and sweetness, making her a crowd favorite. She performs with heart, honoring the mariachi tradition while making it her own."
    }

};
context.AddRange(Members);
context.SaveChanges();

List<Contact> courses = new List<Contact>
{
    new Contact
    {
        Name = "Maria",
        Email = "emily@gmail.com",
        Message = "Y’all did amazing tonight! The music was beautiful, and the energy you brought made the event so special. Thank you for sharing your talent with us!"
    },
    new Contact
    {
        Name = "Landry",
        Email = "Landry@gmail.com",
        Message = "Good job, everyone! I was truly impressed by the professionalism and passion you all showed. Can’t wait to see your next performance!"
    },
    new Contact
    {
        Name = "Kyle",
        Email = "Kyle@gmail.com",
        Message = "Y’all did amazing, thanks so much for coming out to perform! Your presence elevated the entire evening and left a lasting impression on everyone there."
    },
    new Contact
    {
        Name = "Rudy",
        Email = "Rudy@gmail.com",
        Message = "Y’all did amazing — every song gave me chills. You all sounded incredible and brought so much life to the celebration. Keep up the great work!"
    },
    new Contact
    {
        Name = "Frank",
        Email = "Frank@gmail.com",
        Message = "Y’all did amazing, seriously! The harmonies, the instruments, the vibe — everything was on point. You made it a night to remember for all of us."
    }
};
context.AddRange(courses);
context.SaveChanges();

List<MemberContact> MemberContacts = new List<MemberContact>
{
      // Member 1 - John Doe
    new MemberContact { MemberID = 1, ContactID = 1 },
    new MemberContact { MemberID = 1, ContactID = 2 },

    // Member 2 - Jane Smith
    new MemberContact { MemberID = 2, ContactID = 2 },
    new MemberContact { MemberID = 2, ContactID = 3 },

    // Member 3 - Michael Johnson
    new MemberContact { MemberID = 3, ContactID = 3 },
    new MemberContact { MemberID = 3, ContactID = 4 },

    // Member 4 - Emily Davis
    new MemberContact { MemberID = 4, ContactID = 4 },
    new MemberContact { MemberID = 4, ContactID = 5 },

    // Member 5 - Daniel Garcia
    new MemberContact { MemberID = 5, ContactID = 1 },
    new MemberContact { MemberID = 5, ContactID = 5 },

    // Member 6 - Sophia Martinez
    new MemberContact { MemberID = 6, ContactID = 2 },
    new MemberContact { MemberID = 6, ContactID = 3 },

    // Member 7 - William Rodriguez
    new MemberContact { MemberID = 7, ContactID = 3 },
    new MemberContact { MemberID = 7, ContactID = 4 },

    // Member 8 - Olivia Wilson
    new MemberContact { MemberID = 8, ContactID = 4 },
    new MemberContact { MemberID = 8, ContactID = 5 },

    // Member 9 - James Anderson
    new MemberContact { MemberID = 9, ContactID = 1 },
    new MemberContact { MemberID = 9, ContactID = 2 },

    // Member 10 - Isabella Thomas
    new MemberContact { MemberID = 10, ContactID = 2 },
    new MemberContact { MemberID = 10, ContactID = 5 },

    // Member 11 - Alexander Lee
    new MemberContact { MemberID = 11, ContactID = 3 },
    new MemberContact { MemberID = 11, ContactID = 4 },

    // Member 12 - Mia Perez
    new MemberContact { MemberID = 12, ContactID = 1 },
    new MemberContact { MemberID = 12, ContactID = 5 }


};
context.AddRange(MemberContacts);
context.SaveChanges();

    }
}