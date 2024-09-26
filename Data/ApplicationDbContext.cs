using Microsoft.EntityFrameworkCore;
using OneApi.Models;
using System.Collections.Generic;

namespace OneApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
