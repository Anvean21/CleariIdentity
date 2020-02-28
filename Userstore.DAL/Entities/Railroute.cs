using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.DAL.Entities
{
   public class Railroute
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<RailrouteStation> RailrouteStations { get; set; } = new List<RailrouteStation>();
    }
}
