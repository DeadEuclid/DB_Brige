using AutoGrid;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Viewer
{
    [Title("поездов")]
    public class Train
    {
        public Train(List<Wagon> wagons, int number)
        {
            Wagons = wagons;
            Number = number;
        }
        public Train()
        {
            Wagons = new List<Wagon>();
        }
        public int Id { get; set; }
        [Title("№ Поезда")]
        public int Number { get; set; }
        [NotMapped]
        [Title("Кол-во мест")]
        public int SeatsCount => Wagons.Select(w => w.SeatsCount).Sum();
        [NotMapped]
        public int SeatsCountFirstClass => Wagons.Where(w=>w.WagonClass==WagonClass.First).Select(w => w.SeatsCount).Sum();
        [NotMapped]
        public int SeatsCountSecondClass => Wagons.Where(w => w.WagonClass == WagonClass.Second).Select(w => w.SeatsCount).Sum();


        public List<Wagon> Wagons { get; set; }
    }

}
