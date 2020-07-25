using HelpDeskAPI.Repository.Context.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskAPI.Repository.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public string ConnectionString { get; set; }
    }
}
