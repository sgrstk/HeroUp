using HeroUp.Data;
using HeroUp.Models.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroUp.Repository
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected readonly ApplicationDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            _entities = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            T entity = _entities.SingleOrDefault(s => s.Id == id);
            _entities.Remove(entity);
            _context.SaveChanges();
        }
        
        public T FindFirstBy(Func<T, bool> predicate)
        {
            return _entities.FirstOrDefault(predicate);
        }

        public List<T> GetAllBy(Func<T, bool> predicate)
        {
            return _entities.Where(predicate).ToList();
        }
    }
}
