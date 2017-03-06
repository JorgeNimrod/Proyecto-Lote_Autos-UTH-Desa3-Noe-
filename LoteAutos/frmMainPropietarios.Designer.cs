namespace LoteAutos
{
    partial class frmMainPropietarios
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
            this.dgvPropietario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).BeginInit();
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
            this.chbStatus.TabIndex = 9;
            this.chbStatus.Text = "Status";
            this.chbStatus.UseVisualStyleBackColor = true;
            this.chbStatus.CheckedChanged += new System.EventHandler(this.chbStatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar:";
            // 
            // dgvPropietario
            // 
            this.dgvPropietario.AllowUserToAddRows = false;
            this.dgvPropietario.AllowUserToDeleteRows = false;
            this.dgvPropietario.AllowUserToResizeColumns = false;
            this.dgvPropietario.AllowUserToResizeRows = false;
            this.dgvPropietario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.sFoto,
            this.sNombre,
            this.sApellido,
            this.sDireccion,
            this.sTelefono,
            this.sEmail,
            this.sIfe});
            this.dgvPropietario.Location = new System.Drawing.Point(16, 44);
            this.dgvPropietario.Name = "dgvPropietario";
            this.dgvPropietario.ReadOnly = true;
            this.dgvPropietario.RowHeadersVisible = false;
            this.dgvPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPropietario.Size = new System.Drawing.Size(956, 338);
            this.dgvPropietario.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "pkPropietario";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // sFoto
            // 
            this.sFoto.DataPropertyName = "sFoto";
            this.sFoto.HeaderText = "Foto";
            this.sFoto.Name = "sFoto";
            this.sFoto.ReadOnly = true;
            this.sFoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sFoto.Width = 150;
            // 
            // sNombre
            // 
            this.sNombre.DataPropertyName = "sNombre";
            this.sNombre.HeaderText = "Nombre";
            this.sNombre.Name = "sNombre";
            this.sNombre.ReadOnly = true;
            // 
            // sApellido
            // 
            this.sApellido.DataPropertyName = "sApellido";
            this.sApellido.HeaderText = "Apellidos";
            this.sApellido.Name = "sApellido";
            this.sApellido.ReadOnly = true;
            // 
            // sDireccion
            // 
            this.sDireccion.DataPropertyName = "sDireccion";
            this.sDireccion.HeaderText = "Direccion";
            this.sDireccion.Name = "sDireccion";
            this.sDireccion.ReadOnly = true;
            this.sDireccion.Width = 200;
            // 
            // sTelefono
            // 
            this.sTelefono.DataPropertyName = "sTelefono";
            this.sTelefono.HeaderText = "Telefono";
            this.sTelefono.Name = "sTelefono";
            this.sTelefono.ReadOnly = true;
            // 
            // sEmail
            // 
            this.sEmail.DataPropertyName = "sEmail";
            this.sEmail.HeaderText = "Email";
            this.sEmail.Name = "sEmail";
            this.sEmail.ReadOnly = true;
            // 
            // sIfe
            // 
            this.sIfe.DataPropertyName = "sIfe";
            this.sIfe.HeaderText = "Ife";
            this.sIfe.Name = "sIfe";
            this.sIfe.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(81, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(891, 26);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(286, 419);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 30);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Tag = "8";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(149, 419);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 30);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(12, 419);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 30);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmMainPropietarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPropietario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainPropietarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de propietarios";
            this.Activated += new System.EventHandler(this.frmMainPropietarios_Activated);
            this.Load += new System.EventHandler(this.frmMainPropietarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropietario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPropietario;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn sApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIfe;
    }
}