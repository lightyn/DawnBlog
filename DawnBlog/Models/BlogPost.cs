using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DawnBlog.Models
{
    public class BlogPost
    {
        [Key]
        public int BlogPost_Id { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Post cannot be blank.")]
        public string Body { get; set; }

        [Required(AllowEmptyStrings = false,  ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        public DateTime DateTime { get; private set; }

        //Navigation Properties
        public virtual User User { get; set; }
        public virtual ICollection<BlogPostComment> Comments {get; set;}

        //Default constructor sets DateTime property to "Now"
        public BlogPost()
        {
            this.DateTime = DateTime.Now;
        }

    }
}