using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimer.Models
{
    public class TaskCategory
    {
        public TaskCategory() { }
        public TaskCategory(String category) { Category = category; }

        [Key]
        public Int32 TaskCategoryID { get; set; }

        [Required]
        [Display(Name = "Task Category")]
        public String Category { get; set; }

    }
}
