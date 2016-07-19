using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lecture.Models
{
    public class Event
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage="Name is a required field")]
        public string Name { get; set; }
        public string Presenter { get; set; }

        [Required(ErrorMessage="Event date is a requireed field")]
        public DateTime Date { get; set; }

        public string Location { get; set; }

        [Display(Name = "Cancelled")]
        public bool IsCancelled { get; set; }
    }
}