namespace Restaurante
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnCerrar = new PictureBox();
            btnAdd = new CustomControls.RJControls.RJButton();
            dataClientes = new DataGridView();
            panelCentral = new Panel();
            panel1 = new Panel();
            lblApellido = new Label();
            txbApellido = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            btnDelete = new CustomControls.RJControls.RJButton();
            btnUpdate = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            txbNombre = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            txbTelefono = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            txbEmail = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            txbID = new CustomControls.RJControls.RJTextBox();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataClientes).BeginInit();
            panelCentral.SuspendLayout();
            panel1.SuspendLayout();
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
            lblTitulo.Size = new Size(127, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CLIENTES";
            // 
            // panelOptions
            // 
            panelOptions.BackColor = Color.Black;
            panelOptions.Controls.Add(btnCerrar);
            panelOptions.Controls.Add(lblTitulo);
            panelOptions.Dock = DockStyle.Top;
            panelOptions.Location = new Point(0, 0);
            panelOptions.Name = "panelOptions";
            panelOptions.Size = new Size(1345, 49);
            panelOptions.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Location = new Point(1319, 0);
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
            btnAdd.Location = new Point(0, 698);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(1345, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Agregar";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataClientes
            // 
            dataClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dataClientes.EnableHeadersVisualStyles = false;
            dataClientes.GridColor = Color.Black;
            dataClientes.Location = new Point(12, 19);
            dataClientes.Name = "dataClientes";
            dataClientes.ReadOnly = true;
            dataClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataClientes.RowTemplate.Height = 25;
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClientes.Size = new Size(861, 612);
            dataClientes.TabIndex = 2;
            dataClientes.CellClick += dataClientes_CellClick;
            // 
            // panelCentral
            // 
            panelCentral.Controls.Add(panel1);
            panelCentral.Controls.Add(dataClientes);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1345, 649);
            panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbTelefono);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbID);
            panel1.Location = new Point(893, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 612);
            panel1.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.Orange;
            lblApellido.Location = new Point(46, 233);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(125, 33);
            lblApellido.TabIndex = 11;
            lblApellido.Text = "Apellido";
            // 
            // txbApellido
            // 
            txbApellido.BackColor = SystemColors.Window;
            txbApellido.BorderColor = Color.Peru;
            txbApellido.BorderFocusColor = Color.Gold;
            txbApellido.BorderRadius = 0;
            txbApellido.BorderSize = 2;
            txbApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbApellido.ForeColor = Color.FromArgb(64, 64, 64);
            txbApellido.Location = new Point(46, 270);
            txbApellido.Margin = new Padding(4);
            txbApellido.Multiline = false;
            txbApellido.Name = "txbApellido";
            txbApellido.Padding = new Padding(10, 7, 10, 7);
            txbApellido.PasswordChar = false;
            txbApellido.PlaceholderColor = Color.DarkGray;
            txbApellido.PlaceholderText = "Primer apellido del cliente";
            txbApellido.Size = new Size(311, 31);
            txbApellido.TabIndex = 10;
            txbApellido.Texts = "";
            txbApellido.UnderlinedStyle = false;
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
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.DarkOrange;
            btnDelete.BackgroundColor = Color.DarkOrange;
            btnDelete.BorderColor = Color.White;
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 1;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(289, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.TextColor = Color.Black;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.BackgroundColor = Color.DarkOrange;
            btnUpdate.BorderColor = Color.White;
            btnUpdate.BorderRadius = 15;
            btnUpdate.BorderSize = 1;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(13, 537);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 42);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Editar";
            btnUpdate.TextColor = Color.Black;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(46, 144);
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
            txbNombre.Location = new Point(46, 181);
            txbNombre.Margin = new Padding(4);
            txbNombre.Multiline = false;
            txbNombre.Name = "txbNombre";
            txbNombre.Padding = new Padding(10, 7, 10, 7);
            txbNombre.PasswordChar = false;
            txbNombre.PlaceholderColor = Color.DarkGray;
            txbNombre.PlaceholderText = "Nombre del Cliente";
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
            label3.Location = new Point(41, 413);
            label3.Name = "label3";
            label3.Size = new Size(128, 33);
            label3.TabIndex = 5;
            label3.Text = "Telefono";
            // 
            // txbTelefono
            // 
            txbTelefono.BackColor = SystemColors.Window;
            txbTelefono.BorderColor = Color.Peru;
            txbTelefono.BorderFocusColor = Color.Gold;
            txbTelefono.BorderRadius = 0;
            txbTelefono.BorderSize = 2;
            txbTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            txbTelefono.Location = new Point(46, 450);
            txbTelefono.Margin = new Padding(4);
            txbTelefono.Multiline = false;
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Padding = new Padding(10, 7, 10, 7);
            txbTelefono.PasswordChar = false;
            txbTelefono.PlaceholderColor = Color.DarkGray;
            txbTelefono.PlaceholderText = "Telefono del Cliente";
            txbTelefono.Size = new Size(311, 31);
            txbTelefono.TabIndex = 4;
            txbTelefono.Texts = "";
            txbTelefono.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(46, 317);
            label2.Name = "label2";
            label2.Size = new Size(94, 33);
            label2.TabIndex = 3;
            label2.Text = "E-mail";
            // 
            // txbEmail
            // 
            txbEmail.BackColor = SystemColors.Window;
            txbEmail.BorderColor = Color.Peru;
            txbEmail.BorderFocusColor = Color.Gold;
            txbEmail.BorderRadius = 0;
            txbEmail.BorderSize = 2;
            txbEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txbEmail.Location = new Point(46, 354);
            txbEmail.Margin = new Padding(4);
            txbEmail.Multiline = false;
            txbEmail.Name = "txbEmail";
            txbEmail.Padding = new Padding(10, 7, 10, 7);
            txbEmail.PasswordChar = false;
            txbEmail.PlaceholderColor = Color.DarkGray;
            txbEmail.PlaceholderText = "Correo del Cliente";
            txbEmail.Size = new Size(311, 31);
            txbEmail.TabIndex = 2;
            txbEmail.Texts = "";
            txbEmail.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(46, 53);
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
            txbID.Location = new Point(46, 90);
            txbID.Margin = new Padding(4);
            txbID.Multiline = false;
            txbID.Name = "txbID";
            txbID.Padding = new Padding(10, 7, 10, 7);
            txbID.PasswordChar = false;
            txbID.PlaceholderColor = Color.DarkGray;
            txbID.PlaceholderText = "ID del Cliente";
            txbID.Size = new Size(311, 31);
            txbID.TabIndex = 0;
            txbID.Texts = "";
            txbID.UnderlinedStyle = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1345, 740);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataClientes).EndInit();
            panelCentral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private CustomControls.RJControls.RJButton btnAdd;
        private PictureBox btnCerrar;
        private DataGridView dataClientes;
        private Panel panelCentral;
        private Panel panel1;
        private Label label5;
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnUpdate;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txbNombre;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txbTelefono;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txbEmail;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txbID;
        private Label lblApellido;
        private CustomControls.RJControls.RJTextBox txbApellido;
    }
}