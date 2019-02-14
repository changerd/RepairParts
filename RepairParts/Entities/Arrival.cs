using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    public class Arrival
    {
        public int ArrivalId { get; set; }
        public int ArrivalQuantity { get; set; }
        public decimal ArrivalCost { get; set; }
        public decimal ArrivalSum { get; set; } 
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int  ArrivalDocId { get; set; }
        public ArrivalDoc ArrivalDoc { get; set; }
    }
}
