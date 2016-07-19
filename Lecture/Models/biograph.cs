using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture.Models
{
    public class biograph
    {
        [Key]
        public virtual int ID { get; set; }
        [Required]
        public String Title { get; set; }

        [Required]
        public String Biography_Context { get; set; }


    }
}