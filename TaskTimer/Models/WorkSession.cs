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
        public Task Task { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Display(Name = "End Time")]
        public DateTime End { get; set; }

        public TimeSpan TimeSpan {
            get { return End - Start; }
            set { this.End = Start.Add(value); }
        }
    }
}
