using HeroUp.Models.Generic;
using System;
using System.Collections.Generic;

namespace HeroUp.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        List<T> GetAll();
        List<T> GetAllBy(Func<T, bool> predicate);
        T GetById(int id);
        T FindFirstBy(Func<T, bool> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
