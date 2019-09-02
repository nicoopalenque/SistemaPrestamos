namespace Vistas
{
    partial class Frm_ListadoPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListadoPrestamos));
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtorgados = new System.Windows.Forms.TextBox();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCancelados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnulados = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbPrestamos = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNroPrestamo = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.gbFecha.SuspendLayout();
            this.gbPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(24, 61);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.Size = new System.Drawing.Size(637, 216);
            this.dgvPrestamos.TabIndex = 0;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(308, 347);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 32);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(676, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Listar Por:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(679, 79);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(133, 23);
            this.cmbDestino.TabIndex = 3;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
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
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(17, 88);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(98, 22);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // gbFecha
            // 
            this.gbFecha.BackColor = System.Drawing.Color.Transparent;
            this.gbFecha.Controls.Add(this.label3);
            this.gbFecha.Controls.Add(this.label2);
            this.gbFecha.Controls.Add(this.dtpFechaHasta);
            this.gbFecha.Controls.Add(this.dtpFechaDesde);
            this.gbFecha.Location = new System.Drawing.Point(679, 115);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(133, 125);
            this.gbFecha.TabIndex = 6;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Buscar Por Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(679, 246);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 31);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(42, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Otorgados:";
            // 
            // txtOtorgados
            // 
            this.txtOtorgados.Location = new System.Drawing.Point(114, 15);
            this.txtOtorgados.Name = "txtOtorgados";
            this.txtOtorgados.ReadOnly = true;
            this.txtOtorgados.Size = new System.Drawing.Size(28, 22);
            this.txtOtorgados.TabIndex = 9;
            // 
            // txtPendientes
            // 
            this.txtPendientes.Location = new System.Drawing.Point(241, 15);
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.ReadOnly = true;
            this.txtPendientes.Size = new System.Drawing.Size(28, 22);
            this.txtPendientes.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(168, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pendientes:";
            // 
            // txtCancelados
            // 
            this.txtCancelados.Location = new System.Drawing.Point(371, 15);
            this.txtCancelados.Name = "txtCancelados";
            this.txtCancelados.ReadOnly = true;
            this.txtCancelados.Size = new System.Drawing.Size(28, 22);
            this.txtCancelados.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(295, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cancelados:";
            // 
            // txtAnulados
            // 
            this.txtAnulados.Location = new System.Drawing.Point(498, 15);
            this.txtAnulados.Name = "txtAnulados";
            this.txtAnulados.ReadOnly = true;
            this.txtAnulados.Size = new System.Drawing.Size(28, 22);
            this.txtAnulados.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(432, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Anulados:";
            // 
            // gbPrestamos
            // 
            this.gbPrestamos.BackColor = System.Drawing.Color.Transparent;
            this.gbPrestamos.Controls.Add(this.txtAnulados);
            this.gbPrestamos.Controls.Add(this.label7);
            this.gbPrestamos.Controls.Add(this.txtCancelados);
            this.gbPrestamos.Controls.Add(this.label6);
            this.gbPrestamos.Controls.Add(this.txtPendientes);
            this.gbPrestamos.Controls.Add(this.label5);
            this.gbPrestamos.Controls.Add(this.txtOtorgados);
            this.gbPrestamos.Controls.Add(this.label4);
            this.gbPrestamos.Location = new System.Drawing.Point(67, 283);
            this.gbPrestamos.Name = "gbPrestamos";
            this.gbPrestamos.Size = new System.Drawing.Size(546, 48);
            this.gbPrestamos.TabIndex = 16;
            this.gbPrestamos.TabStop = false;
            this.gbPrestamos.Text = "Préstamos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(139, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nro. de Préstamo:";
            // 
            // txtNroPrestamo
            // 
            this.txtNroPrestamo.Location = new System.Drawing.Point(238, 33);
            this.txtNroPrestamo.Name = "txtNroPrestamo";
            this.txtNroPrestamo.Size = new System.Drawing.Size(100, 22);
            this.txtNroPrestamo.TabIndex = 18;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(355, 33);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(107, 23);
            this.btnAnular.TabIndex = 19;
            this.btnAnular.Text = "Anular Préstamo";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(468, 33);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(123, 23);
            this.btnDetalle.TabIndex = 22;
            this.btnDetalle.Text = "Detalle de Prestamo";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // Frm_ListadoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources._5b5dfb4d1889f079c24604428036f98c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 392);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtNroPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbPrestamos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPrestamos);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ListadoPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Préstamos";
            this.Load += new System.EventHandler(this.Frm_ListaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbPrestamos.ResumeLayout(false);
            this.gbPrestamos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOtorgados;
        private System.Windows.Forms.TextBox txtPendientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCancelados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnulados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbPrestamos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNroPrestamo;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnDetalle;
    }
}