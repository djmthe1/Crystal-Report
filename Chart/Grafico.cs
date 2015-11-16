using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Grafico : Form
    {
        public Grafico()
        {
            InitializeComponent();
        }

        private void Grafico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chartDbDataSet1.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter1.Fill(this.chartDbDataSet1.Agenda);
            // TODO: This line of code loads data into the 'chartDbDataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.chartDbDataSet.Agenda);

        }
    }
}
