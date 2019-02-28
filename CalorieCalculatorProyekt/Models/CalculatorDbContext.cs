using System.Data.Entity;
using CalorieCalculatorProyekt.Models.Concrete;
using CalorieCalculatorProyekt.Models.Interfaces;
using Activity = System.EnterpriseServices.Activity;

namespace CalorieCalculatorProyekt.Models
{
    public class CalculatorDbContext : DbContext,IDbContext
    {
        public DbSet<FoodProduct> FoodProducts { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activities> Activitieses { get; set; }

        public CalculatorDbContext() : base("CalorieDbConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodProduct>().Property(x => x.B1).IsOptional();
            modelBuilder.Entity<FoodProduct>().Property(x => x.B2).IsOptional();
            modelBuilder.Entity<FoodProduct>().Property(x => x.Fat).IsOptional();
        }
    }
}