using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTransferAPI.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }    
        public string Category { get; set; }
        public string VehicleModel { get; set; }
        public byte[] VehiclePicture { get; set; }

    }
}
