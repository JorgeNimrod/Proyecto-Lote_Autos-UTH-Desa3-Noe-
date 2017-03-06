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
    public partial class frmModificarPermisos : Form
    {
        frmMainPermisos wMain;
        public frmModificarPermisos(frmMainPermisos wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.cargarPermisos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtModulo.Text == "")
            {
                ErrorProvider.SetError(txtModulo, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtModulo, ErrorIconAlignment.MiddleRight);
                txtModulo.Focus();
            }
            else if (txtDescripcion.Text == "")
            {
                ErrorProvider.SetError(txtDescripcion, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtDescripcion, ErrorIconAlignment.MiddleRight);
                txtDescripcion.Focus();
            }
            else
            {
                permisos nPermiso = new Modelo.permisos();
                nPermiso.pkPermiso = frmMainPermisos.PKPERMISOS;
                nPermiso.sModulo = txtModulo.Text;
                nPermiso.sDescripcion = txtDescripcion.Text;

                ControladorPermiso cPermiso = new Controlador.ControladorPermiso();
                cPermiso.Guardar(nPermiso);

                wMain.cargarPermisos();
                this.Close();
            }
        }

        private void frmModificarPermisos_Load(object sender, EventArgs e)
        {
            permisos nPermiso = ControladorPermiso.getPermisoById(frmMainPermisos.PKPERMISOS);
            txtModulo.Text = nPermiso.sModulo;
            txtDescripcion.Text = nPermiso.sDescripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModulo_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}
