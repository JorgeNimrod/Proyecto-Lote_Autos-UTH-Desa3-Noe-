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
    public partial class frmModificarPermisosNegadosRol : Form
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
        public frmModificarPermisosNegadosRol(frmMainPermisosNegadosRol wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.cargarPermisosNegadosRol();
        }

        private void frmModificarPermisosNegadosRol_Load(object sender, EventArgs e)
        {
            this.cargarPermisos();
            this.cargarRoles();
            permisosnegadosrol npermisosnegadosrol = ControladorPermisosNegadosRol.getPermisoNegadoRolById(frmMainPermisosNegadosRol.PKPERMISOSNEGADOSROL);
            cmbPermisos.SelectedValue = npermisosnegadosrol.fkPermiso;
            cmbRoles.SelectedValue = npermisosnegadosrol.fkRol;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            permisosnegadosrol npermisosnegadosrol = new permisosnegadosrol();
            npermisosnegadosrol.pkPermisoNegadoRol = frmMainPermisosNegadosRol.PKPERMISOSNEGADOSROL;
            npermisosnegadosrol.fkPermiso = Convert.ToInt32(cmbPermisos.SelectedValue);
            npermisosnegadosrol.fkRol = Convert.ToInt32(cmbRoles.SelectedValue);

            ControladorPermisosNegadosRol cpermisosnegadosrol = new ControladorPermisosNegadosRol();
            cpermisosnegadosrol.Modificar(npermisosnegadosrol);

            wMain.cargarPermisosNegadosRol();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
