using System;
using System.Collections.Generic;
using System.Text;

namespace HelpDeskAPI.Repository.Schemas
{
    public class Contact
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
