using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Viewer
{
    using AutoGrid;
    using System.ComponentModel;

    [Title("билетов")]

    public class Ticket
    {
        public Ticket(DateTime departureTime, Station departure, Station destination, Wagon wagon, int palesNum, int passportSeries, int passportNum, string lastName, string firstName, string middleName, Trip trip)
        {


            DepartureTime = departureTime;
            Departure = departure;
            Destination = destination;
            Wagon = wagon;
            PalesNum = palesNum;
            PassportSeries = passportSeries;
            PassportNum = passportNum;
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            Trip = trip;
        }
        public Ticket() { }
        [Title("Id")]
        [System.ComponentModel.DisplayName("Id")]
        public int Id { get; set; }

        [Title("Время отбытия")]
        [System.ComponentModel.DisplayName("Время отбытия")]
        public DateTime DepartureTime { get; set; }

        [Title("Станция отбытия")]
        [System.ComponentModel.DisplayName("Станция отбытия")]
        public Station Departure { get; set; }

        [Title("Станция прибытия")]
        [System.ComponentModel.DisplayName("Станция прибытия")]
        public Station Destination { get; set; }

        [NotMapped]
        [Title("Вагон")]
        [System.ComponentModel.DisplayName("Вагон")]
        public string WagonInfo => $"№{Wagon?.Number} ";
        public Wagon Wagon { get; set; }

        [Title("Номер места")]
        [System.ComponentModel.DisplayName("Номер места")]
        public int PalesNum { get; set; }

        [Title("Серия паспорта")]
        [System.ComponentModel.DisplayName("Серия паспорта")]
        public int PassportSeries { get; set; }

        [Title("Номер паспорта")]
        [System.ComponentModel.DisplayName("Номер паспорта")]
        public int PassportNum { get; set; }

        [Title("Фамилия")]
        [System.ComponentModel.DisplayName("Фамилия")]
        public string LastName { get; set; }

        [Title("Имя")]
        [System.ComponentModel.DisplayName("Имя")]
        public string FirstName { get; set; }

        [Title("Отчество")]
        [System.ComponentModel.DisplayName("Отчество")]
        public string MiddleName { get; set; }

        [Title("Тип льготы")]
        [System.ComponentModel.DisplayName("Тип льготы")]
        public ExemType ExemType { get; set; }

        [NotMapped]
        [Title("Номер поезда")]
        [System.ComponentModel.DisplayName("Номер поезда")]
        public string TrainId => (Trip?.Train?.Id).ToString();

        [NotMapped]
        [Title("Маршрут")]
        [System.ComponentModel.DisplayName("Маршрут")]
        public string Route => Trip?.TimeTable?.Route?.Name;

        [Title("Цена")]
        [System.ComponentModel.DisplayName("Цена")]
        public int Price { get; set; }

        public Trip Trip { get; set; }
    }

}


