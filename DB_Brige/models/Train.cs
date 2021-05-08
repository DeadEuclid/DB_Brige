using System.Collections.Generic;

namespace DB_Brige
{
    public class Train
    {
        public Train(List<Wagon> wagons)
        {
            Wagons = wagons;
        }
        public int Id { get; set; }
        public List<Wagon> Wagons { get; set; }
    }

}
