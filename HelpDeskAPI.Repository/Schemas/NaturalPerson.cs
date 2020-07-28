using System;

namespace HelpDeskAPI.Repository.Schemas
{
    public class NaturalPerson
    {
        public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public Guid AddressID { get; set; }
    }
}
