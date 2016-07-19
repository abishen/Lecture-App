using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecture.Models
{
    public class Staff
    {

        [Key]

        public virtual int StaffID { get; set; }
        [Required]
        public virtual String FirstName { get; set; }
        [Required]
        public virtual String LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public virtual DateTime? DOB { get; set; }
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
        [Required(ErrorMessage="Please Enter the Position")]
        public virtual String Position { get; set; }

        [Required]
        public virtual String Location_Work { get; set; }

     
        public virtual ICollection<biograph> Bio { get; set; }


        public ICollection<Publications> Publications { get; set; }
    }
}