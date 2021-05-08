using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace DB_Brige
{

    public class Ticket
    {
        public Ticket( DateTime departureTime, Station departure, Station destination, Wagon wagon, int palesNum, int passportSeries, int passportNum, string secondName, string firstName, string middleName, Trip trip)
        {


            DepartureTime = departureTime;
            Departure = departure;
            Destination = destination;
            Wagon = wagon;
            PalesNum = palesNum;
            PassportSeries = passportSeries;
            PassportNum = passportNum;
            SecondName = secondName;
            FirstName = firstName;
            MiddleName = middleName;
            Trip = trip;
        }

        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public Station Departure { get; set; }
        public Station Destination { get; set; }
        public Wagon Wagon { get; set; }
        public int PalesNum { get; set; }
        public int PassportSeries { get; set; }
        public int PassportNum { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public ExemType ExemType { get; set; }
        public Trip Trip { get; set; }
    }

}


