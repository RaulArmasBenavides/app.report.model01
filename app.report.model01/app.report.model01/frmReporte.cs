using app.report.model01.Reportes;
using System;
using System.Windows.Forms;

namespace app.report.model01.View
{
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            ListaPrecios f = new ListaPrecios();
            crvInforme.ReportSource = f;
        }

        private void crvInforme_Load(object sender, EventArgs e)
        {

        }
    }
}
