using AutoGrid;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Viewer
{
    [Title("вагонов")]
    public class Wagon
    {
        public Wagon(int seatsCount, WagonClass wagonClass,int number)
        {
            SeatsCount = seatsCount;
           // Class = wagonClass;
            Number = number;
        }
        public Wagon()
        { }
        public int Id { get; set; }
        [Title("№ Вагона")]
        public int Number { get; set; }
        [Title("Кол-во мест")]
        public int SeatsCount { get; set; }
        public WagonClass WagonClass { get; set; }
        //[NotMapped]
        //[Title("Класс вагона")]

    }

}
