namespace LoteAutos
{
    partial class frmMainPermisos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPermiso = new System.Windows.Forms.Button();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.pkPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(81, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(741, 26);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            // 
            // btnNuevoPermiso
            // 
            this.btnNuevoPermiso.Location = new System.Drawing.Point(12, 319);
            this.btnNuevoPermiso.Name = "btnNuevoPermiso";
            this.btnNuevoPermiso.Size = new System.Drawing.Size(131, 30);
            this.btnNuevoPermiso.TabIndex = 11;
            this.btnNuevoPermiso.Text = "Agregar";
            this.btnNuevoPermiso.UseVisualStyleBackColor = true;
            this.btnNuevoPermiso.Click += new System.EventHandler(this.btnNuevoPermiso_Click);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AllowUserToResizeColumns = false;
            this.dgvPermisos.AllowUserToResizeRows = false;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPermiso,
            this.sModulo,
            this.sDescripcion});
            this.dgvPermisos.Location = new System.Drawing.Point(12, 44);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.ReadOnly = true;
            this.dgvPermisos.RowHeadersVisible = false;
            this.dgvPermisos.Size = new System.Drawing.Size(810, 269);
            this.dgvPermisos.TabIndex = 10;
            // 
            // pkPermiso
            // 
            this.pkPermiso.DataPropertyName = "pkPermiso";
            this.pkPermiso.FillWeight = 203.0457F;
            this.pkPermiso.HeaderText = "Codigo";
            this.pkPermiso.Name = "pkPermiso";
            this.pkPermiso.ReadOnly = true;
            // 
            // sModulo
            // 
            this.sModulo.DataPropertyName = "sModulo";
            this.sModulo.FillWeight = 65.65144F;
            this.sModulo.HeaderText = "Modulo";
            this.sModulo.Name = "sModulo";
            this.sModulo.ReadOnly = true;
            this.sModulo.Width = 150;
            // 
            // sDescripcion
            // 
            this.sDescripcion.DataPropertyName = "sDescripcion";
            this.sDescripcion.HeaderText = "Descripcion";
            this.sDescripcion.Name = "sDescripcion";
            this.sDescripcion.ReadOnly = true;
            this.sDescripcion.Width = 556;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(149, 319);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 30);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmMainPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 361);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoPermiso);
            this.Controls.Add(this.dgvPermisos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de permisos";
            this.Load += new System.EventHandler(this.frmMainPermisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoPermiso;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDescripcion;
    }
}