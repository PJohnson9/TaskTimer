using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTimer.Models
{
    public class WorkSession
    {
        [Key]
        public Int32 SessionID { get; set; }

        [Required]
        public virtual WorkTask Task { get; set; }  // TODO: Is lazy loading supported yet in EF Core?

        [ForeignKey("Task")]
        [Display(Name = "Task")]
        public Int32 TaskID { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Display(Name = "End Time")]
        public DateTime? End { get; set; }

        [NotMapped]
        public TimeSpan TimeSpan {
            get { return (End ?? DateTime.Now) - Start; }  // If End is null use elapsed time since start
            set { this.End = Start.Add(value); }
        }
    }
}
