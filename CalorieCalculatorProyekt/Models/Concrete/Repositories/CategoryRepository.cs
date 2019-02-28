using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly IDbContext _dbContext;

        public CategoryRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Category entity)
        {
            _dbContext.Categories.Add(entity);
        }

        public void Remove(Category entity)
        {
            _dbContext.Categories.Attach(entity);
            _dbContext.Categories.Remove(entity);
        }

        public void Update(Category entity)
        {
            Category category = _dbContext.Categories.Single(x => x.CategoryId == entity.CategoryId);
            category.CategoryName = entity.CategoryName;
        }

        public IEnumerable<Category> GetData()
        {
            return _dbContext.Categories;
        }

        public Category GetData(int id)
        {
            return _dbContext.Categories.Single(x => x.CategoryId == id);

        }

        public Category GetData(Func<Category, bool> predicate)
        {
            return _dbContext.Categories.Single(predicate);
        }
    }
}