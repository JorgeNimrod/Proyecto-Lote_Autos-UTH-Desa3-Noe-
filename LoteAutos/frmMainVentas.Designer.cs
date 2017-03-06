namespace LoteAutos
{
    partial class frmMainVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvdetalleautomoviles = new System.Windows.Forms.DataGridView();
            this.pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleautomoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del comprador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(51, 117);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(508, 26);
            this.txtDireccion.TabIndex = 58;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(308, 63);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(251, 26);
            this.txtApellidos.TabIndex = 57;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 26);
            this.txtNombre.TabIndex = 56;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(509, 410);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubTotal.TabIndex = 2;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "SUBTOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(509, 474);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(149, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(12, 504);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(131, 30);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Location = new System.Drawing.Point(509, 442);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 26);
            this.txtIVA.TabIndex = 4;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "IVA:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 186);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 30);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // dgvdetalleautomoviles
            // 
            this.dgvdetalleautomoviles.AllowUserToDeleteRows = false;
            this.dgvdetalleautomoviles.AllowUserToResizeColumns = false;
            this.dgvdetalleautomoviles.AllowUserToResizeRows = false;
            this.dgvdetalleautomoviles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalleautomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalleautomoviles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPropietario,
            this.sNoSerie,
            this.sMarca,
            this.sModelo,
            this.sNoPlaca,
            this.sNacionalidad,
            this.dPrecio,
            this.sFoto1,
            this.sFoto2,
            this.sFoto3,
            this.sColor,
            this.iAño,
            this.sObservaciones});
            this.dgvdetalleautomoviles.Location = new System.Drawing.Point(12, 222);
            this.dgvdetalleautomoviles.Name = "dgvdetalleautomoviles";
            this.dgvdetalleautomoviles.ReadOnly = true;
            this.dgvdetalleautomoviles.RowHeadersVisible = false;
            this.dgvdetalleautomoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetalleautomoviles.Size = new System.Drawing.Size(597, 182);
            this.dgvdetalleautomoviles.TabIndex = 11;
            // 
            // pkPropietario
            // 
            this.pkPropietario.DataPropertyName = "pkAutomovil";
            this.pkPropietario.FillWeight = 203.0457F;
            this.pkPropietario.HeaderText = "Codigo";
            this.pkPropietario.Name = "pkPropietario";
            this.pkPropietario.ReadOnly = true;
            this.pkPropietario.Visible = false;
            this.pkPropietario.Width = 80;
            // 
            // sNoSerie
            // 
            this.sNoSerie.DataPropertyName = "sNoSerie";
            this.sNoSerie.FillWeight = 65.65144F;
            this.sNoSerie.HeaderText = "No. Serie";
            this.sNoSerie.Name = "sNoSerie";
            this.sNoSerie.ReadOnly = true;
            // 
            // sMarca
            // 
            this.sMarca.DataPropertyName = "sMarca";
            this.sMarca.FillWeight = 65.65144F;
            this.sMarca.HeaderText = "Marca";
            this.sMarca.Name = "sMarca";
            this.sMarca.ReadOnly = true;
            // 
            // sModelo
            // 
            this.sModelo.DataPropertyName = "sModelo";
            this.sModelo.FillWeight = 65.65144F;
            this.sModelo.HeaderText = "Modelo";
            this.sModelo.Name = "sModelo";
            this.sModelo.ReadOnly = true;
            // 
            // sNoPlaca
            // 
            this.sNoPlaca.DataPropertyName = "sNoPlaca";
            this.sNoPlaca.HeaderText = "No. Placa";
            this.sNoPlaca.Name = "sNoPlaca";
            this.sNoPlaca.ReadOnly = true;
            // 
            // sNacionalidad
            // 
            this.sNacionalidad.DataPropertyName = "sNacionalidad";
            this.sNacionalidad.HeaderText = "Nacionalidad";
            this.sNacionalidad.Name = "sNacionalidad";
            this.sNacionalidad.ReadOnly = true;
            // 
            // dPrecio
            // 
            this.dPrecio.DataPropertyName = "dPrecio";
            this.dPrecio.HeaderText = "Precio";
            this.dPrecio.Name = "dPrecio";
            this.dPrecio.ReadOnly = true;
            // 
            // sFoto1
            // 
            this.sFoto1.HeaderText = "Foto1";
            this.sFoto1.Name = "sFoto1";
            this.sFoto1.ReadOnly = true;
            this.sFoto1.Visible = false;
            // 
            // sFoto2
            // 
            this.sFoto2.HeaderText = "Foto2";
            this.sFoto2.Name = "sFoto2";
            this.sFoto2.ReadOnly = true;
            this.sFoto2.Visible = false;
            // 
            // sFoto3
            // 
            this.sFoto3.HeaderText = "Foto3";
            this.sFoto3.Name = "sFoto3";
            this.sFoto3.ReadOnly = true;
            this.sFoto3.Visible = false;
            // 
            // sColor
            // 
            this.sColor.HeaderText = "Color";
            this.sColor.Name = "sColor";
            this.sColor.ReadOnly = true;
            this.sColor.Visible = false;
            // 
            // iAño
            // 
            this.iAño.HeaderText = "Año";
            this.iAño.Name = "iAño";
            this.iAño.ReadOnly = true;
            this.iAño.Visible = false;
            // 
            // sObservaciones
            // 
            this.sObservaciones.HeaderText = "Observaciones";
            this.sObservaciones.Name = "sObservaciones";
            this.sObservaciones.ReadOnly = true;
            this.sObservaciones.Visible = false;
            // 
            // frmMainVentas
            // 
            this.AcceptButton = this.btnPagar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 546);
            this.Controls.Add(this.dgvdetalleautomoviles);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainVentas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta de autos";
            this.Activated += new System.EventHandler(this.frmMainVentas_Activated);
            this.Load += new System.EventHandler(this.frmMainVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalleautomoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridView dgvdetalleautomoviles;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservaciones;
    }
}