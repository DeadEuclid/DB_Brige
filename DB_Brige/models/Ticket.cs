using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Viewer
{

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
        public int Id { get; set; }

        [Title("Время отбытия")]
        public DateTime DepartureTime { get; set; }

        [Title("Станция отбытия")]
        public Station Departure { get; set; }

        [Title("Станция прибытия")]
        public Station Destination { get; set; }

        [NotMapped]
        [Title("Вагон")]
        public string WagonInfo => $"№{Wagon?.Id} ";
        public Wagon Wagon { get; set; }

        [Title("Номер места")]
        public int PalesNum { get; set; }

        [Title("Серия паспорта")]
        public int PassportSeries { get; set; }

        [Title("Номер паспорта")]
        public int PassportNum { get; set; }

        [Title("Фамилия")]
        public string LastName { get; set; }

        [Title("Имя")]
        public string FirstName { get; set; }

        [Title("Отчество")]
        public string MiddleName { get; set; }

        [Title("Тип льготы")]
        public ExemType ExemType { get; set; }

        [NotMapped]
        [Title("Номер поезда")]
        public string TrainId => (Trip?.Train?.Id).ToString();

        [NotMapped]
        [Title("Маршрут")]
        public string Route => Trip?.TimeTable?.Route?.RouteTitle;

        [Title("Цена")]
        public double Price { get; set; }

        public Trip Trip { get; set; }
    }

}


