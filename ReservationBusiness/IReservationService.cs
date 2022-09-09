using ReservationEntities;
using ReservationModelling;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationBusiness
{
   public interface IReservationService
    {
        Reservation Create(ReservationUpdateModel reservationUpdateModel);
        List<Reservation> GetAll();
        Reservation GetById(int id);
        Reservation Update(ReservationUpdateModel reservationUpdateModel);
        void Delete(int id);
    }
}
