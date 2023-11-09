namespace Restaurante
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnCerrar = new PictureBox();
            btnAdd = new CustomControls.RJControls.RJButton();
            panelCentral = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            txbEstado = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            btnDelete = new CustomControls.RJControls.RJButton();
            btnUpdate = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            txbCliente = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            txbFecha = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            txbUsuario = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            txbID = new CustomControls.RJControls.RJTextBox();
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
            lblTitulo.Size = new Size(111, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "VENTAS";
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
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1312, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(26, 49);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 24;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            btnCerrar.MouseEnter += btnCerrar_MouseEnter;
            btnCerrar.MouseLeave += btnCerrar_MouseLeave;
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
            // panelCentral
            // 
            panelCentral.Controls.Add(panel1);
            panelCentral.Controls.Add(dataClientes);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1338, 607);
            panelCentral.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbEstado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbFecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbID);
            panel1.Location = new Point(892, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 570);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(36, 379);
            label6.Name = "label6";
            label6.Size = new Size(104, 33);
            label6.TabIndex = 11;
            label6.Text = "Estado";
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
            txbEstado.Location = new Point(147, 381);
            txbEstado.Margin = new Padding(4);
            txbEstado.Multiline = false;
            txbEstado.Name = "txbEstado";
            txbEstado.Padding = new Padding(10, 7, 10, 7);
            txbEstado.PasswordChar = false;
            txbEstado.PlaceholderColor = Color.DarkGray;
            txbEstado.PlaceholderText = "";
            txbEstado.Size = new Size(250, 31);
            txbEstado.TabIndex = 10;
            txbEstado.Texts = "";
            txbEstado.UnderlinedStyle = false;
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
            label4.Location = new Point(-4, 207);
            label4.Name = "label4";
            label4.Size = new Size(144, 33);
            label4.TabIndex = 7;
            label4.Text = "ID Cliente";
            // 
            // txbCliente
            // 
            txbCliente.BackColor = SystemColors.Window;
            txbCliente.BorderColor = Color.Peru;
            txbCliente.BorderFocusColor = Color.Gold;
            txbCliente.BorderRadius = 0;
            txbCliente.BorderSize = 2;
            txbCliente.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbCliente.ForeColor = Color.FromArgb(64, 64, 64);
            txbCliente.Location = new Point(147, 207);
            txbCliente.Margin = new Padding(4);
            txbCliente.Multiline = false;
            txbCliente.Name = "txbCliente";
            txbCliente.Padding = new Padding(10, 7, 10, 7);
            txbCliente.PasswordChar = false;
            txbCliente.PlaceholderColor = Color.DarkGray;
            txbCliente.PlaceholderText = "";
            txbCliente.Size = new Size(250, 31);
            txbCliente.TabIndex = 6;
            txbCliente.Texts = "";
            txbCliente.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(43, 325);
            label3.Name = "label3";
            label3.Size = new Size(97, 33);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // txbFecha
            // 
            txbFecha.BackColor = SystemColors.Window;
            txbFecha.BorderColor = Color.Peru;
            txbFecha.BorderFocusColor = Color.Gold;
            txbFecha.BorderRadius = 0;
            txbFecha.BorderSize = 2;
            txbFecha.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbFecha.ForeColor = Color.FromArgb(64, 64, 64);
            txbFecha.Location = new Point(147, 325);
            txbFecha.Margin = new Padding(4);
            txbFecha.Multiline = false;
            txbFecha.Name = "txbFecha";
            txbFecha.Padding = new Padding(10, 7, 10, 7);
            txbFecha.PasswordChar = false;
            txbFecha.PlaceholderColor = Color.DarkGray;
            txbFecha.PlaceholderText = "";
            txbFecha.Size = new Size(250, 31);
            txbFecha.TabIndex = 4;
            txbFecha.Texts = "";
            txbFecha.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(-1, 266);
            label2.Name = "label2";
            label2.Size = new Size(141, 33);
            label2.TabIndex = 3;
            label2.Text = "ID Usuario";
            // 
            // txbUsuario
            // 
            txbUsuario.BackColor = SystemColors.Window;
            txbUsuario.BorderColor = Color.Peru;
            txbUsuario.BorderFocusColor = Color.Gold;
            txbUsuario.BorderRadius = 0;
            txbUsuario.BorderSize = 2;
            txbUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            txbUsuario.Location = new Point(147, 268);
            txbUsuario.Margin = new Padding(4);
            txbUsuario.Multiline = false;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Padding = new Padding(10, 7, 10, 7);
            txbUsuario.PasswordChar = false;
            txbUsuario.PlaceholderColor = Color.DarkGray;
            txbUsuario.PlaceholderText = "";
            txbUsuario.Size = new Size(250, 31);
            txbUsuario.TabIndex = 2;
            txbUsuario.Texts = "";
            txbUsuario.UnderlinedStyle = false;
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
            // dataClientes
            // 
            dataClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClientes.Location = new Point(18, 18);
            dataClientes.Name = "dataClientes";
            dataClientes.ReadOnly = true;
            dataClientes.RowTemplate.Height = 25;
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClientes.Size = new Size(854, 570);
            dataClientes.TabIndex = 4;
            dataClientes.CellClick += dataClientes_CellClick;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1338, 698);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Productos";
            Load += Ventas_Load;
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
        private CustomControls.RJControls.RJButton btnDelete;
        private CustomControls.RJControls.RJButton btnUpdate;
        private Label label4;
        private CustomControls.RJControls.RJTextBox txbCliente;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txbFecha;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txbUsuario;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txbID;
        private DataGridView dataClientes;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txbEstado;
    }
}