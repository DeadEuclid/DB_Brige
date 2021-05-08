namespace DB_Brige
{
    public class Wagon
    {
        public Wagon(int seatsCount, WagonClass wagonClass)
        {
            SeatsCount = seatsCount;
            WagonClass = wagonClass;
        }

        public int SeatsCount { get; set; }
        public WagonClass WagonClass { get; set; }
    }

}
