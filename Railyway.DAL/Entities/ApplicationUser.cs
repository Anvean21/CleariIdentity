using Microsoft.AspNet.Identity.EntityFramework;

namespace Railway.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
