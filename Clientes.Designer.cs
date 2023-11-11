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
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnCerrar = new PictureBox();
            btnAdd = new CustomControls.RJControls.RJButton();
            dataClientes = new DataGridView();
            panelCentral = new Panel();
            panel1 = new Panel();
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
            panelOptions.Size = new Size(1338, 49);
            panelOptions.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Location = new Point(1312, 0);
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
            btnAdd.Size = new Size(1338, 42);
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
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClientes.Location = new Point(12, 19);
            dataClientes.Name = "dataClientes";
            dataClientes.ReadOnly = true;
            dataClientes.RowTemplate.Height = 25;
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClientes.Size = new Size(854, 570);
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
            panelCentral.Size = new Size(1338, 607);
            panelCentral.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
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
            panel1.Location = new Point(886, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 570);
            panel1.TabIndex = 3;
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
            btnDelete.BackColor = Color.DarkOrange;
            btnDelete.BackgroundColor = Color.DarkOrange;
            btnDelete.BorderColor = Color.PaleVioletRed;
            btnDelete.BorderRadius = 0;
            btnDelete.BorderSize = 0;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(286, 516);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 42);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Eliminar";
            btnDelete.TextColor = Color.White;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.BackgroundColor = Color.DarkOrange;
            btnUpdate.BorderColor = Color.PaleVioletRed;
            btnUpdate.BorderRadius = 0;
            btnUpdate.BorderSize = 0;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(13, 516);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 42);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Editar";
            btnUpdate.TextColor = Color.White;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Orange;
            label4.Location = new Point(17, 205);
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
            txbNombre.Location = new Point(147, 207);
            txbNombre.Margin = new Padding(4);
            txbNombre.Multiline = false;
            txbNombre.Name = "txbNombre";
            txbNombre.Padding = new Padding(10, 7, 10, 7);
            txbNombre.PasswordChar = false;
            txbNombre.PlaceholderColor = Color.DarkGray;
            txbNombre.PlaceholderText = "";
            txbNombre.Size = new Size(250, 31);
            txbNombre.TabIndex = 6;
            txbNombre.Texts = "";
            txbNombre.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(17, 323);
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
            txbTelefono.Location = new Point(147, 325);
            txbTelefono.Margin = new Padding(4);
            txbTelefono.Multiline = false;
            txbTelefono.Name = "txbTelefono";
            txbTelefono.Padding = new Padding(10, 7, 10, 7);
            txbTelefono.PasswordChar = false;
            txbTelefono.PlaceholderColor = Color.DarkGray;
            txbTelefono.PlaceholderText = "";
            txbTelefono.Size = new Size(250, 31);
            txbTelefono.TabIndex = 4;
            txbTelefono.Texts = "";
            txbTelefono.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(46, 266);
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
            txbEmail.Location = new Point(147, 268);
            txbEmail.Margin = new Padding(4);
            txbEmail.Multiline = false;
            txbEmail.Name = "txbEmail";
            txbEmail.Padding = new Padding(10, 7, 10, 7);
            txbEmail.PasswordChar = false;
            txbEmail.PlaceholderColor = Color.DarkGray;
            txbEmail.PlaceholderText = "";
            txbEmail.Size = new Size(250, 31);
            txbEmail.TabIndex = 2;
            txbEmail.Texts = "";
            txbEmail.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(99, 147);
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
            txbID.Location = new Point(147, 149);
            txbID.Margin = new Padding(4);
            txbID.Multiline = false;
            txbID.Name = "txbID";
            txbID.Padding = new Padding(10, 7, 10, 7);
            txbID.PasswordChar = false;
            txbID.PlaceholderColor = Color.DarkGray;
            txbID.PlaceholderText = "";
            txbID.Size = new Size(250, 31);
            txbID.TabIndex = 0;
            txbID.Texts = "";
            txbID.UnderlinedStyle = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1338, 698);
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
    }
}