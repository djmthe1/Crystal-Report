using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chart;

namespace Crystal_Report
{
    public partial class CrystalForm : System.Windows.Forms.Form
    {
        public CrystalForm()
        {
            InitializeComponent();
        }

        private void Presentarbutton_Click(object sender, EventArgs e)
        {
            PresentarForm PF = new PresentarForm();
            AgendaCrystalReport AC = new AgendaCrystalReport();
            PF.PFcrystalReportViewer1.ReportSource = AC;
            PF.ShowDialog();
        }

        private void botonPresentarGrafico_Click(object sender, EventArgs e)
        {
            Grafico Grafico = new Grafico();
            Grafico.Show();
        }
    }
}
 