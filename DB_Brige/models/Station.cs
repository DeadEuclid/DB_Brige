using System.Collections.Generic;

namespace Viewer
{
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
        public string Name { get; set; }
        public List<Route> Routes { get; set; }
    }


}
