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
            panelMenu = new Panel();
            btnUsuarios = new Button();
            btnEvaluacion = new Button();
            btnTema = new Button();
            btnCerrarSesion = new Button();
            lblcorreo = new Label();
            lbluser = new Label();
            pbxUser = new PictureBox();
            lblusuario = new Label();
            btnPuntoVenta = new Button();
            btnClientes = new Button();
            btnVentas = new Button();
            btnprod = new Button();
            btnlogoInicio = new PictureBox();
            BarraTitulo = new Panel();
            btnMenu = new PictureBox();
            btnMinimizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            lblTitulo = new Label();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Black;
            panelMenu.Controls.Add(btnUsuarios);
            panelMenu.Controls.Add(btnEvaluacion);
            panelMenu.Controls.Add(btnTema);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(lblcorreo);
            panelMenu.Controls.Add(lbluser);
            panelMenu.Controls.Add(pbxUser);
            panelMenu.Controls.Add(lblusuario);
            panelMenu.Controls.Add(btnPuntoVenta);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(btnprod);
            panelMenu.Controls.Add(btnlogoInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 750);
            panelMenu.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsuarios.ForeColor = Color.Orange;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 294);
            btnUsuarios.Margin = new Padding(4, 3, 4, 3);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(250, 46);
            btnUsuarios.TabIndex = 21;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnEvaluacion
            // 
            btnEvaluacion.FlatAppearance.BorderSize = 0;
            btnEvaluacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnEvaluacion.FlatStyle = FlatStyle.Flat;
            btnEvaluacion.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnEvaluacion.ForeColor = Color.Orange;
            btnEvaluacion.Image = (Image)resources.GetObject("btnEvaluacion.Image");
            btnEvaluacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnEvaluacion.Location = new Point(0, 190);
            btnEvaluacion.Margin = new Padding(4, 3, 4, 3);
            btnEvaluacion.Name = "btnEvaluacion";
            btnEvaluacion.Size = new Size(250, 46);
            btnEvaluacion.TabIndex = 20;
            btnEvaluacion.Text = "   Calificar";
            btnEvaluacion.UseVisualStyleBackColor = true;
            btnEvaluacion.Click += btnEvaluacion_Click;
            // 
            // btnTema
            // 
            btnTema.FlatAppearance.BorderSize = 0;
            btnTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnTema.FlatStyle = FlatStyle.Flat;
            btnTema.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnTema.ForeColor = Color.Orange;
            btnTema.ImageAlign = ContentAlignment.MiddleLeft;
            btnTema.Location = new Point(0, 560);
            btnTema.Margin = new Padding(4, 3, 4, 3);
            btnTema.Name = "btnTema";
            btnTema.Size = new Size(250, 56);
            btnTema.TabIndex = 19;
            btnTema.Text = "Tema";
            btnTema.UseVisualStyleBackColor = true;
            btnTema.Click += btnTema_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Orange;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 704);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 46);
            btnCerrarSesion.TabIndex = 18;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            btnCerrarSesion.MouseEnter += btnCerrarSesion_MouseEnter;
            btnCerrarSesion.MouseLeave += btnCerrarSesion_MouseLeave;
            // 
            // lblcorreo
            // 
            lblcorreo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblcorreo.AutoSize = true;
            lblcorreo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblcorreo.ForeColor = Color.White;
            lblcorreo.Location = new Point(90, 678);
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
            lbluser.Location = new Point(90, 657);
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
            pbxUser.Location = new Point(0, 622);
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
            lblusuario.Location = new Point(90, 640);
            lblusuario.Margin = new Padding(4, 0, 4, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(58, 17);
            lblusuario.TabIndex = 14;
            lblusuario.Text = "  Cargo";
            // 
            // btnPuntoVenta
            // 
            btnPuntoVenta.FlatAppearance.BorderSize = 0;
            btnPuntoVenta.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnPuntoVenta.FlatStyle = FlatStyle.Flat;
            btnPuntoVenta.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnPuntoVenta.ForeColor = Color.Orange;
            btnPuntoVenta.Image = (Image)resources.GetObject("btnPuntoVenta.Image");
            btnPuntoVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnPuntoVenta.Location = new Point(0, 86);
            btnPuntoVenta.Margin = new Padding(4, 3, 4, 3);
            btnPuntoVenta.Name = "btnPuntoVenta";
            btnPuntoVenta.Size = new Size(283, 46);
            btnPuntoVenta.TabIndex = 5;
            btnPuntoVenta.Text = "Punto de venta";
            btnPuntoVenta.UseVisualStyleBackColor = true;
            btnPuntoVenta.Click += btnCompras_Click;
            // 
            // btnClientes
            // 
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnClientes.ForeColor = Color.Orange;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(4, 242);
            btnClientes.Margin = new Padding(4, 3, 4, 3);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(250, 46);
            btnClientes.TabIndex = 3;
            btnClientes.Text = "  Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVentas
            // 
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.Orange;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 138);
            btnVentas.Margin = new Padding(4, 3, 4, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 46);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "  Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnprod
            // 
            btnprod.FlatAppearance.BorderSize = 0;
            btnprod.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnprod.FlatStyle = FlatStyle.Flat;
            btnprod.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnprod.ForeColor = Color.Orange;
            btnprod.Image = (Image)resources.GetObject("btnprod.Image");
            btnprod.ImageAlign = ContentAlignment.MiddleLeft;
            btnprod.Location = new Point(0, 346);
            btnprod.Margin = new Padding(4, 3, 4, 3);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(250, 46);
            btnprod.TabIndex = 1;
            btnprod.Text = "    Productos";
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
            btnlogoInicio.Size = new Size(250, 70);
            btnlogoInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnlogoInicio.TabIndex = 0;
            btnlogoInicio.TabStop = false;
            btnlogoInicio.Click += btnlogoInicio_Click;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.Black;
            BarraTitulo.Controls.Add(btnMenu);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnRestaurar);
            BarraTitulo.Controls.Add(btnMaximizar);
            BarraTitulo.Controls.Add(btnCerrar);
            BarraTitulo.Controls.Add(lblTitulo);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Margin = new Padding(4, 3, 4, 3);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1136, 52);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.ErrorImage = null;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.InitialImage = null;
            btnMenu.Location = new Point(21, 0);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(45, 52);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 0;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Dock = DockStyle.Right;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1062, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(10, 0, 10, 0);
            btnMinimizar.Size = new Size(28, 52);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 31;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            btnMinimizar.MouseEnter += btnMinimizar_MouseEnter;
            btnMinimizar.MouseLeave += btnMinimizar_MouseLeave;
            // 
            // btnRestaurar
            // 
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
            // btnMaximizar
            // 
            btnMaximizar.Dock = DockStyle.Right;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1090, 0);
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
            btnCerrar.Location = new Point(1110, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 52);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 23;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(357, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 6, 0, 0);
            lblTitulo.Size = new Size(400, 52);
            lblTitulo.TabIndex = 33;
            lblTitulo.Text = "-- MOJODOJO EATS --";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.MouseDown += lblTitulo_MouseDown;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(33, 33, 33);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(250, 52);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1136, 698);
            panelContenedor.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 750);
            Controls.Add(panelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Principal";
            Text = "Form1";
            Load += Principal_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnlogoInicio).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private PictureBox btnlogoInicio;
        private Panel BarraTitulo;
        private PictureBox btnMenu;
        private Panel panelContenedor;
        private Button btnprod;
        private Button btnPuntoVenta;
        private Button btnClientes;
        private Button btnVentas;
        private Label lblcorreo;
        private Label lbluser;
        private PictureBox pbxUser;
        private Label lblusuario;
        private PictureBox btnCerrar;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnMinimizar;
        private Button btnCerrarSesion;
        private Label lblTitulo;
        private Button btnTema;
        private Button btnEvaluacion;
        private Button btnUsuarios;
    }
}

