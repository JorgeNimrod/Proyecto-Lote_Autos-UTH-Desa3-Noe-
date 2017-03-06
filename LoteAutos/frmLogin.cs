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
    public partial class frmLogin : Form
    {
        ManejoSesion.SessiononHelper objsession;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objsession = ManejoSesion.Login(txtUsuario.Text, txtContraseña.Text);

            if (!objsession.isValid)
            {
                errorProvider.SetError(txtUsuario, objsession.msgError);
                errorProvider.SetError(txtContraseña, objsession.msgError);
                txtUsuario.Focus();
            }
            else
            {
                frmMainMenu.SessionActiva = objsession;
                this.Close();

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (frmMainMenu.SessionActiva.isValid)
            {
                this.Close();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
