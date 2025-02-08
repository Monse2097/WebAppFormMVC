using Microsoft.EntityFrameworkCore;

namespace WebAppFormMVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

        public DbSet<ContactMessage> ContactMessage { get; set; }
    }
}
