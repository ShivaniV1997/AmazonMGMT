using AmazonMGMT.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace AmazonMGMT.Infrastructure
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> option):base(option) 
        {
        
        }
       public DbSet<Brand> Brand {  get; set; }

        public DbSet<Product> Product {  get; set; }
    }
}
