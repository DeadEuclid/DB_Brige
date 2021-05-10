using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Brige;

namespace Viewer
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
            this.Viewer = new DataViewer();

            this.panel1.Controls.Add(Viewer);
            Init();
        }

        public void Init()
        {
            var rep = new StationContext();
            //rep.Tickets.Add(new Ticket(DateTime.Now, new Station("Срань 1"), new Station("Срань 3"),
            //    new Wagon(33, WagonClass.First), 3, 53454, 453, "Критинов", "Василий", "Васильевич",
            //    new Trip(new Train(new List<Wagon>()), new TimeTable(), new Route(new List<Station>(), 234))));
            //rep.SaveChanges();
            this.Viewer.ShowData(rep.Tickets.ToList(), typeof(Ticket));
        }

        public DataViewer Viewer { get; set; }
    }
}
