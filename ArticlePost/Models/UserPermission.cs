using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class UserPermission
    {
        public int ID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Permission")]
        public int PermissionID { get; set; }
        public virtual User User { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
