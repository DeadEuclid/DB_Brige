using AutoGrid;
using System.Collections.Generic;
using System.ComponentModel;

namespace Viewer
{
    [Title("станций")]
    public class Station
    {
        public Station(string name)
        {
            Name = name;
            Routes = new List<Route>();
        }
        public Station()
        {
            Routes = new List<Route>();
        }
        public int Id { get; set; }
       [Title("Название станции")]
       [System.ComponentModel.DisplayName("Название станции")]
        [AddableBDTitle("Название станции")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }    
        [AddableBDTitle("Маршруты")]
        public List<Route> Routes { get; set; }
    }


}
