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
        [Key]
        public Int32 TaskID { get; set; }


        [Required]
        [Display(Name = "Task Name")]
        public String Name { get; set; }


        [Required]
        //[Display(Name = "Task Category")]
        public TaskCategory Category { get; set; }


        public IEnumerable<WorkSession> Sessions { get; set; }
    }
}
