namespace GUI_V_2
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            MenuVertical = new Panel();
            lblcorreo = new Label();
            lbluser = new Label();
            pictureBox2 = new PictureBox();
            lblusuario = new Label();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnprod = new Button();
            btnlogoInicio = new PictureBox();
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMenu = new PictureBox();
            panelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.Black;
            MenuVertical.Controls.Add(lblcorreo);
            MenuVertical.Controls.Add(lbluser);
            MenuVertical.Controls.Add(pictureBox2);
            MenuVertical.Controls.Add(lblusuario);
            MenuVertical.Controls.Add(button5);
            MenuVertical.Controls.Add(button3);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(btnprod);
            MenuVertical.Controls.Add(btnlogoInicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 3, 4, 3);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 750);
            MenuVertical.TabIndex = 0;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // lblcorreo
            // 
            lblcorreo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblcorreo.AutoSize = true;
            lblcorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcorreo.ForeColor = Color.White;
            lblcorreo.Location = new Point(84, 728);
            lblcorreo.Margin = new Padding(4, 0, 4, 0);
            lblcorreo.Name = "lblcorreo";
            lblcorreo.Size = new Size(53, 17);
            lblcorreo.TabIndex = 17;
            lblcorreo.Text = "Correo";
            // 
            // lbluser
            // 
            lbluser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbluser.ForeColor = Color.White;
            lbluser.Location = new Point(84, 707);
            lbluser.Margin = new Padding(4, 0, 4, 0);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(54, 17);
            lbluser.TabIndex = 16;
            lbluser.Text = "Usuario";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 669);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // lblusuario
            // 
            lblusuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblusuario.ForeColor = Color.White;
            lblusuario.Location = new Point(84, 688);
            lblusuario.Margin = new Padding(4, 0, 4, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(50, 17);
            lblusuario.TabIndex = 14;
            lblusuario.Text = "Cargo";
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Orange;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1, 257);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(292, 46);
            button5.TabIndex = 5;
            button5.Text = "Compras";
            button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Orange;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1, 205);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(292, 46);
            button3.TabIndex = 3;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Orange;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1, 153);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(292, 46);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnprod
            // 
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnprod.ForeColor = Color.Orange;
            btnprod.Image = (Image)resources.GetObject("btnprod.Image");
            btnprod.ImageAlign = ContentAlignment.MiddleLeft;
            btnprod.Location = new Point(4, 101);
            btnprod.Margin = new Padding(4, 3, 4, 3);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(292, 46);
            btnprod.TabIndex = 1;
            btnprod.Text = "Productos";
            btnprod.UseVisualStyleBackColor = true;
            btnprod.Click += btnprod_Click;
            // 
            // btnlogoInicio
            // 
            btnlogoInicio.Cursor = Cursors.Hand;
            btnlogoInicio.Image = (Image)resources.GetObject("btnlogoInicio.Image");
            btnlogoInicio.Location = new Point(10, 3);
            btnlogoInicio.Margin = new Padding(4, 3, 4, 3);
            btnlogoInicio.Name = "btnlogoInicio";
            btnlogoInicio.Size = new Size(232, 88);
            btnlogoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnlogoInicio.TabIndex = 0;
            btnlogoInicio.TabStop = false;
            btnlogoInicio.Click += btnlogoInicio_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(39, 39, 39);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(btnMenu);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Margin = new Padding(4, 3, 4, 3);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1267, 52);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1215, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 22);
            btnRestaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestaurar.TabIndex = 30;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            btnRestaurar.MouseEnter += btnRestaurar_MouseEnter;
            btnRestaurar.MouseLeave += btnRestaurar_MouseLeave;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1187, -3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(10, 0, 10, 0);
            btnMinimizar.Size = new Size(22, 52);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 29;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1215, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 22);
            btnMaximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximizar.TabIndex = 28;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            btnMaximizar.MouseEnter += btnMaximizar_MouseEnter;
            btnMaximizar.MouseLeave += btnMaximizar_MouseLeave;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1241, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 52);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            btnCerrar.Click += iconcerrar_Click_1;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(9, 7);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(41, 40);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(33, 33, 33);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 52);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1267, 698);
            panelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 750);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Principal";
            Text = "Form1";
            Load += Form1_Load;
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private PictureBox btnlogoInicio;
        private Panel BarraTitulo;
        private PictureBox btnMenu;
        private Panel panelContenedor;
        private Button btnprod;
        private Button button5;
        private Button button3;
        private Button button2;
        private Label lblcorreo;
        private Label lbluser;
        private PictureBox pictureBox2;
        private Label lblusuario;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private PictureBox pictureBox1;
    }
}

