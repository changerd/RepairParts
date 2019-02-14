using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    public class DepartureDoc
    {
        public int DepartureDocId { get; set; }        
        public string DepartureDocName { get; set; }        
        public string DepartureDocSender { get; set; }        
        public string DepartureDocRecipient { get; set; }       
        public DateTime DepartureDocDate { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }
        public DepartureDoc()
        {
            Departures = new List<Departure>();
        }
    }
}
