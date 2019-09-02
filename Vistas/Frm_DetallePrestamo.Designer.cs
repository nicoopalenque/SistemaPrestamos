namespace Vistas
{
    partial class Frm_DetallePrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDetallesPrestamo = new System.Windows.Forms.DataGridView();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNPrestamo = new System.Windows.Forms.TextBox();
            this.txtImportePago = new System.Windows.Forms.TextBox();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.txtPagadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImportePendiente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCuotas = new System.Windows.Forms.GroupBox();
            this.gbImportes = new System.Windows.Forms.GroupBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPrestamo)).BeginInit();
            this.gbCuotas.SuspendLayout();
            this.gbImportes.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(49, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(49, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nro. de Préstamo:";
            // 
            // dgvDetallesPrestamo
            // 
            this.dgvDetallesPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPrestamo.Location = new System.Drawing.Point(46, 181);
            this.dgvDetallesPrestamo.Name = "dgvDetallesPrestamo";
            this.dgvDetallesPrestamo.Size = new System.Drawing.Size(437, 162);
            this.dgvDetallesPrestamo.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(176, 88);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(100, 24);
            this.txtDNI.TabIndex = 7;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(176, 118);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(100, 24);
            this.txtCliente.TabIndex = 8;
            // 
            // txtNPrestamo
            // 
            this.txtNPrestamo.Location = new System.Drawing.Point(176, 147);
            this.txtNPrestamo.Name = "txtNPrestamo";
            this.txtNPrestamo.ReadOnly = true;
            this.txtNPrestamo.Size = new System.Drawing.Size(100, 24);
            this.txtNPrestamo.TabIndex = 9;
            // 
            // txtImportePago
            // 
            this.txtImportePago.Location = new System.Drawing.Point(86, 23);
            this.txtImportePago.Name = "txtImportePago";
            this.txtImportePago.ReadOnly = true;
            this.txtImportePago.Size = new System.Drawing.Size(97, 24);
            this.txtImportePago.TabIndex = 15;
            // 
            // txtPendientes
            // 
            this.txtPendientes.Location = new System.Drawing.Point(98, 43);
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.ReadOnly = true;
            this.txtPendientes.Size = new System.Drawing.Size(45, 24);
            this.txtPendientes.TabIndex = 14;
            // 
            // txtPagadas
            // 
            this.txtPagadas.Location = new System.Drawing.Point(98, 17);
            this.txtPagadas.Name = "txtPagadas";
            this.txtPagadas.ReadOnly = true;
            this.txtPagadas.Size = new System.Drawing.Size(45, 24);
            this.txtPagadas.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pagado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(14, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pendientes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pagadas:";
            // 
            // txtImportePendiente
            // 
            this.txtImportePendiente.Location = new System.Drawing.Point(86, 49);
            this.txtImportePendiente.Name = "txtImportePendiente";
            this.txtImportePendiente.ReadOnly = true;
            this.txtImportePendiente.Size = new System.Drawing.Size(97, 24);
            this.txtImportePendiente.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pendiente:";
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(320, 116);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 27);
            this.btnVer.TabIndex = 18;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(343, 23);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(72, 24);
            this.txtPrestamo.TabIndex = 19;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(75, 22);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(121, 25);
            this.cmbCliente.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(216, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Nro. de Préstamo:";
            // 
            // gbCuotas
            // 
            this.gbCuotas.BackColor = System.Drawing.Color.Transparent;
            this.gbCuotas.Controls.Add(this.txtPagadas);
            this.gbCuotas.Controls.Add(this.txtPendientes);
            this.gbCuotas.Controls.Add(this.label6);
            this.gbCuotas.Controls.Add(this.label4);
            this.gbCuotas.Location = new System.Drawing.Point(51, 349);
            this.gbCuotas.Name = "gbCuotas";
            this.gbCuotas.Size = new System.Drawing.Size(164, 84);
            this.gbCuotas.TabIndex = 23;
            this.gbCuotas.TabStop = false;
            this.gbCuotas.Text = "Cuotas:";
            // 
            // gbImportes
            // 
            this.gbImportes.BackColor = System.Drawing.Color.Transparent;
            this.gbImportes.Controls.Add(this.txtImportePago);
            this.gbImportes.Controls.Add(this.label2);
            this.gbImportes.Controls.Add(this.label7);
            this.gbImportes.Controls.Add(this.txtImportePendiente);
            this.gbImportes.Location = new System.Drawing.Point(281, 349);
            this.gbImportes.Name = "gbImportes";
            this.gbImportes.Size = new System.Drawing.Size(202, 84);
            this.gbImportes.TabIndex = 24;
            this.gbImportes.TabStop = false;
            this.gbImportes.Text = "Importes:";
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Transparent;
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.cmbCliente);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtPrestamo);
            this.gbDatos.Location = new System.Drawing.Point(46, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(437, 70);
            this.gbDatos.TabIndex = 25;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(444, 439);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 27);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Frm_DetallePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources._5b5dfb4d1889f079c24604428036f98c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 475);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbImportes);
            this.Controls.Add(this.gbCuotas);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtNPrestamo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.dgvDetallesPrestamo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_DetallePrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles de Préstamo";
            this.Load += new System.EventHandler(this.Frm_DetallePrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPrestamo)).EndInit();
            this.gbCuotas.ResumeLayout(false);
            this.gbCuotas.PerformLayout();
            this.gbImportes.ResumeLayout(false);
            this.gbImportes.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetallesPrestamo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNPrestamo;
        private System.Windows.Forms.TextBox txtImportePago;
        private System.Windows.Forms.TextBox txtPendientes;
        private System.Windows.Forms.TextBox txtPagadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImportePendiente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbCuotas;
        private System.Windows.Forms.GroupBox gbImportes;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnCerrar;
      


    }
}