using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using AutoGrid;

namespace Viewer
{
    [Title("маршрутов")]
    public class Route
    {
        public Route(List<Station> stations, int price)
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
        [System.ComponentModel.DisplayName("Маршрут")]
        public string Name => Stations.Count >= 2 ? $"{Stations.First().Name} - {Stations.Last().Name}" : "---";
        
        [Title("Цена без надбавок")]
        [AddableBDTitle("Цена без надбавок")]
        [System.ComponentModel.DisplayName("Цена без надбавок")]

        public int Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

}
