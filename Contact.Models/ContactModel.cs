using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Models
{
   public  class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
