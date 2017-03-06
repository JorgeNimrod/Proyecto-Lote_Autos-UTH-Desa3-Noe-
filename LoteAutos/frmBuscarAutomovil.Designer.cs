namespace LoteAutos
{
    partial class frmBuscarAutomovil
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
            this.dgvAutomoviles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pkPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).BeginInit();
            this.SuspendLayout();
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
            this.sNoSerie,
            this.sMarca,
            this.sModelo,
            this.iAño,
            this.sNoPlaca,
            this.sNacionalidad,
            this.dPrecio});
            this.dgvAutomoviles.Location = new System.Drawing.Point(12, 45);
            this.dgvAutomoviles.Name = "dgvAutomoviles";
            this.dgvAutomoviles.ReadOnly = true;
            this.dgvAutomoviles.RowHeadersVisible = false;
            this.dgvAutomoviles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutomoviles.Size = new System.Drawing.Size(664, 254);
            this.dgvAutomoviles.TabIndex = 11;
            this.dgvAutomoviles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutomoviles_CellDoubleClick);
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
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(81, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(595, 26);
            this.txtBuscar.TabIndex = 13;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            this.sModelo.Width = 80;
            // 
            // iAño
            // 
            this.iAño.DataPropertyName = "iAño";
            this.iAño.HeaderText = "Año";
            this.iAño.Name = "iAño";
            this.iAño.ReadOnly = true;
            this.iAño.Width = 80;
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
            // frmBuscarAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 311);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAutomoviles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarAutomovil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar automovil";
            this.Load += new System.EventHandler(this.frmBuscarAutomovil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomoviles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutomoviles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoPlaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrecio;
    }
}