using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoGrid;
using System.Reflection;
using Viewer.ControlsInput;

namespace Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        StationContext Context=new StationContext();

        TableForm TableForm=new TableForm();

        private void InitTableForm<T>(List<T> set) where T:class
        {


            this.Hide();

          TableForm.Init<T>(set).ShowDialog();
            this.Show();
        }

        
        private void stationButon_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Stations.ToList());
        }

        private void timeTableButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.TimeTables.ToList());

        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Routes.ToList());

        }

        private void tripButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Trips.ToList());

        }

        private void personButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Persons.ToList());

        }

        private void tiketButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Tickets.ToList());

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Trains.ToList());

        }

        private void WagonButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Wagons.ToList());

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
