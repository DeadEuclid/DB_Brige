using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Brige
{
    class Context : DbContext
    {
        public Context() : base("Server=localhost;Database=TicketsDB;trusted_connection=true;")
        {

        }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Train> Trains { get; set; }
    }
}
