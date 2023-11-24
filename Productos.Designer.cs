namespace Restaurante
{
    partial class Productos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnAdd = new CustomControls.RJControls.RJButton();
            panelCentral = new Panel();
            panel1 = new Panel();
            txbCategoria = new CustomControls.RJControls.RJComboBox();
            label6 = new Label();
            label5 = new Label();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            txbNombre = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            txbPrecio = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            txbDescripcion = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            txbID = new CustomControls.RJControls.RJTextBox();
            dataProductos = new DataGridView();
            conexionBindingSource = new BindingSource(components);
            panelOptions.SuspendLayout();
            panelCentral.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
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
            lblTitulo.Size = new Size(176, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PRODUCTOS";
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Black;
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1386, 49);
            panelOptions.TabIndex = 1;
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
            btnAdd.Size = new Size(1386, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panel1);
            panelCentral.Controls.Add(dataProductos);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1386, 607);
            panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
            panel1.Controls.Add(txbCategoria);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rjButton2);
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbPrecio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbDescripcion);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbID);
            panel1.Location = new Point(902, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 570);
            panel1.TabIndex = 5;
            // 
            // txbCategoria
            // 
            txbCategoria.BackColor = Color.WhiteSmoke;
            txbCategoria.BorderColor = Color.Peru;
            txbCategoria.BorderSize = 1;
            txbCategoria.DropDownStyle = ComboBoxStyle.DropDown;
            txbCategoria.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txbCategoria.ForeColor = Color.DimGray;
            txbCategoria.IconColor = Color.Peru;
            txbCategoria.Items.AddRange(new object[] { "Comida rapida", "Antojitos Mexicanos", "Comida Vegana", "None" });
            txbCategoria.ListBackColor = Color.FromArgb(230, 228, 245);
            txbCategoria.ListTextColor = Color.DimGray;
            txbCategoria.Location = new Point(59, 408);
            txbCategoria.MinimumSize = new Size(200, 30);
            txbCategoria.Name = "txbCategoria";
            txbCategoria.Padding = new Padding(1);
            txbCategoria.Size = new Size(311, 30);
            txbCategoria.TabIndex = 12;
            txbCategoria.Texts = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(59, 354);
            label6.Name = "label6";
            label6.Size = new Size(151, 33);
            label6.TabIndex = 11;
            label6.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Orange;
            label5.Location = new Point(164, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 33);
            label5.TabIndex = 9;
            label5.Text = "Datos";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.DarkOrange;
            rjButton2.BackgroundColor = Color.DarkOrange;
            rjButton2.BorderColor = Color.White;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 1;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(325, 516);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(127, 42);
            rjButton2.TabIndex = 8;
            rjButton2.Text = "Eliminar";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DarkOrange;
            rjButton1.BackgroundColor = Color.DarkOrange;
            rjButton1.BorderColor = Color.White;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 1;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(13, 516);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(127, 42);
            rjButton1.TabIndex = 4;
            rjButton1.Text = "Editar";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(59, 101);
            label4.Name = "label4";
            label4.Size = new Size(123, 33);
            label4.TabIndex = 7;
            label4.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.BackColor = SystemColors.Window;
            txbNombre.BorderColor = Color.Peru;
            txbNombre.BorderFocusColor = Color.Gold;
            txbNombre.BorderRadius = 0;
            txbNombre.BorderSize = 2;
            txbNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbNombre.ForeColor = Color.FromArgb(64, 64, 64);
            txbNombre.Location = new Point(59, 138);
            txbNombre.Margin = new Padding(4);
            txbNombre.Multiline = false;
            txbNombre.Name = "txbNombre";
            txbNombre.Padding = new Padding(10, 7, 10, 7);
            txbNombre.PasswordChar = false;
            txbNombre.PlaceholderColor = Color.DarkGray;
            txbNombre.PlaceholderText = "Nombre del producto";
            txbNombre.Size = new Size(311, 31);
            txbNombre.TabIndex = 6;
            txbNombre.Texts = "";
            txbNombre.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(59, 272);
            label3.Name = "label3";
            label3.Size = new Size(98, 33);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // txbPrecio
            // 
            txbPrecio.BackColor = SystemColors.Window;
            txbPrecio.BorderColor = Color.Peru;
            txbPrecio.BorderFocusColor = Color.Gold;
            txbPrecio.BorderRadius = 0;
            txbPrecio.BorderSize = 2;
            txbPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbPrecio.ForeColor = Color.FromArgb(64, 64, 64);
            txbPrecio.Location = new Point(59, 309);
            txbPrecio.Margin = new Padding(4);
            txbPrecio.Multiline = false;
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Padding = new Padding(10, 7, 10, 7);
            txbPrecio.PasswordChar = false;
            txbPrecio.PlaceholderColor = Color.DarkGray;
            txbPrecio.PlaceholderText = "Precio del Producto";
            txbPrecio.Size = new Size(311, 31);
            txbPrecio.TabIndex = 4;
            txbPrecio.Texts = "";
            txbPrecio.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(59, 189);
            label2.Name = "label2";
            label2.Size = new Size(169, 33);
            label2.TabIndex = 3;
            label2.Text = "Descripción";
            // 
            // txbDescripcion
            // 
            txbDescripcion.BackColor = SystemColors.Window;
            txbDescripcion.BorderColor = Color.Peru;
            txbDescripcion.BorderFocusColor = Color.Gold;
            txbDescripcion.BorderRadius = 0;
            txbDescripcion.BorderSize = 2;
            txbDescripcion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            txbDescripcion.Location = new Point(59, 226);
            txbDescripcion.Margin = new Padding(4);
            txbDescripcion.Multiline = false;
            txbDescripcion.Name = "txbDescripcion";
            txbDescripcion.Padding = new Padding(10, 7, 10, 7);
            txbDescripcion.PasswordChar = false;
            txbDescripcion.PlaceholderColor = Color.DarkGray;
            txbDescripcion.PlaceholderText = "Descripcion del Producto";
            txbDescripcion.Size = new Size(311, 31);
            txbDescripcion.TabIndex = 2;
            txbDescripcion.Texts = "";
            txbDescripcion.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(41, 33);
            label1.TabIndex = 1;
            label1.Text = "ID";
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
            txbID.Location = new Point(59, 66);
            txbID.Margin = new Padding(4);
            txbID.Multiline = false;
            txbID.Name = "txbID";
            txbID.Padding = new Padding(10, 7, 10, 7);
            txbID.PasswordChar = false;
            txbID.PlaceholderColor = Color.DarkGray;
            txbID.PlaceholderText = "ID del Producto";
            txbID.Size = new Size(311, 31);
            txbID.TabIndex = 0;
            txbID.Texts = "";
            txbID.UnderlinedStyle = false;
            // 
            // dataProductos
            // 
            dataProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataProductos.EnableHeadersVisualStyles = false;
            dataProductos.GridColor = Color.Black;
            dataProductos.Location = new Point(18, 18);
            dataProductos.Name = "dataProductos";
            dataProductos.ReadOnly = true;
            dataProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataProductos.RowTemplate.Height = 25;
            dataProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProductos.Size = new Size(865, 570);
            dataProductos.TabIndex = 4;
            dataProductos.CellClick += dataProductos_CellClick;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Conexion);
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1386, 698);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            panelCentral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private CustomControls.RJControls.RJButton btnAdd;
        private Panel panelCentral;
        private Panel panel1;
        private Label label5;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txbNombre;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txbPrecio;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txbDescripcion;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txbID;
        private DataGridView dataProductos;
        private Label label6;
        private BindingSource conexionBindingSource;
        private CustomControls.RJControls.RJComboBox txbCategoria;
    }
}