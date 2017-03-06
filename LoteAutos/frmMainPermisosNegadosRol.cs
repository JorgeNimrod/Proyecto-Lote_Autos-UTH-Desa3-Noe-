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

namespace LoteAutos
{
    public partial class frmMainPermisosNegadosRol : Form
    {
        public static int PKPERMISOSNEGADOSROL;
        public void cargarPermisosNegadosRol()
        {
            this.dgvPermisosNegadosRol.DataSource = ControladorPermisosNegadosRol.getAllPermisosNegadosRol();
        }
        public frmMainPermisosNegadosRol()
        {
            InitializeComponent();
            this.dgvPermisosNegadosRol.AutoGenerateColumns = false;
        }

        private void frmMainPermisosNegadosRol_Load(object sender, EventArgs e)
        {
            this.cargarPermisosNegadosRol();
        }

        private void btnNuevoPermiso_Click(object sender, EventArgs e)
        {
            frmNuevoPermisosNegadosRol np = new LoteAutos.frmNuevoPermisosNegadosRol(this);
            np.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvPermisosNegadosRol.RowCount >= 1)
            {
                PKPERMISOSNEGADOSROL = Convert.ToInt32(this.dgvPermisosNegadosRol.CurrentRow.Cells[0].Value);
                frmModificarPermisosNegadosRol mp = new frmModificarPermisosNegadosRol(this);
                mp.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPermisosNegadosRol.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorPermisosNegadosRol cPermisosNegadosRol = new Controlador.ControladorPermisosNegadosRol();
                    cPermisosNegadosRol.Eliminar(Convert.ToInt32(this.dgvPermisosNegadosRol.CurrentRow.Cells[0].Value));
                    this.cargarPermisosNegadosRol();
                }
            }
        }
    }
}
