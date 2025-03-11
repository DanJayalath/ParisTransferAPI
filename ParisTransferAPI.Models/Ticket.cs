using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParisTransferAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public string Messege { get; set; }
        public DateTime ReferenceDateTime { get; set; }
    }
}
