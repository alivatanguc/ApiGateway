using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationBusiness;
using ReservationModelling;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reservation.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ReservationsController : Controller
    {
        private IReservationService reservationService;
        public ReservationsController(IReservationService _reservationService)
        {
            reservationService = _reservationService;

        }
        [HttpGet]
        public IActionResult Get()
        {
            var reservation = reservationService.GetAll();
            return Ok(reservation);
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var reservation = reservationService.GetById(id);
            if(reservation != null)
            {
                return Ok(reservation);

            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult Post([FromBody]ReservationUpdateModel reservationModel)
        {

            var createdReservation = reservationService.Create(reservationModel);

            return CreatedAtAction("Get", new { id = createdReservation.Id }, createdReservation);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ReservationUpdateModel reservationUpdateModel)
        {
            if(reservationService.GetById(reservationUpdateModel.Id) != null)
            {
                return Ok(reservationService.Update(reservationUpdateModel));
            }
            return NotFound();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(reservationService.GetById(id) != null)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
       
