using ATReport.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ATReport.DAL
{
    public class ATDataContext: DbContext
    {
        public ATDataContext() : base("ATDataContext")
        {
        }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Carpark> Carparks { get; set; }
        public DbSet<Coordinate> Coordinates { get; set; }
        public DbSet<CustomerServiceCenter> CustomerServiceCenters { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<ScheduledWork> ScheduledWorks { get; set; }
        public DbSet<ScheduledWorkCoordinate> ScheduledWorkCoordinates { get; set; }
        public DbSet<Stop> Stops { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}