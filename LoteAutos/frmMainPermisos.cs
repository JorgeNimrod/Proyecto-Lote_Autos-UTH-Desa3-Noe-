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
    public partial class frmMainPermisos : Form
    {
        public static int PKPERMISOS;
        public void cargarPermisos()
        {
            this.dgvPermisos.DataSource = ControladorPermiso.Buscar(txtBuscar.Text, true);
        }
        public frmMainPermisos()
        {
            InitializeComponent();
            this.dgvPermisos.AutoGenerateColumns = false;
        }

        private void btnNuevoPermiso_Click(object sender, EventArgs e)
        {
            frmNuevoPermiso np = new frmNuevoPermiso(this);
            np.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarPermisos();
        }

        private void frmMainPermisos_Load(object sender, EventArgs e)
        {
            this.cargarPermisos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dgvPermisos.RowCount>=1)
            {
                PKPERMISOS = Convert.ToInt32(this.dgvPermisos.CurrentRow.Cells[0].Value);
                frmModificarPermisos mp = new LoteAutos.frmModificarPermisos(this);
                mp.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPermisos.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    permisos npermisos = new Modelo.permisos();
                    npermisos.sModulo = this.dgvPermisos.CurrentRow.Cells[1].Value.ToString();
                    npermisos.sDescripcion = this.dgvPermisos.CurrentRow.Cells[2].Value.ToString();
                    npermisos.bStatusl = false;
                    npermisos.pkPermiso = Convert.ToInt32(this.dgvPermisos.CurrentRow.Cells[0].Value);
                    ControladorPermiso cRoles = new Controlador.ControladorPermiso();
                    cRoles.Modificar(npermisos);
                    this.cargarPermisos();
                }
            }
        }
    }
}
