using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTransferAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string BookingNo { get; set; }
        public int TripTypeId { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }
        public int FlightDetalId { get; set; }
        public int VehicleId { get; set; }
        public int DriverId { get; set; }
        public int ClientId { get; set; }
        public int Passengers { get; set; }
        public int children { get; set; }
        public int baggage { get; set; }
        public int ChilderenSeat { get; set; }
        public int price { get; set; }
        public string Review { get; set; }
        public string description { get; set; }
        public DateTime ReferenceDateTime { get; set; }
        public string Status {  get; set; }


    }
}
