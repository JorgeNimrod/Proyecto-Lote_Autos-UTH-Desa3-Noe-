using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoteAutos
{
    public partial class frmPagar : Form
    {
        public static double PAGO;
        public static double CAMBIO;
        public static Boolean STATUS;
        frmMainVentas wMain;
        public frmPagar(frmMainVentas wmain)
        {
            InitializeComponent();
            wMain = wmain;
            STATUS = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            txtTotal.Text = frmMainVentas.TOTAL.ToString();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtPago.Text) >= Convert.ToDouble(txtTotal.Text))
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
            double Total = Convert.ToDouble(txtTotal.Text);
            double Cambio = Total - Pago;

            txtCambio.Text = Cambio.ToString();
            PAGO = Pago;
            CAMBIO = Cambio;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            wMain.GuardarVenta();
            MessageBox.Show("Venta realizada con exito");
            STATUS = true;
            this.Close();
        }
    }
}
