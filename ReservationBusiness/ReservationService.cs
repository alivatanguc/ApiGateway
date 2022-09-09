using ReservationEntities;
using ReservationModelling;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationBusiness
{
    public class ReservationService : IReservationService
    {


        private readonly IReservationRepository reservationRepository;
        public ReservationService(IReservationRepository _reservationRepository)
        {
            reservationRepository = _reservationRepository;
        }
        public Reservation Create(ReservationUpdateModel reservationUpdateModel)
        {
            Reservation reservation = new Reservation()
            {

                BookingNumber = reservationUpdateModel.BookingNumber,
                Id = reservationUpdateModel.Id,
                Price=reservationUpdateModel.Price
            };
            return reservationRepository.Create(reservation);
        }

        public void Delete(int id)
        {
            var entity = reservationRepository.GetById(id);
            if(entity != null)
            {
                reservationRepository.Delete(id);
            }
            else
            {
                return;
            }
        }

        public List<Reservation> GetAll()
        {
            return reservationRepository.GetAll();
        }

        public Reservation GetById(int id)
        {
            if(id > 0)
            {
                return reservationRepository.GetById(id);
            }

           return reservationRepository.GetById(id);
            
        }

        public Reservation Update(ReservationUpdateModel reservationUpdateModel)
        {
            var entity = reservationRepository.GetById(reservationUpdateModel.Id);
            if(entity != null)
            {
                Reservation reservation = new Reservation()
                {
                    Id = reservationUpdateModel.Id,
                    BookingNumber = reservationUpdateModel.BookingNumber,
                    Price = reservationUpdateModel.Price
                };
                return reservationRepository.Update(reservation);
            }
            else
            {
                return null;
            }
        }
    }
}

   
    



   

  

   