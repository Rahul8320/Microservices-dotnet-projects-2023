using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "10OFF",
                DiscountAmount = 10
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "20OFF",
                DiscountAmount = 20
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "FIRST25",
                DiscountAmount = 25
            });

            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 4,
                CouponCode = "SPECIALBONUS35",
                DiscountAmount = 35
            });
        }
    }
}
