using System;

namespace HelpDeskAPI.Repository.Schemas
{
    public class Address
    {
        public Guid ID { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string AddressName { get; set; }
        public string AddressNubmer { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string Cep { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
    }
}
