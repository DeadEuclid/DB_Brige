namespace Viewer
{
    public class Wagon
    {
        public Wagon(int seatsCount, WagonClass wagonClass)
        {
            SeatsCount = seatsCount;
            WagonClass = wagonClass;
        }
        public int Id { get; set; }
        public int SeatsCount { get; set; }
        public WagonClass WagonClass { get; set; }
    }

}
