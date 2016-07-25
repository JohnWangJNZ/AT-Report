using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class Agency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string TimeZone { get; set; }
        public string Language { get; set; }
        public string Phone { get; set; }
        public string FareUrl { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}