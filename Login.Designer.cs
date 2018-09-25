namespace SistemadeAbogados
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbllineausuari = new System.Windows.Forms.Label();
            this.lbllineacontraseña = new System.Windows.Forms.Label();
            this.tbusuario = new System.Windows.Forms.TextBox();
            this.tbcontraseña = new System.Windows.Forms.TextBox();
            this.tblogin = new System.Windows.Forms.Label();
            this.btningresar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.piccerrar = new System.Windows.Forms.PictureBox();
            this.picocultar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picocultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 291);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbllineausuari
            // 
            this.lbllineausuari.AutoSize = true;
            this.lbllineausuari.ForeColor = System.Drawing.Color.DimGray;
            this.lbllineausuari.Location = new System.Drawing.Point(261, 94);
            this.lbllineausuari.Name = "lbllineausuari";
            this.lbllineausuari.Size = new System.Drawing.Size(217, 13);
            this.lbllineausuari.TabIndex = 1;
            this.lbllineausuari.Text = "___________________________________";
            // 
            // lbllineacontraseña
            // 
            this.lbllineacontraseña.AutoSize = true;
            this.lbllineacontraseña.ForeColor = System.Drawing.Color.DimGray;
            this.lbllineacontraseña.Location = new System.Drawing.Point(261, 153);
            this.lbllineacontraseña.Name = "lbllineacontraseña";
            this.lbllineacontraseña.Size = new System.Drawing.Size(217, 13);
            this.lbllineacontraseña.TabIndex = 2;
            this.lbllineacontraseña.Text = "___________________________________";
            // 
            // tbusuario
            // 
            this.tbusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.tbusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbusuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusuario.ForeColor = System.Drawing.Color.DimGray;
            this.tbusuario.Location = new System.Drawing.Point(264, 87);
            this.tbusuario.Name = "tbusuario";
            this.tbusuario.Size = new System.Drawing.Size(214, 19);
            this.tbusuario.TabIndex = 1;
            this.tbusuario.Text = "Usuario";
            this.tbusuario.TextChanged += new System.EventHandler(this.tbusuario_TextChanged);
            this.tbusuario.Enter += new System.EventHandler(this.tbusuario_Enter);
            this.tbusuario.Leave += new System.EventHandler(this.tbusuario_Leave);
            // 
            // tbcontraseña
            // 
            this.tbcontraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.tbcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcontraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontraseña.ForeColor = System.Drawing.Color.DimGray;
            this.tbcontraseña.Location = new System.Drawing.Point(264, 145);
            this.tbcontraseña.Name = "tbcontraseña";
            this.tbcontraseña.Size = new System.Drawing.Size(214, 19);
            this.tbcontraseña.TabIndex = 2;
            this.tbcontraseña.Text = "Contraseña";
            this.tbcontraseña.Enter += new System.EventHandler(this.tbcontraseña_Enter);
            this.tbcontraseña.Leave += new System.EventHandler(this.tbcontraseña_Leave);
            // 
            // tblogin
            // 
            this.tblogin.AutoSize = true;
            this.tblogin.Font = new System.Drawing.Font("Century Gothic", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblogin.ForeColor = System.Drawing.Color.DimGray;
            this.tblogin.Location = new System.Drawing.Point(338, 35);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(82, 25);
            this.tblogin.TabIndex = 5;
            this.tblogin.Text = "LOGIN";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btningresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.ForeColor = System.Drawing.Color.LightGray;
            this.btningresar.Location = new System.Drawing.Point(286, 191);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(167, 40);
            this.btningresar.TabIndex = 3;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(296, 251);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ha olvidado su contraseña?";
            // 
            // piccerrar
            // 
            this.piccerrar.Image = ((System.Drawing.Image)(resources.GetObject("piccerrar.Image")));
            this.piccerrar.Location = new System.Drawing.Point(527, 12);
            this.piccerrar.Name = "piccerrar";
            this.piccerrar.Size = new System.Drawing.Size(25, 25);
            this.piccerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piccerrar.TabIndex = 8;
            this.piccerrar.TabStop = false;
            this.piccerrar.Click += new System.EventHandler(this.piccerrar_Click);
            // 
            // picocultar
            // 
            this.picocultar.Image = ((System.Drawing.Image)(resources.GetObject("picocultar.Image")));
            this.picocultar.Location = new System.Drawing.Point(496, 12);
            this.picocultar.Name = "picocultar";
            this.picocultar.Size = new System.Drawing.Size(25, 25);
            this.picocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picocultar.TabIndex = 9;
            this.picocultar.TabStop = false;
            this.picocultar.Click += new System.EventHandler(this.picocultar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(564, 291);
            this.Controls.Add(this.picocultar);
            this.Controls.Add(this.piccerrar);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.tbcontraseña);
            this.Controls.Add(this.tbusuario);
            this.Controls.Add(this.lbllineacontraseña);
            this.Controls.Add(this.lbllineausuari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picocultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbllineausuari;
        private System.Windows.Forms.Label lbllineacontraseña;
        private System.Windows.Forms.TextBox tbusuario;
        private System.Windows.Forms.TextBox tbcontraseña;
        private System.Windows.Forms.Label tblogin;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox piccerrar;
        private System.Windows.Forms.PictureBox picocultar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}