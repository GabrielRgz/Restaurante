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
            pbxUser = new PictureBox();
            lblusuario = new Label();
            btnCompras = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnprod = new Button();
            btnlogoInicio = new PictureBox();
            BarraTitulo = new Panel();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMenu = new PictureBox();
            panelContenedor = new Panel();
            btnCerrarSesion = new CustomControls.RJControls.RJButton();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.Black;
            MenuVertical.Controls.Add(lblcorreo);
            MenuVertical.Controls.Add(lbluser);
            MenuVertical.Controls.Add(pbxUser);
            MenuVertical.Controls.Add(lblusuario);
            MenuVertical.Controls.Add(btnCompras);
            MenuVertical.Controls.Add(btnClientes);
            MenuVertical.Controls.Add(btnVentas);
            MenuVertical.Controls.Add(btnprod);
            MenuVertical.Controls.Add(btnlogoInicio);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Margin = new Padding(4, 3, 4, 3);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 750);
            MenuVertical.TabIndex = 0;
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
            // pbxUser
            // 
            pbxUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pbxUser.Image = (Image)resources.GetObject("pbxUser.Image");
            pbxUser.Location = new Point(-1, 674);
            pbxUser.Margin = new Padding(4, 3, 4, 3);
            pbxUser.Name = "pbxUser";
            pbxUser.Size = new Size(82, 76);
            pbxUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUser.TabIndex = 15;
            pbxUser.TabStop = false;
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
            // btnCompras
            // 
            btnCompras.FlatAppearance.BorderSize = 0;
            btnCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCompras.FlatStyle = FlatStyle.Flat;
            btnCompras.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompras.ForeColor = Color.Orange;
            btnCompras.Image = (Image)resources.GetObject("btnCompras.Image");
            btnCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCompras.Location = new Point(0, 226);
            btnCompras.Margin = new Padding(4, 3, 4, 3);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(250, 46);
            btnCompras.TabIndex = 5;
            btnCompras.Text = "Compras";
            btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.Orange;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 180);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(250, 46);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.Orange;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 134);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 46);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
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
            btnprod.Location = new Point(0, 88);
            btnprod.Margin = new Padding(4, 3, 4, 3);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(250, 46);
            btnprod.TabIndex = 1;
            btnprod.Text = "Productos";
            btnprod.UseVisualStyleBackColor = true;
            btnprod.Click += btnprod_Click;
            // 
            // btnlogoInicio
            // 
            btnlogoInicio.Cursor = Cursors.Hand;
            btnlogoInicio.Dock = DockStyle.Top;
            btnlogoInicio.Image = (Image)resources.GetObject("btnlogoInicio.Image");
            btnlogoInicio.InitialImage = null;
            btnlogoInicio.Location = new Point(0, 0);
            btnlogoInicio.Margin = new Padding(4, 3, 4, 3);
            btnlogoInicio.Name = "btnlogoInicio";
            btnlogoInicio.Size = new Size(250, 88);
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
            btnRestaurar.Location = new Point(1221, 0);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 52);
            btnRestaurar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnRestaurar.TabIndex = 30;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            btnRestaurar.MouseEnter += btnRestaurar_MouseEnter;
            btnRestaurar.MouseLeave += btnRestaurar_MouseLeave;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1193, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(10, 0, 10, 0);
            btnMinimizar.Size = new Size(28, 52);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 29;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Dock = DockStyle.Right;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1221, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 52);
            btnMaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
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
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.ErrorImage = null;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.InitialImage = null;
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
            panelContenedor.Controls.Add(btnCerrarSesion);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 52);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1267, 698);
            panelContenedor.TabIndex = 2;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.FromArgb(255, 128, 0);
            btnCerrarSesion.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnCerrarSesion.BorderColor = Color.White;
            btnCerrarSesion.BorderRadius = 15;
            btnCerrarSesion.BorderSize = 1;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Unispace", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.Location = new Point(1114, 653);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(150, 40);
            btnCerrarSesion.TabIndex = 20;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextColor = Color.Black;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
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
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private PictureBox btnlogoInicio;
        private Panel BarraTitulo;
        private PictureBox btnMenu;
        private Panel panelContenedor;
        private Button btnprod;
        private Button btnCompras;
        private Button btnClientes;
        private Button btnVentas;
        private Label lblcorreo;
        private Label lbluser;
        private PictureBox pbxUser;
        private Label lblusuario;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private CustomControls.RJControls.RJButton btnCerrarSesion;
    }
}

