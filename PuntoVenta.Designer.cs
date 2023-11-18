namespace Restaurante
{
    partial class PuntoVenta
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
            panelCentral = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            lblAdd = new CustomControls.RJControls.RJButton();
            panelPago = new Panel();
            lblPrecio = new Label();
            btnPagar = new CustomControls.RJControls.RJButton();
            txbImporte = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjDateTimePicker2 = new RJControls.RJDateTimePicker();
            label2 = new Label();
            label3 = new Label();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            lblEstado = new Label();
            txbEstado = new CustomControls.RJControls.RJTextBox();
            rjDateTimePicker1 = new RJControls.RJDateTimePicker();
            lblFecha = new Label();
            lblUsuario = new Label();
            txbUsuario = new CustomControls.RJControls.RJTextBox();
            lblidCliente = new Label();
            txbID = new CustomControls.RJControls.RJTextBox();
            panelOptions.SuspendLayout();
            panelCentral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelPago.SuspendLayout();
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
            lblTitulo.Size = new Size(233, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PUNTO DE VENTA";
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Black;
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1338, 49);
            panelOptions.TabIndex = 1;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panel1);
            panelCentral.Controls.Add(lblEstado);
            panelCentral.Controls.Add(txbEstado);
            panelCentral.Controls.Add(rjDateTimePicker1);
            panelCentral.Controls.Add(lblFecha);
            panelCentral.Controls.Add(lblUsuario);
            panelCentral.Controls.Add(txbUsuario);
            panelCentral.Controls.Add(lblidCliente);
            panelCentral.Controls.Add(txbID);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1338, 649);
            panelCentral.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lblAdd);
            panel1.Controls.Add(panelPago);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rjTextBox1);
            panel1.Controls.Add(rjDateTimePicker2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rjTextBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rjTextBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1338, 649);
            panel1.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(690, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(374, 179);
            dataGridView1.TabIndex = 59;
            // 
            // lblAdd
            // 
            lblAdd.BackColor = Color.DarkOrange;
            lblAdd.BackgroundColor = Color.DarkOrange;
            lblAdd.BorderColor = Color.White;
            lblAdd.BorderRadius = 15;
            lblAdd.BorderSize = 1;
            lblAdd.FlatAppearance.BorderSize = 0;
            lblAdd.FlatStyle = FlatStyle.Flat;
            lblAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdd.ForeColor = Color.Black;
            lblAdd.Location = new Point(778, 313);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(200, 42);
            lblAdd.TabIndex = 58;
            lblAdd.Text = "Agregar producto";
            lblAdd.TextColor = Color.Black;
            lblAdd.UseVisualStyleBackColor = false;
            lblAdd.Click += lblAdd_Click;
            // 
            // panelPago
            // 
            panelPago.BackColor = Color.Orange;
            panelPago.Controls.Add(lblPrecio);
            panelPago.Controls.Add(btnPagar);
            panelPago.Controls.Add(txbImporte);
            panelPago.Dock = DockStyle.Right;
            panelPago.Location = new Point(1138, 0);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(200, 649);
            panelPago.TabIndex = 56;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = SystemColors.ButtonHighlight;
            lblPrecio.Location = new Point(43, 492);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(119, 33);
            lblPrecio.TabIndex = 53;
            lblPrecio.Text = "Importe";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkOrange;
            btnPagar.BackgroundColor = Color.DarkOrange;
            btnPagar.BorderColor = Color.White;
            btnPagar.BorderRadius = 15;
            btnPagar.BorderSize = 1;
            btnPagar.Dock = DockStyle.Bottom;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(0, 607);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(200, 42);
            btnPagar.TabIndex = 55;
            btnPagar.Text = "Pagar";
            btnPagar.TextColor = Color.Black;
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // txbImporte
            // 
            txbImporte.BackColor = SystemColors.Window;
            txbImporte.BorderColor = Color.Peru;
            txbImporte.BorderFocusColor = Color.Gold;
            txbImporte.BorderRadius = 0;
            txbImporte.BorderSize = 2;
            txbImporte.Enabled = false;
            txbImporte.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbImporte.ForeColor = Color.FromArgb(64, 64, 64);
            txbImporte.Location = new Point(14, 538);
            txbImporte.Margin = new Padding(4);
            txbImporte.Multiline = false;
            txbImporte.Name = "txbImporte";
            txbImporte.Padding = new Padding(10, 7, 10, 7);
            txbImporte.PasswordChar = false;
            txbImporte.PlaceholderColor = Color.DarkGray;
            txbImporte.PlaceholderText = "Importe total";
            txbImporte.Size = new Size(173, 31);
            txbImporte.TabIndex = 54;
            txbImporte.Texts = "";
            txbImporte.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(38, 274);
            label1.Name = "label1";
            label1.Size = new Size(104, 33);
            label1.TabIndex = 50;
            label1.Text = "Estado";
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
            rjTextBox1.Location = new Point(156, 274);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Estado de la venta";
            rjTextBox1.Size = new Size(295, 31);
            rjTextBox1.TabIndex = 49;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjDateTimePicker2
            // 
            rjDateTimePicker2.BorderColor = Color.Peru;
            rjDateTimePicker2.BorderSize = 2;
            rjDateTimePicker2.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            rjDateTimePicker2.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            rjDateTimePicker2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjDateTimePicker2.Location = new Point(318, 36);
            rjDateTimePicker2.MinimumSize = new Size(0, 35);
            rjDateTimePicker2.Name = "rjDateTimePicker2";
            rjDateTimePicker2.Size = new Size(255, 35);
            rjDateTimePicker2.TabIndex = 48;
            rjDateTimePicker2.TextColor = Color.Black;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(38, 33);
            label2.Name = "label2";
            label2.Size = new Size(258, 33);
            label2.TabIndex = 46;
            label2.Text = "Fecha de la venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(38, 132);
            label3.Name = "label3";
            label3.Size = new Size(108, 33);
            label3.TabIndex = 45;
            label3.Text = "Usuario";
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = SystemColors.Window;
            rjTextBox2.BorderColor = Color.Peru;
            rjTextBox2.BorderFocusColor = Color.Gold;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Enabled = false;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(156, 134);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "ID usuario";
            rjTextBox2.Size = new Size(295, 31);
            rjTextBox2.TabIndex = 44;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(38, 210);
            label4.Name = "label4";
            label4.Size = new Size(111, 33);
            label4.TabIndex = 43;
            label4.Text = "Cliente";
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
            rjTextBox3.Location = new Point(156, 212);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "ID del Cliente";
            rjTextBox3.Size = new Size(295, 31);
            rjTextBox3.TabIndex = 42;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.Orange;
            lblEstado.Location = new Point(38, 274);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(104, 33);
            lblEstado.TabIndex = 50;
            lblEstado.Text = "Estado";
            // 
            // txbEstado
            // 
            txbEstado.BackColor = SystemColors.Window;
            txbEstado.BorderColor = Color.Peru;
            txbEstado.BorderFocusColor = Color.Gold;
            txbEstado.BorderRadius = 0;
            txbEstado.BorderSize = 2;
            txbEstado.Enabled = false;
            txbEstado.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbEstado.ForeColor = Color.FromArgb(64, 64, 64);
            txbEstado.Location = new Point(156, 274);
            txbEstado.Margin = new Padding(4);
            txbEstado.Multiline = false;
            txbEstado.Name = "txbEstado";
            txbEstado.Padding = new Padding(10, 7, 10, 7);
            txbEstado.PasswordChar = false;
            txbEstado.PlaceholderColor = Color.DarkGray;
            txbEstado.PlaceholderText = "Estado de la venta";
            txbEstado.Size = new Size(295, 31);
            txbEstado.TabIndex = 49;
            txbEstado.Texts = "";
            txbEstado.UnderlinedStyle = false;
            // 
            // rjDateTimePicker1
            // 
            rjDateTimePicker1.BorderColor = Color.Peru;
            rjDateTimePicker1.BorderSize = 2;
            rjDateTimePicker1.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            rjDateTimePicker1.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            rjDateTimePicker1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjDateTimePicker1.Location = new Point(318, 36);
            rjDateTimePicker1.MinimumSize = new Size(0, 35);
            rjDateTimePicker1.Name = "rjDateTimePicker1";
            rjDateTimePicker1.Size = new Size(255, 35);
            rjDateTimePicker1.TabIndex = 48;
            rjDateTimePicker1.TextColor = Color.Black;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.Orange;
            lblFecha.Location = new Point(38, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(258, 33);
            lblFecha.TabIndex = 46;
            lblFecha.Text = "Fecha de la venta";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Orange;
            lblUsuario.Location = new Point(38, 208);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(108, 33);
            lblUsuario.TabIndex = 45;
            lblUsuario.Text = "Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.BackColor = SystemColors.Window;
            txbUsuario.BorderColor = Color.Peru;
            txbUsuario.BorderFocusColor = Color.Gold;
            txbUsuario.BorderRadius = 0;
            txbUsuario.BorderSize = 2;
            txbUsuario.Enabled = false;
            txbUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txbUsuario.Location = new Point(156, 210);
            txbUsuario.Margin = new Padding(4);
            txbUsuario.Multiline = false;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Padding = new Padding(10, 7, 10, 7);
            txbUsuario.PasswordChar = false;
            txbUsuario.PlaceholderColor = Color.DarkGray;
            txbUsuario.PlaceholderText = "ID usuario";
            txbUsuario.Size = new Size(295, 31);
            txbUsuario.TabIndex = 44;
            txbUsuario.Texts = "";
            txbUsuario.UnderlinedStyle = false;
            // 
            // lblidCliente
            // 
            lblidCliente.AutoSize = true;
            lblidCliente.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblidCliente.ForeColor = Color.Orange;
            lblidCliente.Location = new Point(38, 132);
            lblidCliente.Name = "lblidCliente";
            lblidCliente.Size = new Size(111, 33);
            lblidCliente.TabIndex = 43;
            lblidCliente.Text = "Cliente";
            // 
            // txbID
            // 
            txbID.BackColor = SystemColors.Window;
            txbID.BorderColor = Color.Peru;
            txbID.BorderFocusColor = Color.Gold;
            txbID.BorderRadius = 0;
            txbID.BorderSize = 2;
            txbID.Enabled = false;
            txbID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbID.ForeColor = Color.FromArgb(64, 64, 64);
            txbID.Location = new Point(156, 134);
            txbID.Margin = new Padding(4);
            txbID.Multiline = false;
            txbID.Name = "txbID";
            txbID.Padding = new Padding(10, 7, 10, 7);
            txbID.PasswordChar = false;
            txbID.PlaceholderColor = Color.DarkGray;
            txbID.PlaceholderText = "ID del Cliente";
            txbID.Size = new Size(295, 31);
            txbID.TabIndex = 42;
            txbID.Texts = "";
            txbID.UnderlinedStyle = false;
            // 
            // PuntoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1338, 698);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PuntoVenta";
            Text = "Productos";
            Load += PuntoVenta_Load;
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panelCentral.ResumeLayout(false);
            panelCentral.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelPago.ResumeLayout(false);
            panelPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private Panel panelCentral;
        private CustomControls.RJControls.RJTextBox txbID;
        private Label lblidCliente;
        private Label lblFecha;
        private Label lblUsuario;
        private CustomControls.RJControls.RJTextBox txbUsuario;
        private RJControls.RJDateTimePicker rjDateTimePicker1;
        private Label lblEstado;
        private CustomControls.RJControls.RJTextBox txbEstado;
        private Panel panel1;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private RJControls.RJDateTimePicker rjDateTimePicker2;
        private Label label2;
        private Label label3;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Label label4;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private Panel panelPago;
        private Label lblPrecio;
        private CustomControls.RJControls.RJButton btnPagar;
        private CustomControls.RJControls.RJTextBox txbImporte;
        private CustomControls.RJControls.RJButton lblAdd;
        private DataGridView dataGridView1;
    }
}