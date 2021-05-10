using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace DB_Brige
{
    public class Route
    {
        public Route(List<Station> stations, double price)
        {

            Stations = stations;
            Price = price;
        }

        [Title("№")]
        public int Id { get; set; }
        public List<Station> Stations { get; set; }
        
        [NotMapped]
        [Title("Маршрут")]
        public string TripTitle => Stations.Count > 2 ? $"{Stations.First().Name} ---> {Stations.Last().Name}" : "Поезд в небытие";
        
        [Title("Цена без надбавок")]
        public double Price { get; set; }
    }

}
