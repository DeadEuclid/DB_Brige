using System;

namespace Viewer
{
    public class Trip
    {
        public Trip(Train train, TimeTable timeTable)
        {
            Train = train;
            TimeTable = timeTable;

        }
        public int Id { get; set; }
        public Train Train { get; set; }
        public TimeTable TimeTable { get; set; }
        public DateTime DepartureDate { get; set; }
    }
}
