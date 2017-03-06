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
    public partial class frmMainVentas : Form
    {
        public static double TOTAL;
        public void GuardarVenta()
        {
            ventas nventas = new ventas();
            nventas.fkAutomovil = Convert.ToInt32(this.dgvdetalleautomoviles.CurrentRow.Cells[0].Value);
            nventas.dPrecio = Convert.ToDouble(this.dgvdetalleautomoviles.CurrentRow.Cells[6].Value);
            ContoladorVentas cventas = new ContoladorVentas();
            cventas.Guardar(nventas);

            compradores ncompradores = new Modelo.compradores();
            ncompradores.sNombre = this.txtNombre.Text;
            ncompradores.sApellido = this.txtApellidos.Text;
            ncompradores.sDireccion = this.txtDireccion.Text;
            ControladorComprador ccomprador = new Controlador.ControladorComprador();
            ccomprador.Guardar(ncompradores);

            detalleventas ndetalleventas = new Modelo.detalleventas();
            ndetalleventas.fkComprador = ncompradores.pkComprador;
            ndetalleventas.sNombre = ncompradores.sNombre;
            ndetalleventas.sApellido = ncompradores.sApellido;
            ndetalleventas.dtFechaVenta = DateTime.Today;
            ndetalleventas.dTotal = Convert.ToDouble(this.txtTotal.Text);
            ndetalleventas.dPago = frmPagar.PAGO;
            ndetalleventas.dCambio = frmPagar.CAMBIO;
            ndetalleventas.fkVenta = nventas.pkVenta;
            ControladorDetalleVentas cdetalleventas = new ControladorDetalleVentas();
            cdetalleventas.Guardar(ndetalleventas);

            automoviles nautomovil = new automoviles();
            nautomovil.pkAutomovil = Convert.ToInt32(this.dgvdetalleautomoviles.CurrentRow.Cells[0].Value);
            nautomovil.sNoSerie = this.dgvdetalleautomoviles.CurrentRow.Cells[1].Value.ToString();
            nautomovil.sMarca = this.dgvdetalleautomoviles.CurrentRow.Cells[2].Value.ToString();
            nautomovil.sModelo = this.dgvdetalleautomoviles.CurrentRow.Cells[3].Value.ToString();
            nautomovil.sNoPlaca = this.dgvdetalleautomoviles.CurrentRow.Cells[4].Value.ToString();
            nautomovil.sNacionalidad = this.dgvdetalleautomoviles.CurrentRow.Cells[5].Value.ToString();
            nautomovil.dPrecio = Convert.ToDouble(this.dgvdetalleautomoviles.CurrentRow.Cells[6].Value);
            //nautomovil.sFoto1 = this.dgvdetalleautomoviles.CurrentRow.Cells[7].Value.ToString();
            //nautomovil.sFoto2 = this.dgvdetalleautomoviles.CurrentRow.Cells[8].Value.ToString();
            //nautomovil.sFoto3 = this.dgvdetalleautomoviles.CurrentRow.Cells[9].Value.ToString();
            nautomovil.sColor = this.dgvdetalleautomoviles.CurrentRow.Cells[10].Value.ToString();
            nautomovil.iAño = Convert.ToInt32(this.dgvdetalleautomoviles.CurrentRow.Cells[11].Value);
            //nautomovil.sObservaciones = this.dgvdetalleautomoviles.CurrentRow.Cells[12].Value.ToString();
            nautomovil.bStatus = false;
            ControladorAutomovil catomovil = new ControladorAutomovil();
            catomovil.Modificar(nautomovil);
        }

        public void cargarDetalleAutomoviles(int pkAutomovil)
        {
            automoviles nautomovil = ControladorAutomovil.getautomovilById(pkAutomovil);
            DataGridViewRow nRen = (DataGridViewRow)this.dgvdetalleautomoviles.Rows[0].Clone();
            nRen.Cells[0].Value = nautomovil.pkAutomovil;
            nRen.Cells[1].Value = nautomovil.sNoSerie;
            nRen.Cells[2].Value = nautomovil.sMarca;
            nRen.Cells[3].Value = nautomovil.sModelo;
            nRen.Cells[4].Value = nautomovil.sNoPlaca;
            nRen.Cells[5].Value = nautomovil.sNacionalidad;
            nRen.Cells[6].Value = nautomovil.dPrecio;
            nRen.Cells[7].Value = nautomovil.sFoto1;
            nRen.Cells[8].Value = nautomovil.sFoto2;
            nRen.Cells[9].Value = nautomovil.sFoto3;
            nRen.Cells[10].Value = nautomovil.sColor;
            nRen.Cells[11].Value = nautomovil.iAño;
            nRen.Cells[12].Value = nautomovil.sObservaciones;

            this.dgvdetalleautomoviles.Rows.Add(nRen);
        }

        public void CalcularTotales()
        {
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            foreach (DataGridViewRow ritem in this.dgvdetalleautomoviles.Rows)
            {
                double tem = Convert.ToDouble(ritem.Cells[6].Value);
                subtotal += tem;
            }
            iva = subtotal * 0.16;
            total = subtotal + iva;

            this.txtSubTotal.Text = subtotal.ToString();
            this.txtIVA.Text = iva.ToString();
            TOTAL = total;
            this.txtTotal.Text = total.ToString();
        }
        public frmMainVentas()
        {
            InitializeComponent();
            this.dgvdetalleautomoviles.AutoGenerateColumns = false;
        }

        private void frmMainVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarAutomovil ba = new frmBuscarAutomovil(this);
            ba.ShowDialog();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text=="")
            {
                this.ErrorProvider.SetIconAlignment(this.txtNombre, ErrorIconAlignment.MiddleLeft);
                this.ErrorProvider.SetError(this.txtNombre, "Campo necesario");
                this.txtNombre.Focus();
            }
            else if (this.txtApellidos.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtApellidos, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtApellidos, "Campo necesario");
                this.txtApellidos.Focus();
            }
            else if (this.txtDireccion.Text=="")
            {
                this.ErrorProvider.SetIconAlignment(this.txtDireccion, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtDireccion, "Campo necesario");
                this.txtDireccion.Focus();
            }
            else if(this.dgvdetalleautomoviles.Rows.Count < 2)
            {
                this.ErrorProvider.SetIconAlignment(this.dgvdetalleautomoviles, ErrorIconAlignment.BottomRight);
                this.ErrorProvider.SetError(this.dgvdetalleautomoviles, "Tiene que haber al menos un auto en la lista");
            }
            else
            {
                frmPagar p = new frmPagar(this);
                p.ShowDialog();
            }
        }

        private void frmMainVentas_Activated(object sender, EventArgs e)
        {
            this.CalcularTotales();
            if (frmPagar.STATUS == true)
            {
                txtNombre.Clear();
                txtApellidos.Clear();
                txtDireccion.Clear();
                this.dgvdetalleautomoviles.Rows.Clear();
            }
        }

        private void dgvdetalleAutomoviles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvdetalleautomoviles.Rows.Count>1)
            {
                this.dgvdetalleautomoviles.Rows.RemoveAt(this.dgvdetalleautomoviles.CurrentRow.Index);
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.ErrorProvider.Clear();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            this.ErrorProvider.Clear();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            this.ErrorProvider.Clear();
        }
    }
}
