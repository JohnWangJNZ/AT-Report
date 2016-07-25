using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class ScheduledWorkCoordinate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public int ScheduledWorkID { get; set; }
        public int CoordinateID { get; set; }

        public virtual ScheduledWork ScheduledWork { get; set; }
        public virtual Coordinate Coordinate { get; set; }
    }
}