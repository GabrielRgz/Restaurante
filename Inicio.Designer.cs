namespace Restaurante
{
    partial class Inicio
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            lblBienvenida = new Label();
            lblHora = new Label();
            lblFecha = new Label();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelOptions = new Panel();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(181, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 335);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.None;
            lblBienvenida.AutoSize = true;
            lblBienvenida.FlatStyle = FlatStyle.Flat;
            lblBienvenida.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.ForeColor = Color.Orange;
            lblBienvenida.Location = new Point(350, 408);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(304, 38);
            lblBienvenida.TabIndex = 25;
            lblBienvenida.Text = "BIENVENIDO \"User\"";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.None;
            lblHora.AutoSize = true;
            lblHora.FlatStyle = FlatStyle.Flat;
            lblHora.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.ForeColor = Color.Orange;
            lblHora.Location = new Point(341, 446);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(212, 56);
            lblHora.TabIndex = 26;
            lblHora.Text = "00:00:00";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.None;
            lblFecha.AutoSize = true;
            lblFecha.FlatStyle = FlatStyle.Flat;
            lblFecha.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.BurlyWood;
            lblFecha.Location = new Point(450, 517);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(77, 19);
            lblFecha.TabIndex = 27;
            lblFecha.Text = "00/00/00";
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Orange;
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1035, 5);
            panelOptions.TabIndex = 28;
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
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1035, 619);
            Controls.Add(panelOptions);
            Controls.Add(lblFecha);
            Controls.Add(lblHora);
            Controls.Add(lblBienvenida);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblBienvenida;
        private Label lblHora;
        private Label lblFecha;
        private System.Windows.Forms.Timer horaFecha;
        private Panel panelOptions;
        private Label lblTitulo;
    }
}