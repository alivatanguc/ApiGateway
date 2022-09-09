using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationEntities
{
    public class Reservation :BEntity
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime? Checkin { get; set; } = DateTime.Now;
        public DateTime? Checkout { get; set; } = DateTime.Now;
        public DateTime? DateTimer{ get; set; } = DateTime.Now;
        public double Price { get; set; }
    }
}
