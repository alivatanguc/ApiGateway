using Contact.Infrastructure;
using Contact.Models;

using DataDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericRepository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {




        private readonly ContactDbContext contactDbContext;
        public GenericRepository(ContactDbContext _contactDbContext)
        {
            contactDbContext = _contactDbContext;
        }



        public TEntity Create(TEntity entity)
        {

            contactDbContext.Set<TEntity>().Add(entity);
            contactDbContext.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var deletedTEntity = GetById(id);
            contactDbContext.Set<TEntity>().Remove(deletedTEntity);
            contactDbContext.SaveChanges();

        }

        public List<TEntity> GetAll()
        {


            return contactDbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {


            return contactDbContext.Set<TEntity>().Find(id);

        }

        public TEntity Update(TEntity entity)
        {


            contactDbContext.Set<TEntity>().Update(entity);
            contactDbContext.SaveChanges();
            return entity;

        }
    }
}
