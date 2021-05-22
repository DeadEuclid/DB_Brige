using AutoGrid;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Viewer
{
    [Title("расписаний")]
    public class TimeTable
    {
        TimeTable()
        { }
        public int Id { get; set; }
        [Title("Время отправления")]
        public DateTime DepartureTime { get; set; }
        [Title("Расписание")]
        public string WeekTable { get; set; }
        [NotMapped]
        [Title("Маршрут")]
        public string RouteTitle => Route.RouteTitle;
        public Route Route { get; set; }

    }

}
