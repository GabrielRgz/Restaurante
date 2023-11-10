namespace Restaurante
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            btnSalir = new CustomControls.RJControls.RJButton();
            btnLogin = new CustomControls.RJControls.RJButton();
            txbContrasena = new CustomControls.RJControls.RJTextBox();
            txbUsuario = new CustomControls.RJControls.RJTextBox();
            lblPassword = new Label();
            lblUser = new Label();
            pictureBox1 = new PictureBox();
            lblnombre = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txbContrasena);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUser);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblnombre);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(421, 498);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 33, 33);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(421, 30);
            panel2.TabIndex = 20;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(363, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(10, 0, 10, 0);
            btnMinimize.Size = new Size(32, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimize.TabIndex = 22;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(395, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 30);
            btnClose.SizeMode = PictureBoxSizeMode.CenterImage;
            btnClose.TabIndex = 21;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseEnter += btnClose_MouseEnter;
            btnClose.MouseLeave += btnClose_MouseLeave;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 128, 0);
            btnSalir.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnSalir.BorderColor = Color.White;
            btnSalir.BorderRadius = 15;
            btnSalir.BorderSize = 1;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(235, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 40);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.TextColor = Color.Black;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnLogin.BorderColor = Color.White;
            btnLogin.BorderRadius = 15;
            btnLogin.BorderSize = 1;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.WindowText;
            btnLogin.Location = new Point(42, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.TextColor = SystemColors.WindowText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txbContrasena
            // 
            txbContrasena.BackColor = SystemColors.Window;
            txbContrasena.BorderColor = Color.FromArgb(255, 128, 0);
            txbContrasena.BorderFocusColor = Color.Yellow;
            txbContrasena.BorderRadius = 15;
            txbContrasena.BorderSize = 2;
            txbContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            txbContrasena.Location = new Point(92, 337);
            txbContrasena.Margin = new Padding(4);
            txbContrasena.Multiline = false;
            txbContrasena.Name = "txbContrasena";
            txbContrasena.Padding = new Padding(10, 7, 10, 7);
            txbContrasena.PasswordChar = false;
            txbContrasena.PlaceholderColor = Color.DarkGray;
            txbContrasena.PlaceholderText = "                           Contraseña";
            txbContrasena.Size = new Size(250, 31);
            txbContrasena.TabIndex = 17;
            txbContrasena.Texts = "";
            txbContrasena.UnderlinedStyle = false;
            // 
            // txbUsuario
            // 
            txbUsuario.BackColor = SystemColors.Window;
            txbUsuario.BorderColor = Color.FromArgb(255, 128, 0);
            txbUsuario.BorderFocusColor = Color.Yellow;
            txbUsuario.BorderRadius = 15;
            txbUsuario.BorderSize = 2;
            txbUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txbUsuario.Location = new Point(92, 267);
            txbUsuario.Margin = new Padding(4);
            txbUsuario.Multiline = false;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Padding = new Padding(10, 7, 10, 7);
            txbUsuario.PasswordChar = false;
            txbUsuario.PlaceholderColor = Color.DarkGray;
            txbUsuario.PlaceholderText = "                   Nombre De usuario";
            txbUsuario.Size = new Size(250, 31);
            txbUsuario.TabIndex = 16;
            txbUsuario.Texts = "";
            txbUsuario.UnderlinedStyle = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(255, 128, 0);
            lblPassword.Location = new Point(134, 304);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(146, 29);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(255, 128, 0);
            lblUser.Location = new Point(159, 234);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(103, 29);
            lblUser.TabIndex = 10;
            lblUser.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.ForeColor = Color.FromArgb(255, 128, 0);
            lblnombre.Location = new Point(134, 44);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(144, 29);
            lblnombre.TabIndex = 8;
            lblnombre.Text = "Bienvenido";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(421, 498);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPassword;
        private Label lblUser;
        private PictureBox pictureBox1;
        private Label lblnombre;
        private CustomControls.RJControls.RJTextBox txbUsuario;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnLogin;
        private CustomControls.RJControls.RJTextBox txbContrasena;
        private Panel panel2;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
    }
}