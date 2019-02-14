using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    public class Departure
    {
        public int DepartureId { get; set; }
        public int DepartureQuantity { get; set; }
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int DepartureDocId { get; set; }
        public DepartureDoc DepartureDoc { get; set; }
    }
}
