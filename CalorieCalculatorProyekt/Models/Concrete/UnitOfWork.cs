using CalorieCalculatorProyekt.Models.Concrete.Repositories;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        public ActivityRepository ActivityRepository { get; set; }
        public CategoryRepository CategoryRepository { get; set; }
        public FoodProductRepository FoodProductRepository { get; set; }

        private readonly CalculatorDbContext _dbContext;

        public UnitOfWork(CalculatorDbContext dbContext)
        {
            _dbContext = dbContext;
            ActivityRepository = new ActivityRepository(_dbContext);
            CategoryRepository = new CategoryRepository(_dbContext);
            FoodProductRepository = new FoodProductRepository(_dbContext);
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}