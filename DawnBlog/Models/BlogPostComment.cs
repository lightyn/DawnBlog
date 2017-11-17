using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DawnBlog.Models
{
    public class BlogPostComment
    {
        //Unimplemented Model
        [Key]
        public int BlogPostComment_Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Comment cannot be blank.")]
        public string CommentBody { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }

        //Navigation Properties
        public virtual BlogPost BlogPost { get; set; }
        public virtual User User { get; set; }


    }
}