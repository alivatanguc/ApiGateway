using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Infrastructure;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;



namespace Contact.Api.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private IContactService contactService;
        public ContactController(IContactService _contactService)
        {
            contactService = _contactService;
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            var contact = contactService.GetAll();
            return Ok(contact);
        }

       
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var contact = contactService.GetById(id);
            if(contact != null)
            {
                return Ok(contact);

            }
            return NotFound();
        }

       
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ContactUpdateModel contactUpdateModel)
        {
            if(contactService.GetById(contactUpdateModel.Id) != null)
            {
                return Ok(contactService.Update(contactUpdateModel));
            }
            return NotFound();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(contactService.GetById(id) != null)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
