using app.report.model01.Reportes;
using System;
using System.Windows.Forms;

namespace app.report.model01.View
{
    public partial class frmReporte2 : Form
    {
        public frmReporte2()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            ResumenVentas f = new ResumenVentas();
            crvInforme.ReportSource = f;
        }

        private void crvInforme_Load(object sender, EventArgs e)
        {

        }
    }
}
