namespace Vistas
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPréstamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePréstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            this.gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            this.gestiónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            this.gestiónDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeClientesToolStripMenuItem_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarPréstamoToolStripMenuItem,
            this.listadoDePréstamosToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.registrarPagosToolStripMenuItem,
            this.listadoDePagosToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // realizarPréstamoToolStripMenuItem
            // 
            this.realizarPréstamoToolStripMenuItem.Name = "realizarPréstamoToolStripMenuItem";
            this.realizarPréstamoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.realizarPréstamoToolStripMenuItem.Text = "Realizar Préstamo";
            this.realizarPréstamoToolStripMenuItem.Click += new System.EventHandler(this.realizarPréstamoToolStripMenuItem_Click);
            // 
            // listadoDePréstamosToolStripMenuItem
            // 
            this.listadoDePréstamosToolStripMenuItem.Name = "listadoDePréstamosToolStripMenuItem";
            this.listadoDePréstamosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDePréstamosToolStripMenuItem.Text = "Listado de Préstamos";
            this.listadoDePréstamosToolStripMenuItem.Click += new System.EventHandler(this.listadoDePréstamosToolStripMenuItem_Click);
            // 
            // destinosToolStripMenuItem
            // 
            this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            this.destinosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.destinosToolStripMenuItem.Text = "Destinos";
            this.destinosToolStripMenuItem.Click += new System.EventHandler(this.destinosToolStripMenuItem_Click);
            // 
            // registrarPagosToolStripMenuItem
            // 
            this.registrarPagosToolStripMenuItem.Name = "registrarPagosToolStripMenuItem";
            this.registrarPagosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.registrarPagosToolStripMenuItem.Text = "Registrar Pago";
            this.registrarPagosToolStripMenuItem.Click += new System.EventHandler(this.registrarPagosToolStripMenuItem_Click);
            // 
            // listadoDePagosToolStripMenuItem
            // 
            this.listadoDePagosToolStripMenuItem.Name = "listadoDePagosToolStripMenuItem";
            this.listadoDePagosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDePagosToolStripMenuItem.Text = "Listado de Pagos";
            this.listadoDePagosToolStripMenuItem.Click += new System.EventHandler(this.listadoDePagosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(12, 20);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(269, 213);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarPréstamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePréstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePagosToolStripMenuItem;
    }
}