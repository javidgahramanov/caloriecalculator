using CalorieCalculatorProyekt.Models.Concrete;
using CalorieCalculatorProyekt.Models.Concrete.Repositories;

namespace CalorieCalculatorProyekt.Models.Interfaces
{
    public interface IUnitOfWork
    {
        ActivityRepository ActivityRepository { get; set; }
        CategoryRepository CategoryRepository { get; set; }
        FoodProductRepository FoodProductRepository { get; set; }


        int Save();
    }
}