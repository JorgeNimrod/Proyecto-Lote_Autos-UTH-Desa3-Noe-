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
    public partial class frmMainRoles : Form
    {
        public static int PKROLES;
        public void cargarRoles()
        {
            this.dgvRoles.DataSource = ControladorRol.Buscar(txtBuscar.Text, chbStatus.Checked);
        }
        public frmMainRoles()
        {
            InitializeComponent();
            this.dgvRoles.AutoGenerateColumns = false;
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            frmNuevoRol nr = new LoteAutos.frmNuevoRol(this);
            nr.ShowDialog();
        }

        private void frmMainRoles_Load(object sender, EventArgs e)
        {
            this.cargarRoles();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.cargarRoles();
        }

        private void chbStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            this.cargarRoles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvRoles.RowCount>=1)
            {
                PKROLES = Convert.ToInt32(this.dgvRoles.CurrentRow.Cells[0].Value);
                frmModificarRoles mr = new frmModificarRoles(this);
                mr.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvRoles.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    roles nRoles = new Modelo.roles();
                    nRoles.pkRol = Convert.ToInt32(this.dgvRoles.CurrentRow.Cells[0].Value);
                    nRoles.sNombre = this.dgvRoles.CurrentRow.Cells[1].Value.ToString();
                    nRoles.bStatus = false;
                    ControladorRol cRoles = new ControladorRol();
                    cRoles.Modificar(nRoles);
                    this.cargarRoles();
                }
            }
        }
    }
}
