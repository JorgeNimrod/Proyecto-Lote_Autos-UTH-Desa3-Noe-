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
    public partial class frmNuevoPermisosNegadosRol : Form
    {
        frmMainPermisosNegadosRol wMain;
        public void cargarRoles()
        {
            this.cmbRoles.DataSource = ControladorRol.getAllRol(true);
            this.cmbRoles.DisplayMember = "sNombre";
            this.cmbRoles.ValueMember = "pkRol";
        }

        public void cargarPermisos()
        {
            this.cmbPermisos.DataSource = ControladorPermiso.getAllPermisos();
            this.cmbPermisos.DisplayMember = "sModulo";
            this.cmbPermisos.ValueMember = "pkPermiso";
        }
        public frmNuevoPermisosNegadosRol(frmMainPermisosNegadosRol wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.cargarPermisosNegadosRol();
        }

        private void frmNuevoPermisosNegadosRol_Load(object sender, EventArgs e)
        {
            this.cargarPermisos();
            this.cargarRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            permisosnegadosrol nPermisosNegadosRol = new Modelo.permisosnegadosrol();
            nPermisosNegadosRol.fkPermiso = Convert.ToInt32(cmbPermisos.SelectedValue);
            nPermisosNegadosRol.fkRol = Convert.ToInt32(cmbRoles.SelectedValue);

            ControladorPermisosNegadosRol cPermisosNegadosRol = new ControladorPermisosNegadosRol();
            cPermisosNegadosRol.Guardar(nPermisosNegadosRol);

            wMain.cargarPermisosNegadosRol();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
