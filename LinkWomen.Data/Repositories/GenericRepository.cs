using LinkWomen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWomen.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly LinkWomenContext _context;

        public GenericRepository()
        {
            _context = new LinkWomenContext(); 
        }

        public void Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges(); 
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<TEntity> GetAll(int id)
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
