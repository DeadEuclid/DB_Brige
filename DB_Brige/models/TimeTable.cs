using AutoGrid;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Viewer
{
    [Title("расписаний")]
    public class TimeTable
    {
        TimeTable()
        { }
        public int Id { get; set; }
        [Title("Время отправления")]
        [System.ComponentModel.DisplayName("Время отправления")]
        [AddableBDTitle("Время отправления")]
        public DateTime DepartureTime { get; set; }
        [Title("Расписание")]
        [System.ComponentModel.DisplayName("Расписание")]
        [AddableBDTitle("Расписание")]
        public string WeekTable { get; set; }
        [NotMapped]
        [Title("Маршрут")]
        [System.ComponentModel.DisplayName("Маршрут")]
        public string RouteTitle => Route.Name;
        [AddableBDTitle("Маршрут")]
        public Route Route { get; set; }
        private bool[] NormalWeekTable()
        {
            var result = new bool[9];
            result.Select(r => r = false);
            if (WeekTable == "По чётным дням")
            {
                result[8] = true;
                return result;
            }
            else if (WeekTable == "По нечётным дням")
            {
                result[7] = true;
                return result;
            }
            else
            {
                string[] strWeekArr = WeekTable.Split(' ');
                if (strWeekArr.Contains("Пн."))
                {
                    result[0] = true;
                }
                if (strWeekArr.Contains("Вт."))
                {
                    result[1] = true;
                }
                if (strWeekArr.Contains("Ср."))
                {
                    result[2] = true;
                }
                if (strWeekArr.Contains("Чт."))
                {
                    result[3] = true;
                }
                if (strWeekArr.Contains("Пт."))
                {
                    result[4] = true;
                }
                if (strWeekArr.Contains("Сб."))
                {
                    result[5] = true;
                }
                if (strWeekArr.Contains("Вс."))
                {
                    result[6] = true;
                }
            }
            return result;
        }
        public bool isGoDay(object dataTime)
        {
            if (dataTime is DateTime)
            {
                DateTime dt = (DateTime)dataTime;
                bool[] wTable = NormalWeekTable();
                if (wTable[8])
                {
                    return dt.Day % 2 == 0 ? true : false;
                }
                if (wTable[7])
                {
                    return dt.Day % 2 != 0 ? true : false;
                }
                int dw = (int)dt.DayOfWeek;
                for (int i = 1; i < 7; i++)
                {
                    var convert = wTable[i - 1] ? i : -1;
                    if (convert == dw)
                        return true;
                }
                if (wTable[6])
                    return dw == 0 ? true : false;
                return false;

            }
            else return false;
        }
    }

}
