using System.Collections.Generic;

namespace DB_Brige
{
    public class Route
    {
        public Route( List<Station> stations, double price)
        {

            Stations = stations;
            Price = price;
        }

        public int Id { get; set; }
        public List<Station> Stations { get; set; }
        public double Price { get; set; }
    }

}
