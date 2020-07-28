using System;

namespace HelpDeskAPI.Repository.Schemas
{
    public class JuridicalPerson
    {
        public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string CNPJ { get; set; }
        public string CompanyName { get; set; }
        public Guid ContactID { get; set; }
        public Guid PhoneTypeID { get; set; }
        public Guid AddressID { get; set; }
    }
}
