namespace DB_Brige
{
    public class Trip
    {
        public Trip(Train train, TimeTable timeTable)
        {
            Train = train;
            TimeTable = timeTable;
        }

        public Train Train{get;set;}
        public TimeTable TimeTable { get; set; }
    }

}
