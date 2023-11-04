namespace Restaurante
{
    partial class Compras
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
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnCerrar = new PictureBox();
            btnAdd = new CustomControls.RJControls.RJButton();
            panelCentral = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            dataClientes = new DataGridView();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelCentral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataClientes).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.FlatStyle = FlatStyle.Flat;
            lblTitulo.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "COMPRAS";
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Black;
            panelOptions.Controls.Add(btnCerrar);
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1373, 49);
            panelOptions.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Location = new Point(1347, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 49);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 24;
            btnCerrar.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.BackgroundColor = Color.DarkOrange;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 0;
            btnAdd.BorderSize = 0;
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 656);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(1373, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panel1);
            panelCentral.Controls.Add(dataClientes);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1373, 607);
            panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rjButton2);
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rjTextBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rjTextBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(rjTextBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rjTextBox1);
            panel1.Location = new Point(907, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 570);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(162, 13);
            label5.Name = "label5";
            label5.Size = new Size(91, 33);
            label5.TabIndex = 9;
            label5.Text = "Datos";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.DarkOrange;
            rjButton2.BackgroundColor = Color.DarkOrange;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(308, 516);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(127, 42);
            rjButton2.TabIndex = 8;
            rjButton2.Text = "Eliminar";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DarkOrange;
            rjButton1.BackgroundColor = Color.DarkOrange;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(13, 516);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(127, 42);
            rjButton1.TabIndex = 4;
            rjButton1.Text = "Editar";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(9, 196);
            label4.Name = "label4";
            label4.Size = new Size(169, 33);
            label4.TabIndex = 7;
            label4.Text = "Descripcion";
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = SystemColors.Window;
            rjTextBox4.BorderColor = Color.Peru;
            rjTextBox4.BorderFocusColor = Color.Gold;
            rjTextBox4.BorderRadius = 0;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox4.Location = new Point(185, 198);
            rjTextBox4.Margin = new Padding(4);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "";
            rjTextBox4.Size = new Size(250, 31);
            rjTextBox4.TabIndex = 6;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(81, 314);
            label3.Name = "label3";
            label3.Size = new Size(97, 33);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = SystemColors.Window;
            rjTextBox3.BorderColor = Color.Peru;
            rjTextBox3.BorderFocusColor = Color.Gold;
            rjTextBox3.BorderRadius = 0;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(185, 316);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "";
            rjTextBox3.Size = new Size(250, 31);
            rjTextBox3.TabIndex = 4;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(85, 257);
            label2.Name = "label2";
            label2.Size = new Size(93, 33);
            label2.TabIndex = 3;
            label2.Text = "Costo";
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.Peru;
            rjTextBox2.BorderFocusColor = Color.Gold;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(185, 259);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(250, 31);
            rjTextBox2.TabIndex = 2;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(137, 138);
            label1.Name = "label1";
            label1.Size = new Size(41, 33);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = SystemColors.Window;
            rjTextBox1.BorderColor = Color.Peru;
            rjTextBox1.BorderFocusColor = Color.Gold;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(185, 140);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(250, 31);
            rjTextBox1.TabIndex = 0;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // dataClientes
            // 
            dataClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClientes.Location = new Point(18, 18);
            dataClientes.Name = "dataClientes";
            dataClientes.RowTemplate.Height = 25;
            dataClientes.Size = new Size(870, 570);
            dataClientes.TabIndex = 4;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1373, 698);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "Productos";
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelCentral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private CustomControls.RJControls.RJButton btnAdd;
        private PictureBox btnCerrar;
        private Panel panelCentral;
        private Panel panel1;
        private Label label5;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private Label label3;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private Label label2;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private DataGridView dataClientes;
    }
}