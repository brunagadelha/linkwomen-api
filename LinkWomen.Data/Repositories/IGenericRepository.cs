using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll(int id);
    }
}
