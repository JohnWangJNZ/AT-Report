using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class CustomerServiceCenter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Phone { get; set; }
        public string OpenHours { get; set; }
        public Boolean HopServices { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}