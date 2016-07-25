using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATReport.Models
{
    public class ScheduledWork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public string Region { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ContractorCompany { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string GeometryType { get; set; }
        public Boolean GeometryEncoded { get; set; }

        public virtual ICollection<ScheduledWorkCoordinate> ScheduledWorkCoordinate { get; set; }
    }
}