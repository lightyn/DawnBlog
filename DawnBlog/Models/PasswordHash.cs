using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DawnBlog.Models
{
    public class PasswordHash
    {
        //Unimplemented Model
        [Key, ForeignKey("User")]
        public int PasswordHash_Id { get; set; }
        public string Salt { get; set; }

        //Navigation Properties
        public virtual User User { get; set; }

        //TODO: Implement .NET Identity package
    }
}