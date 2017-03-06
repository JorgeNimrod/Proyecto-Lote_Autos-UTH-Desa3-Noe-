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
    public partial class frmNuevoRol : Form
    {
        frmMainRoles wMain;
        public frmNuevoRol(frmMainRoles wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.cargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRol.Text=="")
            {
                ErrorProvider.SetError(txtRol, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtRol, ErrorIconAlignment.MiddleRight);
                txtRol.Focus();
            }
            else
            {
                roles nRol = new Modelo.roles();
                nRol.sNombre = txtRol.Text.Trim();

                ControladorRol cRol = new ControladorRol();
                cRol.Guardar(nRol);

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
