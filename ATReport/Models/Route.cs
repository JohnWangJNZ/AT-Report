using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class Route
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ID { get; set; }
        public string AgencyID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Url { get; set; }
        public string Color { get; set; }
        public string TextColor { get; set; }

        public virtual Agency Agency { get; set; }
        public virtual ICollection<Trip> Trip { get; set; }
    }
}