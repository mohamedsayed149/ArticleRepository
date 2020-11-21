using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class CommentAndLike
    {
        public int ID { get; set; }
        [ForeignKey("Article")]
        public int ArticleID { get; set; }
        public bool IsLiked { get; set; }
        public bool IsCommented { get; set; }
        public virtual Article Article { get; set; }
    }
}
