using System;

namespace HelpDeskAPI.Repository.Schemas
{
    public class Phone
    {
        public Guid ID { get; set; }
        public string PhoneNumber { get; set; }
        public byte PhoneTypeID { get; set; }
    }
}
