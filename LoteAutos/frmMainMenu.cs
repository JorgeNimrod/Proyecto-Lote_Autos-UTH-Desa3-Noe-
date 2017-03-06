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
    public partial class frmMainMenu : Form
    {
        public static ManejoSesion.SessiononHelper SessionActiva;
        
        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.gpbAdmin.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.tienepermiso(permisos);
                }
            }

            foreach (var obj in this.gpbOpcinoes.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.tienepermiso(permisos);
                }
            }
        }

        public frmMainMenu()
        {
            SessionActiva = new ManejoSesion.SessiononHelper();
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (!SessionActiva.isValid)
            {
                frmLogin nLogin = new frmLogin();
                nLogin.ShowDialog();
            }
        }

        private void frmMainMenu_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMainUsuarios vUsuario = new frmMainUsuarios();
            vUsuario.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmMainRoles vRoles = new LoteAutos.frmMainRoles();
            vRoles.ShowDialog();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmMainPermisos vPermisos = new frmMainPermisos();
            vPermisos.ShowDialog();
        }

        private void btnPermisosNegadosRol_Click(object sender, EventArgs e)
        {
            frmMainPermisosNegadosRol mp = new LoteAutos.frmMainPermisosNegadosRol();
            mp.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmMainVentas mv = new LoteAutos.frmMainVentas();
            mv.ShowDialog();
        }

        private void btnpropietarios_Click(object sender, EventArgs e)
        {
            frmMainPropietarios vPropietarios = new LoteAutos.frmMainPropietarios();
            vPropietarios.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainAutomoviles ma = new LoteAutos.frmMainAutomoviles();
            ma.ShowDialog();
        }
    }
}
