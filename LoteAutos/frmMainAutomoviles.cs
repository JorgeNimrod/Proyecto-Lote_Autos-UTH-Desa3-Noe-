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
    public partial class frmMainAutomoviles : Form
    {
        public static int PKAUTOMOVIL;
        public void cargarPropietarios()
        {
            this.cmbPropietarios.DataSource = ControladorPropietario.getAllPropietarios(true);
            this.cmbPropietarios.DisplayMember = "sNombre";
            this.cmbPropietarios.ValueMember = "pkPropietario";
        }

        public void cargarAutomoviles(int pkPropietario)
        {
            List<automoviles> nLista = new List<automoviles>();
            foreach (var item in ControladorPropietarioAutomovil.LastaAutomoviles(pkPropietario, this.chbStatus.Checked))
            {
                nLista.Add(item.automoviles);
            }
            this.dgvAutomoviles.DataSource = nLista;
        }

        public frmMainAutomoviles()
        {
            InitializeComponent();
            this.dgvAutomoviles.AutoGenerateColumns = false;
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarAutomoviles(Convert.ToInt32(cmbPropietarios.SelectedValue));
        }

        private void frmMainAutomoviles_Load(object sender, EventArgs e)
        {
            this.cargarPropietarios();
            this.cargarAutomoviles(Convert.ToInt32(cmbPropietarios.SelectedValue));
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.cargarAutomoviles(Convert.ToInt32(cmbPropietarios.SelectedValue));
            }
            catch (Exception)
            {
                long pkPropietario = ((propietarios)cmbPropietarios.SelectedValue).pkPropietario;
                this.cargarAutomoviles(Convert.ToInt32(pkPropietario));
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            PKAUTOMOVIL = Convert.ToInt32(this.dgvAutomoviles.CurrentRow.Cells[0].Value);
            frmModificarAutomoviles ma = new LoteAutos.frmModificarAutomoviles(this);
            ma.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAutomoviles.RowCount>=1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    automoviles nAutomovil = new automoviles();
                    nAutomovil.pkAutomovil = frmMainAutomoviles.PKAUTOMOVIL;
                    nAutomovil.sFoto1 = this.dgvAutomoviles.CurrentRow.Cells[1].Value.ToString();
                    nAutomovil.sFoto2 = this.dgvAutomoviles.CurrentRow.Cells[2].Value.ToString();
                    nAutomovil.sFoto3 = this.dgvAutomoviles.CurrentRow.Cells[3].Value.ToString();
                    nAutomovil.sMarca = this.dgvAutomoviles.CurrentRow.Cells[4].Value.ToString();
                    nAutomovil.sModelo = this.dgvAutomoviles.CurrentRow.Cells[5].Value.ToString();
                    nAutomovil.iAño = Convert.ToInt32(this.dgvAutomoviles.CurrentRow.Cells[6].Value.ToString());
                    nAutomovil.sNoSerie = this.dgvAutomoviles.CurrentRow.Cells[7].Value.ToString();
                    nAutomovil.sNoPlaca = this.dgvAutomoviles.CurrentRow.Cells[8].Value.ToString();
                    nAutomovil.sColor = this.dgvAutomoviles.CurrentRow.Cells[9].Value.ToString();
                    nAutomovil.sNacionalidad = this.dgvAutomoviles.CurrentRow.Cells[10].Value.ToString();
                    nAutomovil.dPrecio = Convert.ToDouble(this.dgvAutomoviles.CurrentRow.Cells[11].Value.ToString());
                    nAutomovil.sObservaciones = this.dgvAutomoviles.CurrentRow.Cells[12].Value.ToString();
                    nAutomovil.bStatus = false;
                    ControladorAutomovil cAutomovil = new ControladorAutomovil();
                    cAutomovil.Modificar(nAutomovil);
                    this.cargarAutomoviles(Convert.ToInt32(cmbPropietarios.SelectedValue));
                }
            }
        }
    }
}
