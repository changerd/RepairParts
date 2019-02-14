using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairParts.Entities
{
    public class Part
    {
        [Display(Name = "Номер запчасти")]
        public int PartId { get; set; }
        [Display(Name ="Наименование")]
        public string PartName { get; set; }
        [Display(Name = "Еденица измерения")]
        public string PartUnit { get; set; }
        public virtual ICollection<Arrival> Arrivals { get; set; }
        public virtual ICollection<Departure> Departures { get; set; }
        public Part()
        {
            Arrivals = new List<Arrival>();
            Departures = new List<Departure>();
        }
    }
}
