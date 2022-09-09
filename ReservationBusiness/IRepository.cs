using ReservationEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationBusiness
{
   
    
        public interface IRepository<TEntity> where TEntity : BEntity
        {
            List<TEntity> GetAll();
            TEntity GetById(int id);
            TEntity Create(TEntity entity);
            TEntity Update(TEntity entity);
            void Delete(int id);
        }
    }

