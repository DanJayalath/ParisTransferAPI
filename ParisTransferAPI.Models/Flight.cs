using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTransferAPI.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string ArrivalFlightNo { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public TimeOnly ArrivalTime { get; set; }
        public string ArrivalFrom { get; set; }
        public string ArrivalTo { get; set; }
        public string DepartureFlightNo { get; set; }
        public DateOnly DepartureDate { get; set; }
        public TimeOnly DepartureTime { get; set; }
        public DateTime DeparturePickupTime { get; set; }
        public string DeparturePickupAddress { get; set; }
        public string DepartureDestination { get; set; }

    }
}
