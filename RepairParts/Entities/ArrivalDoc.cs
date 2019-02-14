using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    public class ArrivalDoc
    {
        public int ArrivalDocId { get; set; }       
        public string ArrivalDocName { get; set; }       
        public string ArrivalDocProvider { get; set; }        
        public  DateTime ArrivalDocDate { get; set; }
        public virtual ICollection<Arrival> Arrivals { get; set; }
        public ArrivalDoc()
        {
            Arrivals = new List<Arrival>();
        }

    }
}
