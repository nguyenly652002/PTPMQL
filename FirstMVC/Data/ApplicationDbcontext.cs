using Microsoft.EntityFrameworkCore;
using FirstMVC.Models;
namespace FirstMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Customer> Customer { get; set;} 
    }

}