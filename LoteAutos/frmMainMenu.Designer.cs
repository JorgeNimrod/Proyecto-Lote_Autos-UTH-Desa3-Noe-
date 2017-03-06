namespace LoteAutos
{
    partial class frmMainMenu
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
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnPermisosNegadosRol = new System.Windows.Forms.Button();
            this.gpbAdmin = new System.Windows.Forms.GroupBox();
            this.gpbOpcinoes = new System.Windows.Forms.GroupBox();
            this.btnAutomoviles = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnpropietarios = new System.Windows.Forms.Button();
            this.gpbAdmin.SuspendLayout();
            this.gpbOpcinoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Enabled = false;
            this.btnUsuarios.Location = new System.Drawing.Point(36, 44);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(115, 71);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Tag = "1";
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Enabled = false;
            this.btnRoles.Location = new System.Drawing.Point(157, 44);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(115, 71);
            this.btnRoles.TabIndex = 2;
            this.btnRoles.Tag = "2";
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.Enabled = false;
            this.btnPermisos.Location = new System.Drawing.Point(278, 44);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(115, 71);
            this.btnPermisos.TabIndex = 3;
            this.btnPermisos.Tag = "3";
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnPermisosNegadosRol
            // 
            this.btnPermisosNegadosRol.Enabled = false;
            this.btnPermisosNegadosRol.Location = new System.Drawing.Point(399, 44);
            this.btnPermisosNegadosRol.Name = "btnPermisosNegadosRol";
            this.btnPermisosNegadosRol.Size = new System.Drawing.Size(115, 71);
            this.btnPermisosNegadosRol.TabIndex = 4;
            this.btnPermisosNegadosRol.Tag = "4";
            this.btnPermisosNegadosRol.Text = "Negación de permisos";
            this.btnPermisosNegadosRol.UseVisualStyleBackColor = true;
            this.btnPermisosNegadosRol.Click += new System.EventHandler(this.btnPermisosNegadosRol_Click);
            // 
            // gpbAdmin
            // 
            this.gpbAdmin.Controls.Add(this.btnPermisosNegadosRol);
            this.gpbAdmin.Controls.Add(this.btnUsuarios);
            this.gpbAdmin.Controls.Add(this.btnPermisos);
            this.gpbAdmin.Controls.Add(this.btnRoles);
            this.gpbAdmin.Location = new System.Drawing.Point(12, 12);
            this.gpbAdmin.Name = "gpbAdmin";
            this.gpbAdmin.Size = new System.Drawing.Size(560, 148);
            this.gpbAdmin.TabIndex = 4;
            this.gpbAdmin.TabStop = false;
            this.gpbAdmin.Text = "Administrador";
            // 
            // gpbOpcinoes
            // 
            this.gpbOpcinoes.Controls.Add(this.btnAutomoviles);
            this.gpbOpcinoes.Controls.Add(this.btnVentas);
            this.gpbOpcinoes.Controls.Add(this.btnpropietarios);
            this.gpbOpcinoes.Location = new System.Drawing.Point(12, 166);
            this.gpbOpcinoes.Name = "gpbOpcinoes";
            this.gpbOpcinoes.Size = new System.Drawing.Size(560, 148);
            this.gpbOpcinoes.TabIndex = 5;
            this.gpbOpcinoes.TabStop = false;
            this.gpbOpcinoes.Text = "Operaciones";
            // 
            // btnAutomoviles
            // 
            this.btnAutomoviles.Enabled = false;
            this.btnAutomoviles.Location = new System.Drawing.Point(278, 44);
            this.btnAutomoviles.Name = "btnAutomoviles";
            this.btnAutomoviles.Size = new System.Drawing.Size(115, 71);
            this.btnAutomoviles.TabIndex = 7;
            this.btnAutomoviles.Tag = "7";
            this.btnAutomoviles.Text = "Automoviles";
            this.btnAutomoviles.UseVisualStyleBackColor = true;
            this.btnAutomoviles.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Enabled = false;
            this.btnVentas.Location = new System.Drawing.Point(36, 44);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(115, 71);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Tag = "5";
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnpropietarios
            // 
            this.btnpropietarios.Enabled = false;
            this.btnpropietarios.Location = new System.Drawing.Point(157, 44);
            this.btnpropietarios.Name = "btnpropietarios";
            this.btnpropietarios.Size = new System.Drawing.Size(115, 71);
            this.btnpropietarios.TabIndex = 6;
            this.btnpropietarios.Tag = "6";
            this.btnpropietarios.Text = "Propietarios";
            this.btnpropietarios.UseVisualStyleBackColor = true;
            this.btnpropietarios.Click += new System.EventHandler(this.btnpropietarios_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 324);
            this.Controls.Add(this.gpbOpcinoes);
            this.Controls.Add(this.gpbAdmin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Activated += new System.EventHandler(this.frmMainMenu_Activated);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.gpbAdmin.ResumeLayout(false);
            this.gpbOpcinoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button btnPermisosNegadosRol;
        private System.Windows.Forms.GroupBox gpbAdmin;
        private System.Windows.Forms.GroupBox gpbOpcinoes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnpropietarios;
        private System.Windows.Forms.Button btnAutomoviles;
    }
}