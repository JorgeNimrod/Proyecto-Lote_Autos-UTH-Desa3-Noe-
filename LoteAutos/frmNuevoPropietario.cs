using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LoteAutos.Modelo;
using LoteAutos.Controlador;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;

namespace LoteAutos
{
    public partial class frmNuevoPropietario : Form
    {
        frmMainPropietarios wMain;
        string filename, filename1, filename2, filename3;
        VideoCaptureDevice capturar;

        public void GuardarDatos()
        {
            propietarios nPropietario = new Modelo.propietarios();
            nPropietario.sNombre = txtNombre.Text;
            nPropietario.sApellido = txtApellidos.Text;
            nPropietario.sDireccion = txtDireccion.Text;
            nPropietario.sTelefono = txtTelefono.Text;
            nPropietario.sEmail = txtEmail.Text;
            nPropietario.sIfe = txtIfe.Text;
            this.guardarfoto();
            nPropietario.sFoto = filename;

            ControladorPropietario cPropietario = new ControladorPropietario();
            cPropietario.Guardar(nPropietario);

            wMain.CargarPropietarios();

            automoviles nAutomovil = new automoviles();
            this.guardarfoto1();
            this.guardarfoto2();
            this.guardarfoto3();
            nAutomovil.sFoto1 = filename1;
            nAutomovil.sFoto2 = filename2;
            nAutomovil.sFoto3 = filename3;
            nAutomovil.sMarca = txtMarca.Text;
            nAutomovil.sModelo = txtModelo.Text;
            nAutomovil.iAño = Convert.ToInt32(txtAño.Text);
            nAutomovil.sNoSerie = txtNoSerie.Text;
            nAutomovil.sNoPlaca = txtNoPlacas.Text;
            nAutomovil.sColor = txtColor.Text;
            nAutomovil.sNacionalidad = txtNacionalidad.Text;
            nAutomovil.dPrecio = Convert.ToDouble(txtPrecio.Text);
            nAutomovil.sObservaciones = txtObservacines.Text;

            ControladorAutomovil cAutomovil = new ControladorAutomovil();
            cAutomovil.Guardar(nAutomovil);

            propietarioautomoviles nPropietarioAutomovil = new propietarioautomoviles();
            nPropietarioAutomovil.fkPropietario = nPropietario.pkPropietario;
            nPropietarioAutomovil.fkAutomovil = nAutomovil.pkAutomovil;

            ControladorPropietarioAutomovil cPropietarioAutomovil = new ControladorPropietarioAutomovil();
            cPropietarioAutomovil.Guardar(nPropietarioAutomovil);
        }

        public frmNuevoPropietario(frmMainPropietarios wmain)
        {
            InitializeComponent();
            wMain = wmain;
            wMain.CargarPropietarios();
        }
        private void frmNuevoPropietario_Load(object sender, EventArgs e)
        {
        }

        private void btnContinuar_Click(object sender, EventArgs e)
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
            else if (txtMarca.Text == "")
            {
                ErrorProvider.SetError(txtMarca, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtMarca, ErrorIconAlignment.MiddleRight);
                txtMarca.Focus();
            }
            else if (txtModelo.Text == "")
            {
                ErrorProvider.SetError(txtModelo, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtModelo, ErrorIconAlignment.MiddleRight);
                txtModelo.Focus();
            }
            else if (txtNoSerie.Text == "")
            {
                ErrorProvider.SetError(txtNoSerie, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtNoSerie, ErrorIconAlignment.MiddleRight);
                txtNoSerie.Focus();
            }
            else if (txtAño.Text == "")
            {
                ErrorProvider.SetError(txtAño, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtAño, ErrorIconAlignment.MiddleRight);
                txtAño.Focus();
            }
            else if (txtNoPlacas.Text == "")
            {
                ErrorProvider.SetError(txtNoPlacas, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtNoPlacas, ErrorIconAlignment.MiddleRight);
                txtNoPlacas.Focus();
            }
            else if (txtColor.Text == "")
            {
                ErrorProvider.SetError(txtColor, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtColor, ErrorIconAlignment.MiddleRight);
                txtColor.Focus();
            }
            else if (txtNacionalidad.Text == "")
            {
                ErrorProvider.SetError(txtNacionalidad, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtNacionalidad, ErrorIconAlignment.MiddleRight);
                txtNacionalidad.Focus();
            }
            else if (txtPrecio.Text == "")
            {
                ErrorProvider.SetError(txtPrecio, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtPrecio, ErrorIconAlignment.MiddleRight);
                txtPrecio.Focus();
            }
            else if (txtObservacines.Text == "")
            {
                ErrorProvider.SetError(txtObservacines, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtObservacines, ErrorIconAlignment.MiddleRight);
                txtObservacines.Focus();
            }
            else
            {
                frmComisionRegistro cr = new frmComisionRegistro(this);
                cr.ShowDialog();
            }
        }

        public void guardarfoto()
        {
            int num = frmMainPropietarios.ROWS + 1;
            filename = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\Foto" + num.ToString();
            FileStream fstream = new FileStream(filename, FileMode.Create);
            this.imgPerfil.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        public void guardarfoto1()
        {
            int num = frmMainPropietarios.ROWS + 1;
            filename1 = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\FotoAutomovil" + num.ToString();
            FileStream fstream = new FileStream(filename1, FileMode.Create);
            this.pbFoto1.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        public void guardarfoto2()
        {
            int num = frmMainPropietarios.ROWS + 1;
            filename2 = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\FotoAutomovil" + num.ToString();
            FileStream fstream = new FileStream(filename2, FileMode.Create);
            this.pbFoto2.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        public void guardarfoto3()
        {
            int num = frmMainPropietarios.ROWS + 1;
            filename3 = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\FotoAutomovil" + num.ToString();
            FileStream fstream = new FileStream(filename3, FileMode.Create);
            this.pbFoto3.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => imgPerfil.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }

        private void frmNuevoPropietario_Activated(object sender, EventArgs e)
        {
            if (frmComisionRegistro.status == true)
            {
                this.Close();
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
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
                    this.pbFoto1.ImageLocation = BuscarImagen.FileName;
                    this.pbFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbFoto2.Visible = true;
                    this.btnBuscar2.Visible = true;
                    this.btnTomar3.Visible = true;
                    this.btnIniciar3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void btnIniciar2_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto1.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar2_Click(object sender, EventArgs e)
        {
            capturar.Stop();
            this.pbFoto2.Visible = true;
            this.btnBuscar2.Visible = true;
            this.btnTomar3.Visible = true;
            this.btnIniciar3.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNoSerie_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNoPlacas_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void txtObservacines_TextChanged(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
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
                    this.pbFoto2.ImageLocation = BuscarImagen.FileName;
                    this.pbFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
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
                    this.pbFoto3.ImageLocation = BuscarImagen.FileName;
                    this.pbFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pbFoto3.Visible = true;
                    this.btnBuscar3.Visible = true;
                    this.btnTomar4.Visible = true;
                    this.btnIniciar4.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }

        private void btnIniciar3_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto2.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar3_Click(object sender, EventArgs e)
        {
            capturar.Stop();
            this.pbFoto3.Visible = true;
            this.btnBuscar3.Visible = true;
            this.btnTomar4.Visible = true;
            this.btnIniciar4.Visible = true;
        }

        private void btnIniciar4_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto3.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar4_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }
    }
}
