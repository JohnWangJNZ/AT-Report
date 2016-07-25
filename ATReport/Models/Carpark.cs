using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class Carpark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int MobilitySpace { get; set; }
        public string Type { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}