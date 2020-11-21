using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class Permission
    {
        public int ID { get; set; }
        public string PermissionName { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}
