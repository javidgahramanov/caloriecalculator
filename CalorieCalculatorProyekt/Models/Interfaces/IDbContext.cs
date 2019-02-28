using System.Data.Entity;
using CalorieCalculatorProyekt.Models.Concrete;

namespace CalorieCalculatorProyekt.Models.Interfaces
{
    public interface IDbContext
    {
        DbSet<FoodProduct> FoodProducts { get; set; }
        DbSet<Dish> Dishes { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Activities> Activitieses { get; set; }
    }
}