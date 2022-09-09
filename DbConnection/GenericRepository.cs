using ReservationBusiness;
using ReservationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DbConnection
{
   
        public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BEntity
        {
            private readonly ReservationDbContext reservationDbContext;
            public GenericRepository(ReservationDbContext _reservationDbContext)
            {
            reservationDbContext = _reservationDbContext;
            }
            public TEntity Create(TEntity entity)
            {

            reservationDbContext.Set<TEntity>().Add(entity);
            reservationDbContext.SaveChanges();
                return entity;
            }

            public void Delete(int id)
            {
                var deletedTEntity = GetById(id);
            reservationDbContext.Set<TEntity>().Remove(deletedTEntity);
            reservationDbContext.SaveChanges();

            }

            public List<TEntity> GetAll()
            {


                return reservationDbContext.Set<TEntity>().ToList();
            }

            public TEntity GetById(int id)
            {


                return reservationDbContext.Set<TEntity>().Find(id);

            }

            public TEntity Update(TEntity entity)
            {


            reservationDbContext.Set<TEntity>().Update(entity);
            reservationDbContext.SaveChanges();
                return entity;

            }
        }
}
