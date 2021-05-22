using AutoGrid;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Viewer
{
    [Title("рейсов")]
    public class Trip
    {
        public Trip(Train train, TimeTable timeTable)
        {
            Train = train;
            TimeTable = timeTable;

        }
        public Trip()
        {

        }
        public int Id { get; set; }
        public Train Train { get; set; }
        [NotMapped]
        [Title("№ поезда")]
        public int TrainNum => Train.Number;
        public TimeTable TimeTable { get; set; }
        [Title("Дата отправления")]
        public DateTime DepartureDate { get; set; }

        [NotMapped]
        [Title("Время отправления")]
        private DateTime DepartureTime => TimeTable.DepartureTime;
        [NotMapped]
        [Title("Маршрут")]
        private string RouteTitle => TimeTable.RouteTitle;
    }
}
