using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class Notification
    {
        public int ID { get; set; }
        [ForeignKey("Article")]
        public int ArticleID { get; set; }
        public string NotificationText { get; set; }
        public virtual Article Article { get; set; }
    }
}
