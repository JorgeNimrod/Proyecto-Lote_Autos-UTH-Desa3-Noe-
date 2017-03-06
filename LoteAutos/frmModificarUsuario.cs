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
    public partial class frmModificarUsuario : Form
    {
        frmMainUsuarios wMain;
        public void cargarRoles()
        {
            this.cmbRol.DataSource = ControladorRol.getAllRol(true);
            this.cmbRol.DisplayMember = "sNombre";
            this.cmbRol.ValueMember = "pkRol";
        }
        public frmModificarUsuario(frmMainUsuarios wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.CargarDatos();
        }

        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            this.cargarRoles();
            usuarios nusuario = ControladorUsuario.getUruariosById(frmMainUsuarios.PKUSUARIO);
            txtUsuario.Text = nusuario.sUsuario;
            txtPassword.Text = nusuario.sPassword;
            cmbRol.SelectedValue = nusuario.fkRol;
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
                usuarios nusuario = new usuarios();
                nusuario.pkUsuario = frmMainUsuarios.PKUSUARIO;
                nusuario.sUsuario = txtUsuario.Text;
                nusuario.sPassword = txtPassword.Text;
                nusuario.fkRol = Convert.ToInt32(cmbRol.SelectedValue);

                ControladorUsuario cusuario = new ControladorUsuario();
                cusuario.Modificar(nusuario);

                wMain.CargarDatos();

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
