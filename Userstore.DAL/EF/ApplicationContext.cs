using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Railway.DAL.Entities;

namespace Railway.DAL.EF
{
    public class ApplicationContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
