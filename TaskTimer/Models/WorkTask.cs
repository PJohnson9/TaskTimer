using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskTimer.Models
{
    public class WorkTask
    {
        [Key]
        public Int32 TaskID { get; set; }

        [Required]
        //[ScaffoldColumn(false)]
        public Int32 UserID { get; set; }

        [Required]
        [Display(Name = "Task Name")]
        public String Name { get; set; }


        [Required]
        //[Display(Name = "Task Category")]
        public virtual TaskCategory Category { get; set; }

        [ForeignKey("Category")]
        public Int32 CategoryID { get; set; }

        public Boolean Completed { get; set; }


        public virtual ICollection<WorkSession> Sessions { get; set; }
    }
}
