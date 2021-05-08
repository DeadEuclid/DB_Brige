using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace DB_Brige
{
    public class Ticket
    {
        public Ticket(int id, DateTime departure, PriceMod priceMod, Wagon wagon)
        {
            Id = id;
            Departure = departure;
            PriceMod = priceMod;
            Wagon = wagon;
        }

        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public PriceMod PriceMod { get; set; }
        public Wagon Wagon { get; set; }
    }

}
