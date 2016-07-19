using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture.Models
{
    public class CreateStaffViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        public virtual String FirstName { get; set; }
        [Required]
        public virtual String LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime? DOB { get; set; }

        public enum Gender { Male, Female }
        [Required]
        public virtual String TelNumber { get; set; }
        [Required]
        public virtual String Email { get; set; }
        [Required]
        public virtual String Address_Line1 { get; set; }
        public virtual String Address_Line2 { get; set; }
        [Required]
        public virtual String City { get; set; }
        [StringLength(8, ErrorMessage = "Postcode")]
        public virtual String Postcode { get; set; }
        [Required]
        public virtual String Position { get; set; }

        [Required]
        public virtual String Location_Work { get; set; }


      





    }
}