using System;

namespace HelpDeskAPI.Repository.Schemas
{
    public class Phone
    {
        public Guid ID { get; set; }
        public string PhoneNumber { get; set; }
        public byte PhoneTypeID { get; set; }
        public Guid OwnerID { get; set; }

        public PhoneType PhoneType { get; set; }
    }
}
