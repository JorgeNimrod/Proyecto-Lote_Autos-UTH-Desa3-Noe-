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
    public partial class frmModificarRoles : Form
    {
        frmMainRoles wMain;
        public frmModificarRoles(frmMainRoles wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.cargarRoles();
        }

        private void frmModificarRoles_Load(object sender, EventArgs e)
        {
            roles nroles = ControladorRol.getRolById(frmMainRoles.PKROLES);
            txtRol.Text = nroles.sNombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRol.Text == "")
            {
                ErrorProvider.SetError(txtRol, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtRol, ErrorIconAlignment.MiddleRight);
                txtRol.Focus();
            }
            else
            {
                roles nroles = new Modelo.roles();
                nroles.pkRol = frmMainRoles.PKROLES;
                nroles.sNombre = txtRol.Text;

                ControladorRol croles = new ControladorRol();
                croles.Modificar(nroles);

                wMain.cargarRoles();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRol_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}
