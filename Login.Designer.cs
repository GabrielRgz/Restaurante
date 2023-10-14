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
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
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
            panel1.Controls.Add(rjTextBox2);
            panel1.Controls.Add(rjTextBox1);
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
            btnClose.MouseEnter += btnClose_MouseEnter_1;
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
            btnSalir.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
            btnLogin.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point);
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
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.FromArgb(255, 128, 0);
            rjTextBox2.BorderFocusColor = Color.Yellow;
            rjTextBox2.BorderRadius = 15;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(92, 362);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "                           Contraseña";
            rjTextBox2.Size = new Size(250, 31);
            rjTextBox2.TabIndex = 17;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.FromArgb(255, 128, 0);
            rjTextBox1.BorderFocusColor = Color.Yellow;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(92, 292);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "                   Nombre De usuario";
            rjTextBox1.Size = new Size(250, 31);
            rjTextBox1.TabIndex = 16;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            rjTextBox1._TextChanged += rjTextBox1__TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.FromArgb(255, 128, 0);
            lblPassword.Location = new Point(134, 329);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(163, 29);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.ForeColor = Color.FromArgb(255, 128, 0);
            lblUser.Location = new Point(159, 259);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(118, 29);
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
            lblnombre.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblnombre.ForeColor = Color.FromArgb(255, 128, 0);
            lblnombre.Location = new Point(42, 44);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(343, 29);
            lblnombre.TabIndex = 8;
            lblnombre.Text = "El crustaceo cascarudo";
            lblnombre.Click += lblnombre_Click_1;
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
            Load += Login_Load;
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
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJButton btnSalir;
        private CustomControls.RJControls.RJButton btnLogin;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Panel panel2;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
    }
}