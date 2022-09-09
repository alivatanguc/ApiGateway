using Contact.Models;

using DataDb;
using System;


using System.Collections.Generic;
using System.Text;

namespace Contact.Infrastructure
{
   public interface IContactService
    {

        Contacting Create(ContactUpdateModel contactModel);
        List<Contacting> GetAll();
        Contacting GetById(int id);
        Contacting Update(ContactUpdateModel contactUpdateModel);
        void Delete(int id);
    }
}
