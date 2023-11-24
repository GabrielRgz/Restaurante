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
            label2 = new Label();
            label1 = new Label();
            lblPrecio = new Label();
            dataProductos = new DataGridView();
            panelPago = new Panel();
            txbNombreCliente = new CustomControls.RJControls.RJTextBox();
            txbVenta = new CustomControls.RJControls.RJTextBox();
            txbCliente = new CustomControls.RJControls.RJComboBox();
            btnPagar = new CustomControls.RJControls.RJButton();
            btnAdd = new CustomControls.RJControls.RJButton();
            txbImporte = new CustomControls.RJControls.RJTextBox();
            txbId = new CustomControls.RJControls.RJTextBox();
            dtFecha = new RJControls.RJDateTimePicker();
            lblFecha = new Label();
            lblUsario = new Label();
            lblCliente = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
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
            panelCentral.Size = new Size(1338, 614);
            panelCentral.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(dataProductos);
            panel1.Controls.Add(panelPago);
            panel1.Controls.Add(dtFecha);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblUsario);
            panel1.Controls.Add(lblCliente);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1338, 614);
            panel1.TabIndex = 51;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(984, 260);
            label2.Name = "label2";
            label2.Size = new Size(111, 33);
            label2.TabIndex = 61;
            label2.Text = "Cliente";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(955, 38);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 60;
            label1.Text = "No. Venta";
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.ForeColor = Color.Orange;
            lblPrecio.Location = new Point(976, 520);
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
            dataProductos.Size = new Size(903, 475);
            dataProductos.TabIndex = 59;
            // 
            // panelPago
            // 
            panelPago.BackColor = Color.Orange;
            panelPago.Controls.Add(txbNombreCliente);
            panelPago.Controls.Add(txbVenta);
            panelPago.Controls.Add(txbCliente);
            panelPago.Controls.Add(btnPagar);
            panelPago.Controls.Add(btnAdd);
            panelPago.Controls.Add(txbImporte);
            panelPago.Controls.Add(txbId);
            panelPago.Dock = DockStyle.Right;
            panelPago.Location = new Point(1109, 0);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(229, 614);
            panelPago.TabIndex = 56;
            // 
            // txbNombreCliente
            // 
            txbNombreCliente.BackColor = SystemColors.Window;
            txbNombreCliente.BorderColor = Color.Peru;
            txbNombreCliente.BorderFocusColor = Color.Gold;
            txbNombreCliente.BorderRadius = 0;
            txbNombreCliente.BorderSize = 2;
            txbNombreCliente.Enabled = false;
            txbNombreCliente.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombreCliente.ForeColor = Color.FromArgb(64, 64, 64);
            txbNombreCliente.Location = new Point(21, 260);
            txbNombreCliente.Margin = new Padding(4);
            txbNombreCliente.Multiline = false;
            txbNombreCliente.Name = "txbNombreCliente";
            txbNombreCliente.Padding = new Padding(10, 7, 10, 7);
            txbNombreCliente.PasswordChar = false;
            txbNombreCliente.PlaceholderColor = Color.DarkGray;
            txbNombreCliente.PlaceholderText = "Nombre del cliente";
            txbNombreCliente.Size = new Size(201, 31);
            txbNombreCliente.TabIndex = 62;
            txbNombreCliente.Texts = "";
            txbNombreCliente.UnderlinedStyle = false;
            // 
            // txbVenta
            // 
            txbVenta.BackColor = SystemColors.Window;
            txbVenta.BorderColor = Color.Peru;
            txbVenta.BorderFocusColor = Color.Gold;
            txbVenta.BorderRadius = 0;
            txbVenta.BorderSize = 2;
            txbVenta.Enabled = false;
            txbVenta.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbVenta.ForeColor = Color.FromArgb(64, 64, 64);
            txbVenta.Location = new Point(21, 40);
            txbVenta.Margin = new Padding(4);
            txbVenta.Multiline = false;
            txbVenta.Name = "txbVenta";
            txbVenta.Padding = new Padding(10, 7, 10, 7);
            txbVenta.PasswordChar = false;
            txbVenta.PlaceholderColor = Color.DarkGray;
            txbVenta.PlaceholderText = "ID venta";
            txbVenta.Size = new Size(201, 31);
            txbVenta.TabIndex = 57;
            txbVenta.Texts = "";
            txbVenta.UnderlinedStyle = false;
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
            txbCliente.Location = new Point(21, 188);
            txbCliente.MinimumSize = new Size(200, 30);
            txbCliente.Name = "txbCliente";
            txbCliente.Padding = new Padding(1);
            txbCliente.Size = new Size(200, 30);
            txbCliente.TabIndex = 56;
            txbCliente.Texts = "ID Cliente";
            txbCliente.OnSelectedIndexChanged += txbCliente_OnSelectedIndexChanged;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.DarkOrange;
            btnPagar.BackgroundColor = Color.DarkOrange;
            btnPagar.BorderColor = Color.Black;
            btnPagar.BorderRadius = 15;
            btnPagar.BorderSize = 1;
            btnPagar.Dock = DockStyle.Bottom;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.Black;
            btnPagar.Location = new Point(0, 572);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(229, 42);
            btnPagar.TabIndex = 55;
            btnPagar.Text = "Pagar";
            btnPagar.TextColor = Color.Black;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.DarkOrange;
            btnAdd.BackgroundColor = Color.DarkOrange;
            btnAdd.BorderColor = Color.Black;
            btnAdd.BorderRadius = 15;
            btnAdd.BorderSize = 1;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(17, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 137);
            btnAdd.TabIndex = 58;
            btnAdd.Text = "Agregar producto";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += lblAdd_Click;
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
            txbImporte.Location = new Point(17, 522);
            txbImporte.Margin = new Padding(4);
            txbImporte.Multiline = false;
            txbImporte.Name = "txbImporte";
            txbImporte.Padding = new Padding(10, 7, 10, 7);
            txbImporte.PasswordChar = false;
            txbImporte.PlaceholderColor = Color.DarkGray;
            txbImporte.PlaceholderText = "Importe total";
            txbImporte.Size = new Size(200, 31);
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
            txbId.Location = new Point(21, 118);
            txbId.Margin = new Padding(4);
            txbId.Multiline = false;
            txbId.Name = "txbId";
            txbId.Padding = new Padding(10, 7, 10, 7);
            txbId.PasswordChar = false;
            txbId.PlaceholderColor = Color.DarkGray;
            txbId.PlaceholderText = "ID usuario";
            txbId.Size = new Size(201, 31);
            txbId.TabIndex = 44;
            txbId.Texts = "";
            txbId.UnderlinedStyle = false;
            // 
            // dtFecha
            // 
            dtFecha.BorderColor = Color.Peru;
            dtFecha.BorderSize = 2;
            dtFecha.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtFecha.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            dtFecha.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            dtFecha.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dtFecha.Format = DateTimePickerFormat.Custom;
            dtFecha.Location = new Point(318, 36);
            dtFecha.MinimumSize = new Size(0, 35);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(182, 35);
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
            lblUsario.Location = new Point(991, 116);
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
            lblCliente.Location = new Point(959, 188);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(144, 33);
            lblCliente.TabIndex = 43;
            lblCliente.Text = "ID Cliente";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // PuntoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1338, 663);
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txbVenta;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txbNombreCliente;
    }
}