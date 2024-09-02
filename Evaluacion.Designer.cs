namespace Restaurante
{
    partial class Evaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evaluacion));
            panelOptions = new Panel();
            lblTitulo = new Label();
            lblBienvenida = new Label();
            btnEnviar = new CustomControls.RJControls.RJButton();
            panel4 = new Panel();
            panel1 = new Panel();
            txbComentarios = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panelRB = new Panel();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblAtencion5 = new Label();
            lblAtencion4 = new Label();
            lblAtencion3 = new Label();
            lblAtencion2 = new Label();
            lblAtencion1 = new Label();
            rbAtencion4 = new CustomControls.RJControls.RJRadioButton();
            rbAtencion2 = new CustomControls.RJControls.RJRadioButton();
            rbAtencion5 = new CustomControls.RJControls.RJRadioButton();
            rbAtencion3 = new CustomControls.RJControls.RJRadioButton();
            rbAtencion1 = new CustomControls.RJControls.RJRadioButton();
            lblHora = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label7 = new Label();
            lblPrecios5 = new Label();
            lblPrecios4 = new Label();
            lblPrecios3 = new Label();
            lblPrecios2 = new Label();
            lblPrecios1 = new Label();
            rbPrecio4 = new CustomControls.RJControls.RJRadioButton();
            rbPrecio2 = new CustomControls.RJControls.RJRadioButton();
            rbPrecio5 = new CustomControls.RJControls.RJRadioButton();
            rbPrecio3 = new CustomControls.RJControls.RJRadioButton();
            rbPrecio1 = new CustomControls.RJControls.RJRadioButton();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label6 = new Label();
            lblComida5 = new Label();
            lblComida4 = new Label();
            lblComida3 = new Label();
            lblComida2 = new Label();
            lblComida1 = new Label();
            rbComida4 = new CustomControls.RJControls.RJRadioButton();
            rbComida2 = new CustomControls.RJControls.RJRadioButton();
            rbComida5 = new CustomControls.RJControls.RJRadioButton();
            rbComida3 = new CustomControls.RJControls.RJRadioButton();
            rbComida1 = new CustomControls.RJControls.RJRadioButton();
            label1 = new Label();
            panelOptions.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRB.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Orange;
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1019, 5);
            panelOptions.TabIndex = 33;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(0, 6, 0, 0);
            lblTitulo.Size = new Size(0, 39);
            lblTitulo.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Top;
            lblBienvenida.AutoSize = true;
            lblBienvenida.FlatStyle = FlatStyle.Flat;
            lblBienvenida.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.ForeColor = Color.Orange;
            lblBienvenida.Location = new Point(304, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(369, 38);
            lblBienvenida.TabIndex = 30;
            lblBienvenida.Text = "Evalua nuestro servicio";
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Bottom;
            btnEnviar.BackColor = Color.FromArgb(255, 128, 0);
            btnEnviar.BackgroundColor = Color.FromArgb(255, 128, 0);
            btnEnviar.BorderColor = Color.White;
            btnEnviar.BorderRadius = 15;
            btnEnviar.BorderSize = 1;
            btnEnviar.Cursor = Cursors.Hand;
            btnEnviar.FlatAppearance.BorderSize = 0;
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnviar.ForeColor = SystemColors.WindowText;
            btnEnviar.Location = new Point(286, 516);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(460, 47);
            btnEnviar.TabIndex = 41;
            btnEnviar.Text = "Enviar";
            btnEnviar.TextColor = SystemColors.WindowText;
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panelRB);
            panel4.Controls.Add(btnEnviar);
            panel4.Controls.Add(lblBienvenida);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1019, 575);
            panel4.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(txbComentarios);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(608, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 384);
            panel1.TabIndex = 43;
            // 
            // txbComentarios
            // 
            txbComentarios.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbComentarios.BackColor = SystemColors.Window;
            txbComentarios.BorderColor = Color.Orange;
            txbComentarios.BorderFocusColor = Color.Gold;
            txbComentarios.BorderRadius = 15;
            txbComentarios.BorderSize = 2;
            txbComentarios.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbComentarios.ForeColor = Color.FromArgb(64, 64, 64);
            txbComentarios.Location = new Point(21, 187);
            txbComentarios.Margin = new Padding(4);
            txbComentarios.Multiline = true;
            txbComentarios.Name = "txbComentarios";
            txbComentarios.Padding = new Padding(10, 7, 10, 7);
            txbComentarios.PasswordChar = false;
            txbComentarios.PlaceholderColor = Color.DarkGray;
            txbComentarios.PlaceholderText = "";
            txbComentarios.Size = new Size(327, 189);
            txbComentarios.TabIndex = 43;
            txbComentarios.Texts = "";
            txbComentarios.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(34, 149);
            label3.Name = "label3";
            label3.Size = new Size(295, 25);
            label3.TabIndex = 42;
            label3.Text = "Comentarios o sugerencias:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // panelRB
            // 
            panelRB.Anchor = AnchorStyles.None;
            panelRB.Controls.Add(panel5);
            panelRB.Controls.Add(panel3);
            panelRB.Controls.Add(panel2);
            panelRB.Location = new Point(3, 74);
            panelRB.Name = "panelRB";
            panelRB.Size = new Size(582, 422);
            panelRB.TabIndex = 42;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(lblAtencion5);
            panel5.Controls.Add(lblAtencion4);
            panel5.Controls.Add(lblAtencion3);
            panel5.Controls.Add(lblAtencion2);
            panel5.Controls.Add(lblAtencion1);
            panel5.Controls.Add(rbAtencion4);
            panel5.Controls.Add(rbAtencion2);
            panel5.Controls.Add(rbAtencion5);
            panel5.Controls.Add(rbAtencion3);
            panel5.Controls.Add(rbAtencion1);
            panel5.Controls.Add(lblHora);
            panel5.Location = new Point(39, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(526, 111);
            panel5.TabIndex = 129;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(24, 51);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 135;
            label5.Text = "Muy malo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(390, 51);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 134;
            label4.Text = "Muy bueno";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAtencion5
            // 
            lblAtencion5.Anchor = AnchorStyles.None;
            lblAtencion5.AutoSize = true;
            lblAtencion5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencion5.ForeColor = Color.Orange;
            lblAtencion5.Location = new Point(344, 85);
            lblAtencion5.Name = "lblAtencion5";
            lblAtencion5.Size = new Size(22, 24);
            lblAtencion5.TabIndex = 133;
            lblAtencion5.Text = "5";
            // 
            // lblAtencion4
            // 
            lblAtencion4.Anchor = AnchorStyles.None;
            lblAtencion4.AutoSize = true;
            lblAtencion4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencion4.ForeColor = Color.Orange;
            lblAtencion4.Location = new Point(288, 85);
            lblAtencion4.Name = "lblAtencion4";
            lblAtencion4.Size = new Size(22, 24);
            lblAtencion4.TabIndex = 132;
            lblAtencion4.Text = "4";
            // 
            // lblAtencion3
            // 
            lblAtencion3.Anchor = AnchorStyles.None;
            lblAtencion3.AutoSize = true;
            lblAtencion3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencion3.ForeColor = Color.Orange;
            lblAtencion3.Location = new Point(236, 85);
            lblAtencion3.Name = "lblAtencion3";
            lblAtencion3.Size = new Size(22, 24);
            lblAtencion3.TabIndex = 131;
            lblAtencion3.Text = "3";
            // 
            // lblAtencion2
            // 
            lblAtencion2.Anchor = AnchorStyles.None;
            lblAtencion2.AutoSize = true;
            lblAtencion2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencion2.ForeColor = Color.Orange;
            lblAtencion2.Location = new Point(182, 85);
            lblAtencion2.Name = "lblAtencion2";
            lblAtencion2.Size = new Size(22, 24);
            lblAtencion2.TabIndex = 130;
            lblAtencion2.Text = "2";
            // 
            // lblAtencion1
            // 
            lblAtencion1.Anchor = AnchorStyles.None;
            lblAtencion1.AutoSize = true;
            lblAtencion1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtencion1.ForeColor = Color.Orange;
            lblAtencion1.Location = new Point(131, 85);
            lblAtencion1.Name = "lblAtencion1";
            lblAtencion1.Size = new Size(22, 24);
            lblAtencion1.TabIndex = 129;
            lblAtencion1.Text = "1";
            // 
            // rbAtencion4
            // 
            rbAtencion4.Anchor = AnchorStyles.None;
            rbAtencion4.AutoSize = true;
            rbAtencion4.CheckedColor = Color.Orange;
            rbAtencion4.Location = new Point(288, 51);
            rbAtencion4.MinimumSize = new Size(0, 21);
            rbAtencion4.Name = "rbAtencion4";
            rbAtencion4.Padding = new Padding(10, 0, 0, 0);
            rbAtencion4.Size = new Size(24, 21);
            rbAtencion4.TabIndex = 128;
            rbAtencion4.TabStop = true;
            rbAtencion4.UnCheckedColor = Color.Orange;
            rbAtencion4.UseVisualStyleBackColor = true;
            rbAtencion4.CheckedChanged += rbAtencion4_CheckedChanged;
            // 
            // rbAtencion2
            // 
            rbAtencion2.Anchor = AnchorStyles.None;
            rbAtencion2.AutoSize = true;
            rbAtencion2.CheckedColor = Color.Orange;
            rbAtencion2.Location = new Point(182, 51);
            rbAtencion2.MinimumSize = new Size(0, 21);
            rbAtencion2.Name = "rbAtencion2";
            rbAtencion2.Padding = new Padding(10, 0, 0, 0);
            rbAtencion2.Size = new Size(24, 21);
            rbAtencion2.TabIndex = 127;
            rbAtencion2.TabStop = true;
            rbAtencion2.UnCheckedColor = Color.Orange;
            rbAtencion2.UseVisualStyleBackColor = true;
            rbAtencion2.CheckedChanged += rbAtencion2_CheckedChanged;
            // 
            // rbAtencion5
            // 
            rbAtencion5.Anchor = AnchorStyles.None;
            rbAtencion5.AutoSize = true;
            rbAtencion5.CheckedColor = Color.Orange;
            rbAtencion5.Location = new Point(344, 51);
            rbAtencion5.MinimumSize = new Size(0, 21);
            rbAtencion5.Name = "rbAtencion5";
            rbAtencion5.Padding = new Padding(10, 0, 0, 0);
            rbAtencion5.Size = new Size(24, 21);
            rbAtencion5.TabIndex = 126;
            rbAtencion5.TabStop = true;
            rbAtencion5.UnCheckedColor = Color.Orange;
            rbAtencion5.UseVisualStyleBackColor = true;
            rbAtencion5.CheckedChanged += rbAtencion5_CheckedChanged;
            // 
            // rbAtencion3
            // 
            rbAtencion3.Anchor = AnchorStyles.None;
            rbAtencion3.AutoSize = true;
            rbAtencion3.CheckedColor = Color.Orange;
            rbAtencion3.Location = new Point(236, 51);
            rbAtencion3.MinimumSize = new Size(0, 21);
            rbAtencion3.Name = "rbAtencion3";
            rbAtencion3.Padding = new Padding(10, 0, 0, 0);
            rbAtencion3.Size = new Size(24, 21);
            rbAtencion3.TabIndex = 125;
            rbAtencion3.TabStop = true;
            rbAtencion3.UnCheckedColor = Color.Orange;
            rbAtencion3.UseVisualStyleBackColor = true;
            rbAtencion3.CheckedChanged += rbAtencion3_CheckedChanged;
            // 
            // rbAtencion1
            // 
            rbAtencion1.Anchor = AnchorStyles.None;
            rbAtencion1.AutoSize = true;
            rbAtencion1.CheckedColor = Color.Orange;
            rbAtencion1.Location = new Point(131, 51);
            rbAtencion1.MinimumSize = new Size(0, 21);
            rbAtencion1.Name = "rbAtencion1";
            rbAtencion1.Padding = new Padding(10, 0, 0, 0);
            rbAtencion1.Size = new Size(24, 21);
            rbAtencion1.TabIndex = 124;
            rbAtencion1.TabStop = true;
            rbAtencion1.UnCheckedColor = Color.Orange;
            rbAtencion1.UseVisualStyleBackColor = true;
            rbAtencion1.CheckedChanged += rbAtencion1_CheckedChanged;
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.Orange;
            lblHora.Location = new Point(112, 2);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(299, 25);
            lblHora.TabIndex = 123;
            lblHora.Text = "Que te parecio la atencion?";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(lblPrecios5);
            panel3.Controls.Add(lblPrecios4);
            panel3.Controls.Add(lblPrecios3);
            panel3.Controls.Add(lblPrecios2);
            panel3.Controls.Add(lblPrecios1);
            panel3.Controls.Add(rbPrecio4);
            panel3.Controls.Add(rbPrecio2);
            panel3.Controls.Add(rbPrecio5);
            panel3.Controls.Add(rbPrecio3);
            panel3.Controls.Add(rbPrecio1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(9, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(570, 116);
            panel3.TabIndex = 128;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Orange;
            label9.Location = new Point(3, 50);
            label9.Name = "label9";
            label9.Size = new Size(158, 23);
            label9.TabIndex = 139;
            label9.Text = "Muy inconforme";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Orange;
            label7.Location = new Point(425, 54);
            label7.Name = "label7";
            label7.Size = new Size(142, 23);
            label7.TabIndex = 138;
            label7.Text = "Muy conforme";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecios5
            // 
            lblPrecios5.Anchor = AnchorStyles.None;
            lblPrecios5.AutoSize = true;
            lblPrecios5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecios5.ForeColor = Color.Orange;
            lblPrecios5.Location = new Point(378, 87);
            lblPrecios5.Name = "lblPrecios5";
            lblPrecios5.Size = new Size(22, 24);
            lblPrecios5.TabIndex = 137;
            lblPrecios5.Text = "5";
            // 
            // lblPrecios4
            // 
            lblPrecios4.Anchor = AnchorStyles.None;
            lblPrecios4.AutoSize = true;
            lblPrecios4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecios4.ForeColor = Color.Orange;
            lblPrecios4.Location = new Point(322, 87);
            lblPrecios4.Name = "lblPrecios4";
            lblPrecios4.Size = new Size(22, 24);
            lblPrecios4.TabIndex = 136;
            lblPrecios4.Text = "4";
            // 
            // lblPrecios3
            // 
            lblPrecios3.Anchor = AnchorStyles.None;
            lblPrecios3.AutoSize = true;
            lblPrecios3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecios3.ForeColor = Color.Orange;
            lblPrecios3.Location = new Point(270, 87);
            lblPrecios3.Name = "lblPrecios3";
            lblPrecios3.Size = new Size(22, 24);
            lblPrecios3.TabIndex = 135;
            lblPrecios3.Text = "3";
            // 
            // lblPrecios2
            // 
            lblPrecios2.Anchor = AnchorStyles.None;
            lblPrecios2.AutoSize = true;
            lblPrecios2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecios2.ForeColor = Color.Orange;
            lblPrecios2.Location = new Point(216, 87);
            lblPrecios2.Name = "lblPrecios2";
            lblPrecios2.Size = new Size(22, 24);
            lblPrecios2.TabIndex = 134;
            lblPrecios2.Text = "2";
            // 
            // lblPrecios1
            // 
            lblPrecios1.Anchor = AnchorStyles.None;
            lblPrecios1.AutoSize = true;
            lblPrecios1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecios1.ForeColor = Color.Orange;
            lblPrecios1.Location = new Point(165, 87);
            lblPrecios1.Name = "lblPrecios1";
            lblPrecios1.Size = new Size(22, 24);
            lblPrecios1.TabIndex = 133;
            lblPrecios1.Text = "1";
            // 
            // rbPrecio4
            // 
            rbPrecio4.Anchor = AnchorStyles.None;
            rbPrecio4.AutoSize = true;
            rbPrecio4.CheckedColor = Color.Orange;
            rbPrecio4.Location = new Point(323, 54);
            rbPrecio4.MinimumSize = new Size(0, 21);
            rbPrecio4.Name = "rbPrecio4";
            rbPrecio4.Padding = new Padding(10, 0, 0, 0);
            rbPrecio4.Size = new Size(24, 21);
            rbPrecio4.TabIndex = 132;
            rbPrecio4.TabStop = true;
            rbPrecio4.UnCheckedColor = Color.Orange;
            rbPrecio4.UseVisualStyleBackColor = true;
            rbPrecio4.CheckedChanged += rbPrecio4_CheckedChanged;
            // 
            // rbPrecio2
            // 
            rbPrecio2.Anchor = AnchorStyles.None;
            rbPrecio2.AutoSize = true;
            rbPrecio2.CheckedColor = Color.Orange;
            rbPrecio2.Location = new Point(217, 54);
            rbPrecio2.MinimumSize = new Size(0, 21);
            rbPrecio2.Name = "rbPrecio2";
            rbPrecio2.Padding = new Padding(10, 0, 0, 0);
            rbPrecio2.Size = new Size(24, 21);
            rbPrecio2.TabIndex = 131;
            rbPrecio2.TabStop = true;
            rbPrecio2.UnCheckedColor = Color.Orange;
            rbPrecio2.UseVisualStyleBackColor = true;
            rbPrecio2.CheckedChanged += rbPrecio2_CheckedChanged;
            // 
            // rbPrecio5
            // 
            rbPrecio5.Anchor = AnchorStyles.None;
            rbPrecio5.AutoSize = true;
            rbPrecio5.CheckedColor = Color.Orange;
            rbPrecio5.Location = new Point(379, 54);
            rbPrecio5.MinimumSize = new Size(0, 21);
            rbPrecio5.Name = "rbPrecio5";
            rbPrecio5.Padding = new Padding(10, 0, 0, 0);
            rbPrecio5.Size = new Size(24, 21);
            rbPrecio5.TabIndex = 130;
            rbPrecio5.TabStop = true;
            rbPrecio5.UnCheckedColor = Color.Orange;
            rbPrecio5.UseVisualStyleBackColor = true;
            rbPrecio5.CheckedChanged += rbPrecio5_CheckedChanged;
            // 
            // rbPrecio3
            // 
            rbPrecio3.Anchor = AnchorStyles.None;
            rbPrecio3.AutoSize = true;
            rbPrecio3.CheckedColor = Color.Orange;
            rbPrecio3.Location = new Point(271, 54);
            rbPrecio3.MinimumSize = new Size(0, 21);
            rbPrecio3.Name = "rbPrecio3";
            rbPrecio3.Padding = new Padding(10, 0, 0, 0);
            rbPrecio3.Size = new Size(24, 21);
            rbPrecio3.TabIndex = 129;
            rbPrecio3.TabStop = true;
            rbPrecio3.UnCheckedColor = Color.Orange;
            rbPrecio3.UseVisualStyleBackColor = true;
            rbPrecio3.CheckedChanged += rbPrecio3_CheckedChanged;
            // 
            // rbPrecio1
            // 
            rbPrecio1.Anchor = AnchorStyles.None;
            rbPrecio1.AutoSize = true;
            rbPrecio1.CheckedColor = Color.Orange;
            rbPrecio1.Location = new Point(166, 54);
            rbPrecio1.MinimumSize = new Size(0, 21);
            rbPrecio1.Name = "rbPrecio1";
            rbPrecio1.Padding = new Padding(10, 0, 0, 0);
            rbPrecio1.Size = new Size(24, 21);
            rbPrecio1.TabIndex = 128;
            rbPrecio1.TabStop = true;
            rbPrecio1.UnCheckedColor = Color.Orange;
            rbPrecio1.UseVisualStyleBackColor = true;
            rbPrecio1.CheckedChanged += rbPrecio1_CheckedChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(146, 6);
            label2.Name = "label2";
            label2.Size = new Size(299, 25);
            label2.TabIndex = 127;
            label2.Text = "Que te parecen los precios?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblComida5);
            panel2.Controls.Add(lblComida4);
            panel2.Controls.Add(lblComida3);
            panel2.Controls.Add(lblComida2);
            panel2.Controls.Add(lblComida1);
            panel2.Controls.Add(rbComida4);
            panel2.Controls.Add(rbComida2);
            panel2.Controls.Add(rbComida5);
            panel2.Controls.Add(rbComida3);
            panel2.Controls.Add(rbComida1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(39, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 122);
            panel2.TabIndex = 127;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Orange;
            label8.Location = new Point(24, 60);
            label8.Name = "label8";
            label8.Size = new Size(102, 23);
            label8.TabIndex = 138;
            label8.Text = "Muy malo";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(390, 59);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 137;
            label6.Text = "Muy bueno";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblComida5
            // 
            lblComida5.Anchor = AnchorStyles.None;
            lblComida5.AutoSize = true;
            lblComida5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida5.ForeColor = Color.Orange;
            lblComida5.Location = new Point(343, 89);
            lblComida5.Name = "lblComida5";
            lblComida5.Size = new Size(22, 24);
            lblComida5.TabIndex = 136;
            lblComida5.Text = "5";
            // 
            // lblComida4
            // 
            lblComida4.Anchor = AnchorStyles.None;
            lblComida4.AutoSize = true;
            lblComida4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida4.ForeColor = Color.Orange;
            lblComida4.Location = new Point(287, 89);
            lblComida4.Name = "lblComida4";
            lblComida4.Size = new Size(22, 24);
            lblComida4.TabIndex = 135;
            lblComida4.Text = "4";
            // 
            // lblComida3
            // 
            lblComida3.Anchor = AnchorStyles.None;
            lblComida3.AutoSize = true;
            lblComida3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida3.ForeColor = Color.Orange;
            lblComida3.Location = new Point(235, 89);
            lblComida3.Name = "lblComida3";
            lblComida3.Size = new Size(22, 24);
            lblComida3.TabIndex = 134;
            lblComida3.Text = "3";
            // 
            // lblComida2
            // 
            lblComida2.Anchor = AnchorStyles.None;
            lblComida2.AutoSize = true;
            lblComida2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida2.ForeColor = Color.Orange;
            lblComida2.Location = new Point(181, 89);
            lblComida2.Name = "lblComida2";
            lblComida2.Size = new Size(22, 24);
            lblComida2.TabIndex = 133;
            lblComida2.Text = "2";
            // 
            // lblComida1
            // 
            lblComida1.Anchor = AnchorStyles.None;
            lblComida1.AutoSize = true;
            lblComida1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComida1.ForeColor = Color.Orange;
            lblComida1.Location = new Point(130, 89);
            lblComida1.Name = "lblComida1";
            lblComida1.Size = new Size(22, 24);
            lblComida1.TabIndex = 132;
            lblComida1.Text = "1";
            // 
            // rbComida4
            // 
            rbComida4.Anchor = AnchorStyles.None;
            rbComida4.AutoSize = true;
            rbComida4.CheckedColor = Color.Orange;
            rbComida4.Location = new Point(287, 59);
            rbComida4.MinimumSize = new Size(0, 21);
            rbComida4.Name = "rbComida4";
            rbComida4.Padding = new Padding(10, 0, 0, 0);
            rbComida4.Size = new Size(24, 21);
            rbComida4.TabIndex = 131;
            rbComida4.TabStop = true;
            rbComida4.UnCheckedColor = Color.Orange;
            rbComida4.UseVisualStyleBackColor = true;
            rbComida4.CheckedChanged += rbComida4_CheckedChanged;
            // 
            // rbComida2
            // 
            rbComida2.Anchor = AnchorStyles.None;
            rbComida2.AutoSize = true;
            rbComida2.CheckedColor = Color.Orange;
            rbComida2.Location = new Point(181, 59);
            rbComida2.MinimumSize = new Size(0, 21);
            rbComida2.Name = "rbComida2";
            rbComida2.Padding = new Padding(10, 0, 0, 0);
            rbComida2.Size = new Size(24, 21);
            rbComida2.TabIndex = 130;
            rbComida2.TabStop = true;
            rbComida2.UnCheckedColor = Color.Orange;
            rbComida2.UseVisualStyleBackColor = true;
            rbComida2.CheckedChanged += rbComida2_CheckedChanged;
            // 
            // rbComida5
            // 
            rbComida5.Anchor = AnchorStyles.None;
            rbComida5.AutoSize = true;
            rbComida5.CheckedColor = Color.Orange;
            rbComida5.Location = new Point(343, 59);
            rbComida5.MinimumSize = new Size(0, 21);
            rbComida5.Name = "rbComida5";
            rbComida5.Padding = new Padding(10, 0, 0, 0);
            rbComida5.Size = new Size(24, 21);
            rbComida5.TabIndex = 129;
            rbComida5.TabStop = true;
            rbComida5.UnCheckedColor = Color.Orange;
            rbComida5.UseVisualStyleBackColor = true;
            rbComida5.CheckedChanged += rbComida5_CheckedChanged;
            // 
            // rbComida3
            // 
            rbComida3.Anchor = AnchorStyles.None;
            rbComida3.AutoSize = true;
            rbComida3.CheckedColor = Color.Orange;
            rbComida3.Location = new Point(235, 59);
            rbComida3.MinimumSize = new Size(0, 21);
            rbComida3.Name = "rbComida3";
            rbComida3.Padding = new Padding(10, 0, 0, 0);
            rbComida3.Size = new Size(24, 21);
            rbComida3.TabIndex = 128;
            rbComida3.TabStop = true;
            rbComida3.UnCheckedColor = Color.Orange;
            rbComida3.UseVisualStyleBackColor = true;
            rbComida3.CheckedChanged += rbAtencion3_CheckedChanged;
            // 
            // rbComida1
            // 
            rbComida1.Anchor = AnchorStyles.None;
            rbComida1.AutoSize = true;
            rbComida1.CheckedColor = Color.Orange;
            rbComida1.Location = new Point(130, 59);
            rbComida1.MinimumSize = new Size(0, 21);
            rbComida1.Name = "rbComida1";
            rbComida1.Padding = new Padding(10, 0, 0, 0);
            rbComida1.Size = new Size(24, 21);
            rbComida1.TabIndex = 127;
            rbComida1.TabStop = true;
            rbComida1.UnCheckedColor = Color.Orange;
            rbComida1.UseVisualStyleBackColor = true;
            rbComida1.CheckedChanged += rbComida1_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(111, 10);
            label1.Name = "label1";
            label1.Size = new Size(288, 25);
            label1.TabIndex = 126;
            label1.Text = "Que te parecio la comida?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Evaluacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1019, 580);
            Controls.Add(panel4);
            Controls.Add(panelOptions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Evaluacion";
            Text = "Evaluacion";
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRB.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOptions;
        private Label lblTitulo;
        private Label lblBienvenida;
        private CustomControls.RJControls.RJButton btnEnviar;
        private Panel panel4;
        private Panel panelRB;
        private Panel panel1;
        private CustomControls.RJControls.RJTextBox txbComentarios;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label8;
        private Label label6;
        private Label lblComida5;
        private Label lblComida4;
        private Label lblComida3;
        private Label lblComida2;
        private Label lblComida1;
        private CustomControls.RJControls.RJRadioButton rbComida4;
        private CustomControls.RJControls.RJRadioButton rbComida2;
        private CustomControls.RJControls.RJRadioButton rbComida5;
        private CustomControls.RJControls.RJRadioButton rbComida3;
        private CustomControls.RJControls.RJRadioButton rbComida1;
        private Label label1;
        private Panel panel5;
        private Label label5;
        private Label label4;
        private Label lblAtencion5;
        private Label lblAtencion4;
        private Label lblAtencion3;
        private Label lblAtencion2;
        private Label lblAtencion1;
        private CustomControls.RJControls.RJRadioButton rbAtencion4;
        private CustomControls.RJControls.RJRadioButton rbAtencion2;
        private CustomControls.RJControls.RJRadioButton rbAtencion5;
        private CustomControls.RJControls.RJRadioButton rbAtencion3;
        private CustomControls.RJControls.RJRadioButton rbAtencion1;
        private Label lblHora;
        private Panel panel3;
        private Label label9;
        private Label label7;
        private Label lblPrecios5;
        private Label lblPrecios4;
        private Label lblPrecios3;
        private Label lblPrecios2;
        private Label lblPrecios1;
        private CustomControls.RJControls.RJRadioButton rbPrecio4;
        private CustomControls.RJControls.RJRadioButton rbPrecio2;
        private CustomControls.RJControls.RJRadioButton rbPrecio5;
        private CustomControls.RJControls.RJRadioButton rbPrecio3;
        private CustomControls.RJControls.RJRadioButton rbPrecio1;
        private Label label2;
    }
}