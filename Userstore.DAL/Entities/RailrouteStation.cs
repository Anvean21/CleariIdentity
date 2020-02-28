using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.DAL.Entities
{
  public  class RailrouteStation
    {
        [Key]
        public int Id { get; set; }
        public int Order { get; set; }
        public int IdRailroute { get; set; }
        public Railroute Railroute { get; set; }
        public int IdStation { get; set; }
        public Station Station { get; set; }

    }
}
