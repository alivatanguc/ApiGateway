using Contact.Models;
using DataDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Create(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(int id);
    }
}
