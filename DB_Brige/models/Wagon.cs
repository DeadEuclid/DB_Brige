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
            Number = number;
        }
        public Wagon()
        { }
        public int Id { get; set; }
        [Title("№ Вагона")]
        [AddableBDTitle("№ Вагона")]
        public int Number { get; set; }
        [Title("Кол-во мест")]
        [AddableBDTitle("Кол-во мест")]
        public int SeatsCount { get; set; }
        [AddableBDTitle("Класс")]
        public WagonClass WagonClass { get; set; }
        [NotMapped]
        [Title("Класс вагона")]
        public string Class => WagonClass.GetTitleValue();
    }

}
