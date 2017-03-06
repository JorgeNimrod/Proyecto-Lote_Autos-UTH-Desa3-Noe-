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
    public partial class frmBuscarAutomovil : Form
    {
        public void cargarAutos()
        {
            this.dgvAutomoviles.DataSource = ControladorAutomovil.Buscar(txtBuscar.Text, true);
        }
        frmMainVentas wMain;
        public frmBuscarAutomovil(frmMainVentas wmain)
        {
            InitializeComponent();
            this.dgvAutomoviles.AutoGenerateColumns = false;
            wMain = wmain;
        }

        private void dgvAutomoviles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int pkAutomovil = Convert.ToInt32(this.dgvAutomoviles.CurrentRow.Cells[0].Value);
            wMain.cargarDetalleAutomoviles(pkAutomovil);
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarAutos();
        }

        private void frmBuscarAutomovil_Load(object sender, EventArgs e)
        {
            this.cargarAutos();
        }
    }
}
