using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationModelling
{
   public  class ReservationModel
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }
        public DateTime? DateTime { get; set; }
        public double Price { get; set; }
    }
}
