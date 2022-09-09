using ReservationBusiness;
using ReservationEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbConnection
{
   public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ReservationDbContext reservationDbContext) :base(reservationDbContext)
        {
        }
    }
}
