using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoGrid;

namespace Viewer
{
    [Title("маршрутов")]
    public class Route
    {
        public Route(List<Station> stations, double price)
        {

            Stations = stations;
            Price = price;
        }
        public Route()
        {
            Stations = new List<Station>();
        }
         
        

        public int Id { get; set; }
        [AddableBDTitle("Станции")]
        public List<Station> Stations { get; set; }
        
        [NotMapped]
        [Title("Маршрут")]
        public string RouteTitle => Stations.Count >= 2 ? $"{Stations.First().Name} - {Stations.Last().Name}" : "---";
        
        [Title("Цена без надбавок")]
        [AddableBDTitle("Цена без надбавок")]
        public double Price { get; set; }
    }

}
