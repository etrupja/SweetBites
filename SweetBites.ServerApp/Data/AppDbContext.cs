using Microsoft.EntityFrameworkCore;
using SweetBites.ServerApp.Data.Models;

namespace SweetBites.ServerApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Sweet> Sweets { get; set; }
    }
}
