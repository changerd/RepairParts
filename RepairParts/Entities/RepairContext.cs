using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    class RepairContext: DbContext
    {
        public RepairContext() : base ("RepairContext")
        {
        }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Arrival> Arrivals { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<ArrivalDoc> ArrivalDocs { get; set; }
        public DbSet<DepartureDoc> DepartureDocs { get; set; }        
    }
}
