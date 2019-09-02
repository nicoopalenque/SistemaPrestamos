namespace Vistas
{
    partial class Frm_ListadoPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoPagos));
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagos = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.gbPago = new System.Windows.Forms.GroupBox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.gbPago.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPagos
            // 
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Location = new System.Drawing.Point(21, 22);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.Size = new System.Drawing.Size(623, 220);
            this.dgvPagos.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(662, 40);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(133, 23);
            this.cmbClientes.TabIndex = 3;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(659, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listar por Cliente:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(367, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Realizados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(220, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importe Total:";
            // 
            // txtPagos
            // 
            this.txtPagos.Location = new System.Drawing.Point(95, 21);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.ReadOnly = true;
            this.txtPagos.Size = new System.Drawing.Size(101, 22);
            this.txtPagos.TabIndex = 6;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(306, 21);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(100, 22);
            this.txtImporte.TabIndex = 7;
            // 
            // gbPago
            // 
            this.gbPago.BackColor = System.Drawing.Color.Transparent;
            this.gbPago.Controls.Add(this.label2);
            this.gbPago.Controls.Add(this.label3);
            this.gbPago.Controls.Add(this.txtImporte);
            this.gbPago.Controls.Add(this.txtPagos);
            this.gbPago.Location = new System.Drawing.Point(114, 248);
            this.gbPago.Name = "gbPago";
            this.gbPago.Size = new System.Drawing.Size(421, 55);
            this.gbPago.TabIndex = 8;
            this.gbPago.TabStop = false;
            this.gbPago.Text = "Pagos";
            // 
            // gbFecha
            // 
            this.gbFecha.BackColor = System.Drawing.Color.Transparent;
            this.gbFecha.Controls.Add(this.label4);
            this.gbFecha.Controls.Add(this.label5);
            this.gbFecha.Controls.Add(this.dtpFechaHasta);
            this.gbFecha.Controls.Add(this.dtpFechaDesde);
            this.gbFecha.Location = new System.Drawing.Point(662, 80);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(133, 125);
            this.gbFecha.TabIndex = 9;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Buscar Por Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(17, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(98, 22);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(15, 38);
            this.dtpFechaDesde.MaxDate = new System.DateTime(2019, 6, 10, 0, 0, 0, 0);
            this.dtpFechaDesde.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(98, 22);
            this.dtpFechaDesde.TabIndex = 4;
            this.dtpFechaDesde.Value = new System.DateTime(2019, 5, 23, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(662, 211);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 31);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Frm_ListadoPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources._5b5dfb4d1889f079c24604428036f98c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 355);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.gbPago);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListadoPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pagos";
            this.Load += new System.EventHandler(this.Frm_ListadoPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.gbPago.ResumeLayout(false);
            this.gbPago.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPagos;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.GroupBox gbPago;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
    }
}