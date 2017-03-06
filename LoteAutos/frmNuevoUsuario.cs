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
    public partial class frmNuevoUsuario : Form
    {
        frmMainUsuarios wMain;
        public void CargarRoles()
        {
            this.cmbRol.DataSource = ControladorRol.getAllRol(true);
            this.cmbRol.DisplayMember = "sNombre";
            this.cmbRol.ValueMember = "pkRol";
        }
        public frmNuevoUsuario(frmMainUsuarios wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtUsuario, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtUsuario, "Campo necesario");
                this.txtUsuario.Focus();
            }
            else if (this.txtPassword.Text == "")
            {
                this.ErrorProvider.SetIconAlignment(this.txtPassword, ErrorIconAlignment.MiddleRight);
                this.ErrorProvider.SetError(this.txtPassword, "Campo necesario");
                this.txtPassword.Focus();
            }
            else
            {
                usuarios nUsuario = new usuarios();
                nUsuario.sUsuario = txtUsuario.Text.Trim();
                nUsuario.sPassword = txtPassword.Text.Trim();
                nUsuario.fkRol = Convert.ToInt32(cmbRol.SelectedValue.ToString());

                ControladorUsuario cUsuario = new ControladorUsuario();
                cUsuario.Guardar(nUsuario);

                wMain.CargarDatos();
                this.Close();
            }
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            this.CargarRoles();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }
    }
}
