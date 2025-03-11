using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTransferAPI.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int FromLocationId { get; set; }

        public int ToLocationId { get; set; }

        public Route() { }

    }
}
