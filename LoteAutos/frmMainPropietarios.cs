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
    public partial class frmMainPropietarios : Form
    {
        public static int PKPROPIETARIO;
        public static int ROWS;
        public void CargarPropietarios()
        {
            this.dgvPropietario.DataSource = ControladorPropietario.Buscar(txtBuscar.Text, chbStatus.Checked);
            ROWS = this.dgvPropietario.Rows.Count;
        }

        public void ProcesarPermisos()
        {
            int permisos = 0;
            
            permisos = Convert.ToInt32(btnEliminar.Tag);
            btnEliminar.Enabled = frmMainMenu.SessionActiva.tienepermiso(permisos);
            
        }
        public frmMainPropietarios()
        {
            InitializeComponent();
            this.dgvPropietario.AutoGenerateColumns = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.CargarPropietarios();
        }

        private void frmMainPropietarios_Load(object sender, EventArgs e)
        {
            this.CargarPropietarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoPropietario np = new frmNuevoPropietario(this);
            np.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvPropietario.RowCount>=1)
            {
                PKPROPIETARIO = Convert.ToInt32(this.dgvPropietario.CurrentRow.Cells[0].Value);
                frmModificarPropietarios mp = new LoteAutos.frmModificarPropietarios(this);
                mp.ShowDialog();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPropietario.RowCount>=1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    propietarios nPropietario = new Modelo.propietarios();
                    nPropietario.pkPropietario = Convert.ToInt32(this.dgvPropietario.CurrentRow.Cells[0].Value);
                    nPropietario.sNombre = this.dgvPropietario.CurrentRow.Cells[2].Value.ToString();
                    nPropietario.sApellido = this.dgvPropietario.CurrentRow.Cells[3].Value.ToString();
                    nPropietario.sDireccion = this.dgvPropietario.CurrentRow.Cells[4].Value.ToString();
                    nPropietario.sTelefono = this.dgvPropietario.CurrentRow.Cells[5].Value.ToString();
                    nPropietario.sEmail = this.dgvPropietario.CurrentRow.Cells[6].Value.ToString();
                    nPropietario.sIfe = this.dgvPropietario.CurrentRow.Cells[7].Value.ToString();
                    nPropietario.sFoto = this.dgvPropietario.CurrentRow.Cells[1].Value.ToString();
                    nPropietario.bStatus = false;

                    ControladorPropietario cPropietario = new ControladorPropietario();
                    cPropietario.Modificar(nPropietario);
                    this.CargarPropietarios();
                }
            }
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.CargarPropietarios();
        }

        private void frmMainPropietarios_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }
    }
}
