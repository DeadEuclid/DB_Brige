using System;

namespace Viewer
{
    public class TimeTable
    {
        public int Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public string WeekTable { get; set; }
        public Route Route { get; set; }

    }

}
