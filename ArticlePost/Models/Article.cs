using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class Article
    {
        [Display(Name ="Article ID")]
        public int ID { get; set; }
        [Display(Name ="Article Title")]
        [Required]
        public string Title { get; set; }
        [Display(Name ="Article Description")]
        [Required]
        public string Description { get; set; }
        [Display(Name ="Article Photo")]
        [Required]
        public string Image { get; set; }
        [Display(Name = "Article Date")]
        [DataType(DataType.Date)]
        public DateTime DateofPosting { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<CommentAndLike> CommentAndLikes { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }

    }
}
