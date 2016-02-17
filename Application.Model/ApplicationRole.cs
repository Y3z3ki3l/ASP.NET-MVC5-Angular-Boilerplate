using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;


namespace Application.Model
{
    public class ApplicationRole: IdentityRole
    {
        public virtual ICollection<ApplicationPermission> Permissions { get; set; }
    }
}
