using AutoGrid;
using System;
using System.ComponentModel;
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
        [AddableBDTitle("Поезд")]
        public Train Train { get; set; }
        [NotMapped]
        [Title("№ поезда")]
        [System.ComponentModel.DisplayName("№ поезда")]
        public int TrainNum => Train.Number;
        [AddableBDTitle("Расписание")]
        public TimeTable TimeTable { get; set; }
        
        [AddableBDTitle("Дата отправления")]
        [Title("Дата отправления")]
        [System.ComponentModel.DisplayName("Дата отправления")]
        [NotMapped]
        public DateTime DepartureDate { get; set; }

        [NotMapped]
        [Title("Время отправления")]
        [System.ComponentModel.DisplayName("Время отправления")]
        private DateTime DepartureTime => TimeTable.DepartureTime;
        [NotMapped]
        [Title("Маршрут")]
        [System.ComponentModel.DisplayName("Маршрут")]
        private string RouteTitle => TimeTable.RouteTitle;
    }
}
