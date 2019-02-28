using System;
using System.Collections.Generic;
using System.Web;

namespace CalorieCalculatorProyekt.Models.Interfaces
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetData();
        TEntity GetData(int id);

        TEntity GetData(Func<TEntity, bool> predicate);
    }
}