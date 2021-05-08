using System.Collections.Generic;

namespace DB_Brige
{
    public class Route
    {
        public Route(Station startStation, Station finishStation, List<Station> middleStations, double price)
        {
            StartStation = startStation;
            FinishStation = finishStation;
            MiddleStations = middleStations;
            Price = price;
        }

       public Station StartStation { get; set; }
       public Station FinishStation { get; set; }
       public List<Station> MiddleStations { get; set; }
        public double Price { get; set; }
    }

}
