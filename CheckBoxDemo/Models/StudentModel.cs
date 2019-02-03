using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CheckBoxDemo.Models
{
    public class StudentModel
    {
        
        public int StudentId { get; set; }

        [Display(Name = "Full Name:")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }

        [Display(Name = "Hob Moor Nusery")]
        public bool HobMoorNusery { get; set; }

        [Display(Name = "Green Lane Nusery")]
        public bool GreenLaneNusery { get; set; }

        [Display(Name = "Nuneaton Nusery")]
        public bool NuneatonNusery { get; set; }

    }
}