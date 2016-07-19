using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Models
{
    public class PublicationModel
    {

        [Required(ErrorMessage = "Please Enter the Date")]
        [DataType(DataType.Date)]
        public DateTime? Published_Date { get; set; }
       [Required(ErrorMessage = "Please Enter the Keyword of Research")]
        public String Publication_keyword { get; set; }

        [Required(ErrorMessage = "Please Enter the Date")]

        public String Descriptions { get; set; }

        public ImageFile Image { get; set; }




    }
}