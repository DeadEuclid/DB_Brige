using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Brige
{
    public class StationContext : DbContext
    {
        public StationContext() : base("Server=localhost;Database=TicketsDB;trusted_connection=true;")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>()
                .Configure(property => property.HasColumnType("datetime2"));
            modelBuilder.Properties<decimal>()
                .Configure(property => property.HasPrecision(19, 8));
        }

        public DbSet<Route> Routes { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Train> Trains { get; set; }
        public DbSet<Person> Clients { get; set; }
    }
}
