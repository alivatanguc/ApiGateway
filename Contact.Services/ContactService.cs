using Contact.Infrastructure;
using Contact.Models;

using DataDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public Contacting Create(ContactUpdateModel contactModel)
        {
            Contacting contactdto = new Contacting()
            {

                FirstName = contactModel.FirstName,
                LastName = contactModel.LastName   
            };
            return _contactRepository.Create(contactdto);
        }

        

        public void Delete(int id)
        {
            var entity = _contactRepository.GetById(id);
            if(entity != null)
            {
                _contactRepository.Delete(id);
            }
            else
            {
                return;
            }
        }

        public List<Contacting> GetAll()
        {
            return _contactRepository.GetAll();
        }

        public Contacting GetById(int id)
        {
            if(id > 0)
            {
                return _contactRepository.GetById(id);
            }

            return _contactRepository.GetById(id);
        }

        public Contacting Update(ContactUpdateModel contactUpdateModel)
        {
            var entity = _contactRepository.GetById(contactUpdateModel.Id);
            if(entity != null)
            {
                Contacting contactdto = new Contacting()
                {
                    Id = contactUpdateModel.Id,
                    FirstName = contactUpdateModel.FirstName,
                    LastName = contactUpdateModel.LastName
                };
                return _contactRepository.Update(contactdto);
            }
            else
            {
                return null;
            }
        }
    }
}
