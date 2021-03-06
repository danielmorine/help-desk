﻿using System.Collections;
using System.Collections.Generic;

namespace HelpDeskAPI.Repository.Schemas
{
    public class State
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string Abbrev { get; set; }

        public virtual Address Address { get; set; }
        public virtual City City { get; set; } 
    }
}
