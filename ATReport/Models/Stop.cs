using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class Stop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string ZoneID { get; set; }
        public string Url { get; set; }
        public int Code { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }
        public int LocationType { get; set; }
        public int ParentSation { get; set; }
        public string TimeZone { get; set; }
        public string WheelChairBoarding { get; set; }
        public string Direction { get; set; }
        public string Position { get; set; }
        public string GeometryCode { get; set; }
    }
}