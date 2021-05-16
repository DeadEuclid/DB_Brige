using System.Collections.Generic;

namespace Viewer
{
    public class Train
    {
      public Train(List<Wagon> wagons)
        {
            Wagons = wagons;
        }
        public Train()
        {
            Wagons = new List<Wagon>();
        }
        public int Id { get; set; }
        public  List<Wagon> Wagons { get; set; }
    }

}
