using System.Collections.Generic;

namespace Application.Model
{
    public class ApplicationPermission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ApplicationRole> Roles { get; set; }
    }
}
