using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name ="Category")]
        public string CategoryName { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
