using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimer.Models
{
    public class Task
    {
        //[Key]
        //public Int32 ContactID { get; set; }


        [Required]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }


        [Required]
        [Display(Name = "E-Mail Address")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail Address")]
        public String EMail { get; set; }
    }
}
