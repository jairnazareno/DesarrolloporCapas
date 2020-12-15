using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class Saludos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            CapaLogica.Contabilidad conta = new CapaLogica.Contabilidad();
            this.lblMensaje.Text = conta.Saludos(nombre);

            double x = double.Parse(this.txtSueldo.Text);
            this.lblMensajeSueldo.Text = conta.getSaldos(x).ToString();

            int numes = int.Parse(this.txtMes.Text);
            this.lblMensajeMes.Text = CapaLogica.Utilidades.getNombreDelMes(numes);
        }
    }
}