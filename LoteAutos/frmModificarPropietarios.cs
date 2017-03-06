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
using System.IO;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace LoteAutos
{
    public partial class frmModificarPropietarios : Form
    {
        frmMainPropietarios wMain;
        string filename;
        VideoCaptureDevice capturar;
        public frmModificarPropietarios(frmMainPropietarios wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.CargarPropietarios();
        }

        private void frmModificarPropietarios_Load(object sender, EventArgs e)
        {
            propietarios npropietario = ControladorPropietario.getUruariosById(frmMainPropietarios.PKPROPIETARIO);
            txtNombre.Text = npropietario.sNombre;
            txtApellidos.Text = npropietario.sApellido;
            txtDireccion.Text = npropietario.sDireccion;
            txtTelefono.Text = npropietario.sTelefono;
            txtEmail.Text = npropietario.sEmail;
            txtIfe.Text = npropietario.sIfe;
            imgPerfil.Load(npropietario.sFoto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                ErrorProvider.SetError(txtNombre, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtNombre, ErrorIconAlignment.MiddleLeft);
                txtNombre.Focus();
            }
            else if (txtApellidos.Text == "")
            {
                ErrorProvider.SetError(txtApellidos, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtApellidos, ErrorIconAlignment.MiddleRight);
                txtApellidos.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                ErrorProvider.SetError(txtDireccion, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtDireccion, ErrorIconAlignment.MiddleRight);
                txtDireccion.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                ErrorProvider.SetError(txtTelefono, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtTelefono, ErrorIconAlignment.MiddleLeft);
                txtTelefono.Focus();
            }
            else if (txtEmail.Text == "")
            {
                ErrorProvider.SetError(txtEmail, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtEmail, ErrorIconAlignment.MiddleRight);
                txtEmail.Focus();
            }
            else if (txtIfe.Text == "")
            {
                ErrorProvider.SetError(txtIfe, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtIfe, ErrorIconAlignment.MiddleRight);
                txtIfe.Focus();
            }
            else
            {
                propietarios npropietario = new Modelo.propietarios();
                npropietario.pkPropietario = frmMainPropietarios.PKPROPIETARIO;
                npropietario.sNombre = txtNombre.Text;
                npropietario.sApellido = txtApellidos.Text;
                npropietario.sDireccion = txtDireccion.Text;
                npropietario.sTelefono = txtTelefono.Text;
                npropietario.sEmail = txtEmail.Text;
                npropietario.sIfe = txtIfe.Text;
                this.guardarfoto();
                npropietario.sFoto = filename;

                ControladorPropietario cPermisos = new ControladorPropietario();
                cPermisos.Modificar(npropietario);

                wMain.CargarPropietarios();
                this.Close();
            }
        }

        public void guardarfoto()
        {
            int num = frmMainPropietarios.ROWS + 1;
            filename = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\Foto" + num.ToString();
            FileStream fstream = new FileStream(filename, FileMode.Create);
            imgPerfil.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
        }

        private void txtNomFotoPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtIfe_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void btnExplorar_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog BuscarImagen = new OpenFileDialog();
                BuscarImagen.Filter = "Archivos de Imagen|*.jpg;*.png;*gif;*.bmp";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Seleccione una imagen";
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    this.txtNomFotoPerfil.Text = BuscarImagen.FileName;
                    this.imgPerfil.ImageLocation = this.txtNomFotoPerfil.Text;
                    imgPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
                    //r64 = EncodeImage(this.imgPerfil.Image, ImageFormat.Jpeg);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => imgPerfil.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar_Click_1(object sender, EventArgs e)
        {
            capturar.Stop();
        }
    }
}
