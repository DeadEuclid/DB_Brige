using AutoGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viewer
{
    public partial class TiketsViewForm : Form
    {
        public TiketsViewForm()
        {
            InitializeComponent();
            viewProcessor = new DataGridProcessor(dataGridView1);
            viewProcessor.ShowData(rep.Tickets.ToList(),typeof( Ticket));

        }
        public StationContext rep = new StationContext();
        private DataGridProcessor viewProcessor;

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
