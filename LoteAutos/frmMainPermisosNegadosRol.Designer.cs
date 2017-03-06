namespace LoteAutos
{
    partial class frmMainPermisosNegadosRol
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
            this.dgvPermisosNegadosRol = new System.Windows.Forms.DataGridView();
            this.pkPermisoNegadoRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevoPermiso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosNegadosRol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPermisosNegadosRol
            // 
            this.dgvPermisosNegadosRol.AllowUserToAddRows = false;
            this.dgvPermisosNegadosRol.AllowUserToDeleteRows = false;
            this.dgvPermisosNegadosRol.AllowUserToResizeColumns = false;
            this.dgvPermisosNegadosRol.AllowUserToResizeRows = false;
            this.dgvPermisosNegadosRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosNegadosRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPermisoNegadoRol,
            this.fkPermisos,
            this.fkRol});
            this.dgvPermisosNegadosRol.Location = new System.Drawing.Point(12, 12);
            this.dgvPermisosNegadosRol.Name = "dgvPermisosNegadosRol";
            this.dgvPermisosNegadosRol.ReadOnly = true;
            this.dgvPermisosNegadosRol.RowHeadersVisible = false;
            this.dgvPermisosNegadosRol.Size = new System.Drawing.Size(460, 251);
            this.dgvPermisosNegadosRol.TabIndex = 0;
            // 
            // pkPermisoNegadoRol
            // 
            this.pkPermisoNegadoRol.DataPropertyName = "pkPermisoNegadoRol";
            this.pkPermisoNegadoRol.HeaderText = "Codigo";
            this.pkPermisoNegadoRol.Name = "pkPermisoNegadoRol";
            this.pkPermisoNegadoRol.ReadOnly = true;
            // 
            // fkPermisos
            // 
            this.fkPermisos.DataPropertyName = "fkPermiso";
            this.fkPermisos.HeaderText = "Permisos";
            this.fkPermisos.Name = "fkPermisos";
            this.fkPermisos.ReadOnly = true;
            this.fkPermisos.Width = 180;
            // 
            // fkRol
            // 
            this.fkRol.DataPropertyName = "fkRol";
            this.fkRol.HeaderText = "Roles";
            this.fkRol.Name = "fkRol";
            this.fkRol.ReadOnly = true;
            this.fkRol.Width = 175;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(286, 269);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 30);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(149, 269);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 30);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevoPermiso
            // 
            this.btnNuevoPermiso.Location = new System.Drawing.Point(12, 269);
            this.btnNuevoPermiso.Name = "btnNuevoPermiso";
            this.btnNuevoPermiso.Size = new System.Drawing.Size(131, 30);
            this.btnNuevoPermiso.TabIndex = 16;
            this.btnNuevoPermiso.Text = "Agregar";
            this.btnNuevoPermiso.UseVisualStyleBackColor = true;
            this.btnNuevoPermiso.Click += new System.EventHandler(this.btnNuevoPermiso_Click);
            // 
            // frmMainPermisosNegadosRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevoPermiso);
            this.Controls.Add(this.dgvPermisosNegadosRol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainPermisosNegadosRol";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de permisos negados por rol";
            this.Load += new System.EventHandler(this.frmMainPermisosNegadosRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosNegadosRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisosNegadosRol;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPermisoNegadoRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkRol;
    }
}