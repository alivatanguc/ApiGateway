using Contact.Infrastructure;
using DataDb;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository
{
    public class ContactRepository : GenericRepository<Contacting>, IContactRepository
    {

        public ContactRepository(ContactDbContext contactDbContext) : base(contactDbContext)
        {
        }

    }
}
