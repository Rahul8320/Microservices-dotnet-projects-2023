using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Bengali food",
                ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Frecipes.timesofindia.com%2Fphoto%2F61050397.cms%3Fimgsize%3D347173&f=1&nofb=1&ipt=3cdd2ac8943bddd345218b343980f594ba8659340471dfa65442c28a21d46246&ipo=images",
                CategoryName = "Appetizer",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Chicken Kosa",
                Price = 85,
                Description = "Bengali food",
                ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2F88ZnKxw8E-s%2Fmaxresdefault.jpg&f=1&nofb=1&ipt=e6912acfb5e5be74c17550bb88a4d411faeac06912c3e81bceaa1ca494103a72&ipo=images",
                CategoryName = "Non-veg",
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10,
                Description = "Bengali favourite sweet",
                ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.tasteatlas.com%2FImages%2FDishes%2F65905512a4d9433780979b91393530b0.jpg%3Fmw%3D1300&f=1&nofb=1&ipt=981b7c0eaee775bfd4a8f914ac0e460608fea433077762d90e21543e5a07961b&ipo=images",
                CategoryName = "Dessert",
            });
        }
    }
}
