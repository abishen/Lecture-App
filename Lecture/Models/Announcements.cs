using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lecture.Models
{
    public class Announcements
    {
        [Key]
        public int Id { get; set; }
        public String Title { get; set; }


        public String  Bodymessage { get; set; }


        [DataType(DataType.Date)]

        public DateTime? DateReleased { get; set; }


    }
}