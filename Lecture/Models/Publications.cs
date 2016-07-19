using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lecture.Models
{
    public class Publications
    {

        [Key]
        public int PublicationID { get; set; }
        [Required(ErrorMessage= "Please Enter the Date")]
        public DateTime? Published_Date { get; set; }
        [StringLength(200)]
        [Required(ErrorMessage="Please enter the Url Publications")]
        public String URL_Publications { get; set; }

        public String Publication_keyword { get; set; }

        public String Descriptions { get; set; }

        public ImageFile Image { get; set; }
    


    }
}