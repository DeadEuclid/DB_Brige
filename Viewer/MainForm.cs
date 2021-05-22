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
            var exem = ExemType.Student;
            var test = exem.GetTitleValue();
            InitializeComponent();
        }
        StationContext Context = new StationContext();
        TableForm TableForm;

        private void InitTableForm(DbSet set)
        {
            TableForm = new TableForm(set);
            this.Hide();
            TableForm.ShowDialog();
            this.Show();
        }

        }
        private void stationButon_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Stations);
        }

        private void timeTableButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.TimeTables);
        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Routes);
        }

        private void tripButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Trips);
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Persons);
        }

        private void tiketButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Tickets);
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Trains);
        }

        private void WagonButton_Click(object sender, EventArgs e)
        {
            InitTableForm(Context.Wagons);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
