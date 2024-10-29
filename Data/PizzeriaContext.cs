using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzeriaApp.Models;


namespace PizzeriaApp.Data
{
    public class PizzeriaContext : IdentityDbContext<IdentityUser>
    {
        public PizzeriaContext(DbContextOptions<PizzeriaContext> options)
            : base(options)
        {
        }

        public DbSet<Pizza> Pizza { get; set; }
        // public DbSet<Order> Order { get; set; }
    }
}
