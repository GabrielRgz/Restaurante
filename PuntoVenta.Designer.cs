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
            lblPrecio = new Label();
            dataProductos = new DataGridView();
            btnAdd = new CustomControls.RJControls.RJButton();
            panelPago = new Panel();
            txbCliente = new CustomControls.RJControls.RJComboBox();
            btnPagar = new CustomControls.RJControls.RJButton();
            txbImporte = new CustomControls.RJControls.RJTextBox();
            txbId = new CustomControls.RJControls.RJTextBox();
            txbEstado = new CustomControls.RJControls.RJTextBox();
            lblEstado = new Label();
            dtFecha = new RJControls.RJDateTimePicker();
            lblFecha = new Label();
            lblUsario = new Label();
            lblCliente = new Label();
            panelOptions.SuspendLayout();
            panelCentral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
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
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1338, 649);
            panelCentral.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(dataProductos);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panelPago);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(dtFecha);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblUsario);
            panel1.Controls.Add(lblCliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1338, 649);
            panel1.TabIndex = 51;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Orange;
            lblPrecio.Location = new Point(892, 507);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(119, 33);
            lblPrecio.TabIndex = 53;
            lblPrecio.Text = "Importe";
            // 
            // dataProductos
            // 
            dataProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataProductos.Location = new Point(38, 95);
            dataProductos.Name = "dataProductos";
            dataProductos.ReadOnly = true;
            dataProductos.RowTemplate.Height = 25;
            dataProductos.Size = new Size(848, 445);
            dataProductos.TabIndex = 59;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.BackgroundColor = Color.DarkOrange;
            btnAdd.BorderColor = Color.White;
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 1;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(38, 563);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 42);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Agregar producto";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += lblAdd_Click;
            // 
            // panelPago
            // 
            panelPago.BackColor = Color.Orange;
            panelPago.Controls.Add(txbCliente);
            panelPago.Controls.Add(btnPagar);
            panelPago.Controls.Add(txbImporte);
            panelPago.Controls.Add(txbId);
            panelPago.Controls.Add(txbEstado);
            panelPago.Dock = DockStyle.Right;
            panelPago.Location = new Point(1017, 0);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(321, 649);
            panelPago.TabIndex = 56;
            // 
            // txbCliente
            // 
            txbCliente.BackColor = Color.WhiteSmoke;
            txbCliente.BorderColor = Color.Peru;
            txbCliente.BorderSize = 1;
            txbCliente.DropDownStyle = ComboBoxStyle.DropDown;
            txbCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbCliente.ForeColor = Color.DimGray;
            txbCliente.IconColor = Color.Peru;
            txbCliente.ListBackColor = Color.FromArgb(230, 228, 245);
            txbCliente.ListTextColor = Color.DimGray;
            txbCliente.Location = new Point(13, 174);
            txbCliente.MinimumSize = new Size(200, 30);
            txbCliente.Name = "txbCliente";
            txbCliente.Padding = new Padding(1);
            txbCliente.Size = new Size(294, 30);
            txbCliente.TabIndex = 56;
            txbCliente.Texts = "ID Cliente";
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
            btnPagar.Size = new Size(321, 42);
            btnPagar.TabIndex = 55;
            btnPagar.Text = "Pagar";
            btnPagar.TextColor = Color.Black;
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // txbImporte
            // 
            txbImporte.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txbImporte.BackColor = SystemColors.Window;
            txbImporte.BorderColor = Color.Peru;
            txbImporte.BorderFocusColor = Color.Gold;
            txbImporte.BorderRadius = 0;
            txbImporte.BorderSize = 2;
            txbImporte.Enabled = false;
            txbImporte.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbImporte.ForeColor = Color.FromArgb(64, 64, 64);
            txbImporte.Location = new Point(13, 509);
            txbImporte.Margin = new Padding(4);
            txbImporte.Multiline = false;
            txbImporte.Name = "txbImporte";
            txbImporte.Padding = new Padding(10, 7, 10, 7);
            txbImporte.PasswordChar = false;
            txbImporte.PlaceholderColor = Color.DarkGray;
            txbImporte.PlaceholderText = "Importe total";
            txbImporte.Size = new Size(294, 31);
            txbImporte.TabIndex = 54;
            txbImporte.Texts = "";
            txbImporte.UnderlinedStyle = false;
            // 
            // txbId
            // 
            txbId.BackColor = SystemColors.Window;
            txbId.BorderColor = Color.Peru;
            txbId.BorderFocusColor = Color.Gold;
            txbId.BorderRadius = 0;
            txbId.BorderSize = 2;
            txbId.Enabled = false;
            txbId.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbId.ForeColor = Color.FromArgb(64, 64, 64);
            txbId.Location = new Point(13, 97);
            txbId.Margin = new Padding(4);
            txbId.Multiline = false;
            txbId.Name = "txbId";
            txbId.Padding = new Padding(10, 7, 10, 7);
            txbId.PasswordChar = false;
            txbId.PlaceholderColor = Color.DarkGray;
            txbId.PlaceholderText = "ID usuario";
            txbId.Size = new Size(295, 31);
            txbId.TabIndex = 44;
            txbId.Texts = "";
            txbId.UnderlinedStyle = false;
            // 
            // txbEstado
            // 
            txbEstado.BackColor = SystemColors.Window;
            txbEstado.BorderColor = Color.Peru;
            txbEstado.BorderFocusColor = Color.Gold;
            txbEstado.BorderRadius = 0;
            txbEstado.BorderSize = 2;
            txbEstado.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbEstado.ForeColor = Color.FromArgb(64, 64, 64);
            txbEstado.Location = new Point(13, 237);
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
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.Orange;
            lblEstado.Location = new Point(907, 235);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(104, 33);
            lblEstado.TabIndex = 50;
            lblEstado.Text = "Estado";
            // 
            // dtFecha
            // 
            dtFecha.BorderColor = Color.Peru;
            dtFecha.BorderSize = 2;
            dtFecha.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtFecha.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            dtFecha.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtFecha.Location = new Point(318, 36);
            dtFecha.MinimumSize = new Size(0, 35);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(255, 35);
            dtFecha.TabIndex = 48;
            dtFecha.TextColor = Color.Black;
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
            // lblUsario
            // 
            lblUsario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsario.AutoSize = true;
            lblUsario.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsario.ForeColor = Color.Orange;
            lblUsario.Location = new Point(903, 95);
            lblUsario.Name = "lblUsario";
            lblUsario.Size = new Size(108, 33);
            lblUsario.TabIndex = 45;
            lblUsario.Text = "Usuario";
            // 
            // lblCliente
            // 
            lblCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.Orange;
            lblCliente.Location = new Point(907, 171);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(111, 33);
            lblCliente.TabIndex = 43;
            lblCliente.Text = "Cliente";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            panelPago.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private Panel panelCentral;
        private Panel panel1;
        private Label lblEstado;
        private CustomControls.RJControls.RJTextBox txbEstado;
        private RJControls.RJDateTimePicker dtFecha;
        private Label lblFecha;
        private Label lblUsario;
        private CustomControls.RJControls.RJTextBox txbId;
        private Label lblCliente;
        private Panel panelPago;
        private Label lblPrecio;
        private CustomControls.RJControls.RJButton btnPagar;
        private CustomControls.RJControls.RJTextBox txbImporte;
        private CustomControls.RJControls.RJButton btnAdd;
        private DataGridView dataProductos;
        private CustomControls.RJControls.RJComboBox txbCliente;
    }
}