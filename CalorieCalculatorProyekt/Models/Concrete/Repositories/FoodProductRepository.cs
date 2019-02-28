using System;
using System.Collections.Generic;
using System.Linq;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete.Repositories
{
    public class FoodProductRepository : IFoodProductRepository
    {
        private readonly IDbContext _dbContext;

        public FoodProductRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(FoodProduct entity)
        {
            _dbContext.FoodProducts.Add(entity);
        }
        public void Remove(FoodProduct entity)
        {
            _dbContext.FoodProducts.Attach(entity);
            _dbContext.FoodProducts.Remove(entity);
        }

        public void Update(FoodProduct entity)
        {
            FoodProduct foodProduct = _dbContext.FoodProducts.Single(x => x.Id == entity.Id);
            foodProduct.A = entity.A;
            //update has not implemented yet.
        }

        public IEnumerable<FoodProduct> GetData()
        {
            return _dbContext.FoodProducts;
        }

        public FoodProduct GetData(int id)
        {
            return _dbContext.FoodProducts.Single(x => x.Id == id);
        }

        public FoodProduct GetData(Func<FoodProduct, bool> predicate)
        {
            return _dbContext.FoodProducts.Single(predicate);
        }
    }
}