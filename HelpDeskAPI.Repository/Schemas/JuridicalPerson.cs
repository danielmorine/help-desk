using System;
using System.Collections;
using System.Collections.Generic;

namespace HelpDeskAPI.Repository.Schemas
{
    public class JuridicalPerson
    {
        public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public Guid AddressID { get; set; }

        public virtual Address Adress { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
        public virtual ICollection<Phone> Phones { get; set; } = new HashSet<Phone>();
    }
}
