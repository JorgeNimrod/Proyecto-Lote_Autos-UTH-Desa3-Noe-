using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutos.Controlador;
using LoteAutos.Modelo;

namespace LoteAutos
{
    public partial class frmComisionRegistro : Form
    {
        public static Boolean status;
        frmNuevoPropietario wMain;
        public frmComisionRegistro(frmNuevoPropietario wmain)
        {
            InitializeComponent();
            status = false;
            wMain = wmain;
        }

        private void frmComisionRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtPago.Text) >= 200)
                {
                    btnAceptar.Enabled = true;
                }
                else
                {
                    btnAceptar.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            double Pago = Convert.ToDouble(txtPago.Text);
            double Comision = Convert.ToDouble(txtComision.Text);
            double Cambio = Comision - Pago;

            txtCambio.Text = Cambio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            comisionregistros nComisionRegistro = new Modelo.comisionregistros();
            nComisionRegistro.dCobro = Convert.ToInt32(txtComision.Text);
            nComisionRegistro.dPago = Convert.ToInt32(txtPago.Text);
            nComisionRegistro.dCambio = Convert.ToInt32(txtCambio.Text);

            ControladorComisionRegistro cComisionRegistro = new ControladorComisionRegistro();
            cComisionRegistro.Guardar(nComisionRegistro);
            status = true;
            wMain.GuardarDatos();
            this.Close();
        }
    }
}
