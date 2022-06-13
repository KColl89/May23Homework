using May23Homework.Models;
using Microsoft.EntityFrameworkCore;

namespace May23Homework.Data
{
    public class ApplicationDbContext : DbContext
    {
        //this will allow to pull from database
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }

    }
}
