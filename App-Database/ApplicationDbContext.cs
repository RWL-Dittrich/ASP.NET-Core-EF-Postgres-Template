using Microsoft.EntityFrameworkCore;
using App_Database.Models;

namespace App_Database
{


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}
