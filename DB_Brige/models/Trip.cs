using System;

namespace Viewer
{
    public class Trip
    {
        public Trip(Train train, TimeTable timeTable, Route route)
        {
            Train = train;
            TimeTable = timeTable;
            //Route = route;
        }
        public int Id { get; set; }
        public Train Train { get; set; }
        public TimeTable TimeTable { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
