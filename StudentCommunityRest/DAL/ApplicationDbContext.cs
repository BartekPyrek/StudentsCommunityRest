using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using StudentCommunityRest.Models;

namespace StudentCommunityRest.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            //: base("DefaultConnection", throwIfV1Schema: false)
            : base("MyDbConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Academy> Academies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Moderate> Moderates { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}