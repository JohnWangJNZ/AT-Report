using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class Trip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string RouteID { get; set; }
        public string CalendarID { get; set; }
        public string HeadSign { get; set; }
        public int DirectionID { get; set; }
        public string BlockID { get; set; }
        public string ShapeID { get; set; }
        public string ShortName { get; set; }
        public string Type { get; set; }

        public virtual Route Route { get; set; }
        public virtual Calendar Calendar { get; set; }
    }
}