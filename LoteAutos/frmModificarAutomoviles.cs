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
using AForge.Video.DirectShow;
using System.IO;

namespace LoteAutos
{
    public partial class frmModificarAutomoviles : Form
    {
        frmMainAutomoviles wMain;
        VideoCaptureDevice capturar;
        string filename1, filename2, filename3;

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
            int num = frmMainPropietarios.ROWS + 2;
            filename2 = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\FotoAutomovil" + num.ToString();
            FileStream fstream = new FileStream(filename2, FileMode.Create);
            this.pbFoto2.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        public void guardarfoto3()
        {
            int num = frmMainPropietarios.ROWS + 3;
            filename3 = @"C:\Users\HERNANDEZ\Documents\Desarrollo de Aplicaciones III\LoteAutos-master\LoteAutos\bin\Debug\FotoAutomovil" + num.ToString();
            FileStream fstream = new FileStream(filename3, FileMode.Create);
            this.pbFoto3.Image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();
        }

        public frmModificarAutomoviles(frmMainAutomoviles wmain)
        {
            InitializeComponent();
            wMain = wmain;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarAutomoviles_Load(object sender, EventArgs e)
        {
            automoviles nAutomovil = ControladorAutomovil.getautomovilById(frmMainAutomoviles.PKAUTOMOVIL);
            this.pbFoto1.Load(nAutomovil.sFoto1);
            this.pbFoto2.Load(nAutomovil.sFoto2);
            this.pbFoto3.Load(nAutomovil.sFoto3);
            txtMarca.Text = nAutomovil.sMarca;
            txtModelo.Text = nAutomovil.sModelo;
            txtAño.Text = nAutomovil.iAño.ToString();
            txtNoPlacas.Text = nAutomovil.sNoPlaca.ToString();
            txtNoSerie.Text = nAutomovil.sNoSerie.ToString();
            txtColor.Text = nAutomovil.sColor;
            txtNacionalidad.Text = nAutomovil.sNacionalidad;
            txtPrecio.Text = nAutomovil.dPrecio.ToString();
            txtObservacines.Text = nAutomovil.sObservaciones;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                ErrorProvider.SetError(txtMarca, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtMarca, ErrorIconAlignment.MiddleRight);
                txtMarca.Focus();
            }
            else if (txtModelo.Text == "")
            {
                ErrorProvider.SetError(txtModelo, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtModelo, ErrorIconAlignment.MiddleLeft);
                txtModelo.Focus();
            }
            else if (txtNoSerie.Text == "")
            {
                ErrorProvider.SetError(txtNoSerie, "Campo necesario");
                ErrorProvider.SetIconAlignment(txtNoSerie, ErrorIconAlignment.MiddleLeft);
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
                ErrorProvider.SetIconAlignment(txtColor, ErrorIconAlignment.MiddleLeft);
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
                ErrorProvider.SetIconAlignment(txtPrecio, ErrorIconAlignment.MiddleLeft);
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
                automoviles nAutomovil = new automoviles();
                nAutomovil.pkAutomovil = frmMainAutomoviles.PKAUTOMOVIL;
                guardarfoto1();
                guardarfoto2();
                guardarfoto3();
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
                nAutomovil.dPrecio = Convert.ToInt32(txtPrecio.Text);
                nAutomovil.sObservaciones = txtObservacines.Text;

                ControladorAutomovil cAutomovil = new ControladorAutomovil();
                cAutomovil.Modificar(nAutomovil);
                
                this.Close();
            }
        }

        private void txtObcervacines_TextChanged(object sender, EventArgs e)
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

        private void btnIniciar1_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto1.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnIniciar2_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto2.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnIniciar3_Click(object sender, EventArgs e)
        {
            FilterInfoCollection info = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (info != null)
            {
                capturar = new VideoCaptureDevice(info[0].MonikerString);
                capturar.NewFrame += (s, i) => this.pbFoto3.Image = (Bitmap)i.Frame.Clone();
                capturar.Start();
            }
        }

        private void btnTomar1_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }

        private void btnTomar2_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }

        private void btnTomar3_Click(object sender, EventArgs e)
        {
            capturar.Stop();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido" + ex.Message);
            }
        }
    }
}
