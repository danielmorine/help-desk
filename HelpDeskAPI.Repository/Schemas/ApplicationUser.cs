using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpDeskAPI.Repository.Schemas
{
    public class ApplicationUser : IdentityUser
    {
        [NotMapped]
        public Guid ID
        {
            get
            {
                return Guid.Parse(this.Id);
            }
            set
            {
                this.Id = value.ToString();
            }
        }

        public string Name { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        [NotMapped]
        public string PasswordComparer { get; set; }

    }
}
