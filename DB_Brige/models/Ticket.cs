using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace DB_Brige
{

    public class Ticket
    {
        public Ticket(int id, TimeTable timetable, DateTime departureTime, Station departure, Station destination, PriceMod priceMod, Wagon wagon, int plaseNum, int pasportSeria, int pasportNum, string secondName, string firstName, string middleName)
        {
            Id = id;
            Timetable = timetable;
            DepartureTime = departureTime;
            Departure = departure;
            Destination = destination;
            PriceMod = priceMod;
            Wagon = wagon;
            PlaseNum = plaseNum;
            PasportSeria = pasportSeria;
            PasportNum = pasportNum;
            SecondName = secondName;
            FirstName = firstName;
            MiddleName = middleName;
        }

        public int Id { get; set; }
        public TimeTable Timetable { get; set; }
        public DateTime DepartureTime { get; set; }
        public Station Departure { get; set; }
        public Station Destination { get; set; }
        public PriceMod PriceMod { get; set; }
        public Wagon Wagon { get; set; }
        public int PlaseNum { get; set; }
        public int PasportSeria { get; set; }
        public int PasportNum { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public ExemType ExemType { get; set; }
    }

}


