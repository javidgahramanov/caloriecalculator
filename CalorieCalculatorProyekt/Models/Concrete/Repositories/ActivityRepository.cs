using System;
using System.Collections.Generic;
using System.Linq;
using CalorieCalculatorProyekt.Models.Interfaces;

namespace CalorieCalculatorProyekt.Models.Concrete.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IDbContext _dbContext;

        public ActivityRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Activities entity)
        {
            _dbContext.Activitieses.Add(entity);
        }

        public void Remove(Activities entity)
        {
            _dbContext.Activitieses.Attach(entity);
            _dbContext.Activitieses.Remove(entity);
        }

        public void Update(Activities entity)
        {
            Activities act = _dbContext.Activitieses.Single(x => x.ActivityId == entity.ActivityId);
            act.ActivityName = entity.ActivityName;
            act.KkalMin = entity.KkalMin;
        }

        public IEnumerable<Activities> GetData()
        {
            return _dbContext.Activitieses;
        }

        public Activities GetData(Func<Activities, bool> predicate)
        {
            return _dbContext.Activitieses.Single(predicate);
        }

        public Activities GetData(int id)
        {
            return _dbContext.Activitieses.Single(x => x.ActivityId == id);

        }
    }
}