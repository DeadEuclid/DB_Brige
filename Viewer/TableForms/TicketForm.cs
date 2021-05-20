using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AutoGrid;


namespace Viewer
{
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
            this.Viewer = new DataViewer();

            this.panel1.Controls.Add((Control)Viewer);
            Init();
        }

        public void Init()
        {
            var Tickets = new List<Ticket>();
            var rep = new StationContext();
            //Tickets.Add(new Ticket(DateTime.Now, new Station("Срань 1"), new Station("Срань 3"),
            //    new Wagon(33, WagonClass.First), 3, 53454, 453, "Критинов", "Василий", "Васильевич",
            //    new Trip(new Train(new List<Wagon>()), new TimeTable(), new Route(new List<Station>(), 234))));

            var ticket = Tickets.FirstOrDefault(n => n.FirstName == "Критинов");



            var tiket = rep.Tickets.FirstOrDefault<Ticket>(t => t.FirstName == "Критинов");



            rep.SaveChanges();
            this.Viewer.ShowData(rep.Tickets.ToList(), typeof(Ticket));
        }

        public DataViewer Viewer { get; set; }
    }
}
