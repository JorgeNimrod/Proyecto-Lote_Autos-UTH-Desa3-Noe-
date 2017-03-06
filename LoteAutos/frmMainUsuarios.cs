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
    public partial class frmMainUsuarios : Form
    {
        public static int PKUSUARIO;
        public void CargarDatos()
        {
            this.dgvUsuarios.DataSource = ControladorUsuario.Buscar(txtBuscar.Text,chbStatus.Checked);
        }
        public frmMainUsuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = false;
        }

        private void frmMainUsuarios_Load(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario nv = new frmNuevoUsuario(this);
            nv.ShowDialog();
        }

        private void chbStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.RowCount >= 1)
            {
                PKUSUARIO = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value);
                frmModificarUsuario nv = new frmModificarUsuario(this);
                nv.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.RowCount >= 1)
            {
                if (MessageBox.Show("Realmente quiere elimar este registro?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorUsuario cUsuario = new ControladorUsuario();
                    cUsuario.Eliminar(Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value));
                    this.CargarDatos();
                }
            }
        }
    }
}
