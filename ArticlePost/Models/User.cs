using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArticlePost.Models
{
    public class User
    {
        [Display(Name ="User ID")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [NotMapped]
        [Display(Name = "Confirm Email")]
        [Compare("Email",ErrorMessage ="Email doesn'tmatch")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmEmail { get; set; }
        [Required]
        [Display(Name = "Passsword")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [Compare("Password",ErrorMessage ="Password doesn't match")]
        [Display(Name ="Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Display(Name ="Date Of Birth")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [Display(Name ="Photo")]
        public string Image { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<CommentAndLike> CommentAndLikes { get; set; }

    }
}
