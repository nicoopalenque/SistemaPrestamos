namespace Vistas
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.imgUsers = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUsers
            // 
            this.imgUsers.BackColor = System.Drawing.Color.Transparent;
            this.imgUsers.Image = global::Vistas.Properties.Resources.group_60px;
            this.imgUsers.Location = new System.Drawing.Point(76, 14);
            this.imgUsers.Name = "imgUsers";
            this.imgUsers.Size = new System.Drawing.Size(62, 53);
            this.imgUsers.TabIndex = 8;
            this.imgUsers.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIngresar.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(23, 184);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(173, 27);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_MouseHover);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsuario.HideSelection = false;
            this.txtUsuario.Location = new System.Drawing.Point(23, 98);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(146, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContraseña.HideSelection = false;
            this.txtContraseña.Location = new System.Drawing.Point(23, 143);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(146, 22);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.Tag = "";
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.Transparent;
            this.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUser.Image = global::Vistas.Properties.Resources.user_24px;
            this.imgUser.Location = new System.Drawing.Point(170, 98);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(26, 22);
            this.imgUser.TabIndex = 6;
            this.imgUser.TabStop = false;
            // 
            // imgPassword
            // 
            this.imgPassword.BackColor = System.Drawing.Color.Transparent;
            this.imgPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPassword.Image = global::Vistas.Properties.Resources.password_24px;
            this.imgPassword.Location = new System.Drawing.Point(170, 143);
            this.imgPassword.Name = "imgPassword";
            this.imgPassword.Size = new System.Drawing.Size(26, 22);
            this.imgPassword.TabIndex = 7;
            this.imgPassword.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vistas.Properties.Resources._5b5dfb4d1889f079c24604428036f98c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(220, 242);
            this.Controls.Add(this.imgUsers);
            this.Controls.Add(this.imgPassword);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUsers;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgPassword;
    }
}