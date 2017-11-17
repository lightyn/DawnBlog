using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DawnBlog.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

        public bool IsContentAuthor { get; set; }
        public bool IsAdmin { get; set; }

        [StringLength(24, ErrorMessage = "Username cannot be more than 24 characters.")]
        public string UserName { get; set; }

        //Navigation Properties
        public virtual ICollection<BlogPost> Posts { get; set; }
        public virtual ICollection<BlogPostComment> Comments { get; set; }
        public virtual PasswordHash Password { get; set; }


    }
}