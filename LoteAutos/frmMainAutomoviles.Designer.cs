namespace LoteAutos
{
    partial class frmMainAutomoviles
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
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAutomoviles = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbPropietarios = new System.Windows.Forms.ComboBox();
            this.pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).BeginInit();
            this.SuspendLayout();
            // 
            // chbStatus
            // 
            this.chbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chbStatus.AutoSize = true;
            this.chbStatus.Checked = true;
            this.chbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStatus.Location = new System.Drawing.Point(897, 388);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(75, 24);
            this.chbStatus.TabIndex = 14;
            this.chbStatus.Text = "Status";
            this.chbStatus.UseVisualStyleBackColor = true;
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar por propietario:";
            // 
            // dgvAutomoviles
            // 
            this.dgvAutomoviles.AllowUserToAddRows = false;
            this.dgvAutomoviles.AllowUserToDeleteRows = false;
            this.dgvAutomoviles.AllowUserToResizeColumns = false;
            this.dgvAutomoviles.AllowUserToResizeRows = false;
            this.dgvAutomoviles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomoviles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPropietario,
            this.sFoto1,
            this.sFoto2,
            this.sFoto3,
            this.sMarca,
            this.sModelo,
            this.iAño,
            this.sNoSerie,
            this.sNoPlaca,
            this.sColor,
            this.sNacionalidad,
            this.dPrecio,
            this.sObservaciones});
            this.dgvAutomoviles.Location = new System.Drawing.Point(16, 46);
            this.dgvAutomoviles.Name = "dgvAutomoviles";
            this.dgvAutomoviles.ReadOnly = true;
            this.dgvAutomoviles.RowHeadersVisible = false;
            this.dgvAutomoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomoviles.Size = new System.Drawing.Size(956, 336);
            this.dgvAutomoviles.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(153, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 30);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(16, 419);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 30);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbPropietarios
            // 
            this.cmbPropietarios.FormattingEnabled = true;
            this.cmbPropietarios.Location = new System.Drawing.Point(187, 12);
            this.cmbPropietarios.Name = "cmbPropietarios";
            this.cmbPropietarios.Size = new System.Drawing.Size(234, 28);
            this.cmbPropietarios.TabIndex = 19;
            // 
            // pkPropietario
            // 
            this.pkPropietario.DataPropertyName = "pkAutomovil";
            this.pkPropietario.FillWeight = 203.0457F;
            this.pkPropietario.HeaderText = "Codigo";
            this.pkPropietario.Name = "pkPropietario";
            this.pkPropietario.ReadOnly = true;
            this.pkPropietario.Width = 80;
            // 
            // sFoto1
            // 
            this.sFoto1.DataPropertyName = "sFoto1";
            this.sFoto1.HeaderText = "Foto 1";
            this.sFoto1.Name = "sFoto1";
            this.sFoto1.ReadOnly = true;
            // 
            // sFoto2
            // 
            this.sFoto2.DataPropertyName = "sFoto2";
            this.sFoto2.HeaderText = "Foto 2";
            this.sFoto2.Name = "sFoto2";
            this.sFoto2.ReadOnly = true;
            // 
            // sFoto3
            // 
            this.sFoto3.DataPropertyName = "sFoto3";
            this.sFoto3.HeaderText = "Foto 3";
            this.sFoto3.Name = "sFoto3";
            this.sFoto3.ReadOnly = true;
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
            this.sModelo.Width = 130;
            // 
            // iAño
            // 
            this.iAño.DataPropertyName = "iAño";
            this.iAño.HeaderText = "Año";
            this.iAño.Name = "iAño";
            this.iAño.ReadOnly = true;
            // 
            // sNoSerie
            // 
            this.sNoSerie.DataPropertyName = "sNoSerie";
            this.sNoSerie.FillWeight = 65.65144F;
            this.sNoSerie.HeaderText = "No. Serie";
            this.sNoSerie.Name = "sNoSerie";
            this.sNoSerie.ReadOnly = true;
            this.sNoSerie.Width = 115;
            // 
            // sNoPlaca
            // 
            this.sNoPlaca.DataPropertyName = "sNoPlaca";
            this.sNoPlaca.HeaderText = "No. Placa";
            this.sNoPlaca.Name = "sNoPlaca";
            this.sNoPlaca.ReadOnly = true;
            // 
            // sColor
            // 
            this.sColor.DataPropertyName = "sColor";
            this.sColor.HeaderText = "Color";
            this.sColor.Name = "sColor";
            this.sColor.ReadOnly = true;
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
            // sObservaciones
            // 
            this.sObservaciones.DataPropertyName = "sObservaciones";
            this.sObservaciones.HeaderText = "Observaciones";
            this.sObservaciones.Name = "sObservaciones";
            this.sObservaciones.ReadOnly = true;
            // 
            // frmMainAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.cmbPropietarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutomoviles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmMainAutomoviles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de automoviles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainAutomoviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAutomoviles;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbPropietarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn sObservaciones;
    }
}