using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Restaurante
{
    partial class Usuarios
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
            panelCentral = new Panel();
            dataUsuarios = new DataGridView();
            panel1 = new Panel();
            label7 = new Label();
            txbRol = new CustomControls.RJControls.RJTextBox();
            label6 = new Label();
            txbApellido = new CustomControls.RJControls.RJTextBox();
            label5 = new Label();
            btnDelete = new CustomControls.RJControls.RJButton();
            btnUpdate = new CustomControls.RJControls.RJButton();
            label4 = new Label();
            txbUsuario = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            txbNombre = new CustomControls.RJControls.RJTextBox();
            label2 = new Label();
            txbContrasena = new CustomControls.RJControls.RJTextBox();
            label1 = new Label();
            txbID = new CustomControls.RJControls.RJTextBox();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).BeginInit();
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
            lblTitulo.Size = new Size(118, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Usuarios";
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
            // panelCentral
            // 
            panelCentral.Controls.Add(dataUsuarios);
            panelCentral.Controls.Add(panel1);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1338, 607);
            panelCentral.TabIndex = 3;
            // 
            // dataUsuarios
            // 
            dataUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 64, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dataUsuarios.EnableHeadersVisualStyles = false;
            dataUsuarios.GridColor = Color.Black;
            dataUsuarios.Location = new Point(18, 18);
            dataUsuarios.Name = "dataUsuarios";
            dataUsuarios.ReadOnly = true;
            dataUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.LightGray;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataUsuarios.RowTemplate.Height = 25;
            dataUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataUsuarios.Size = new Size(880, 589);
            dataUsuarios.TabIndex = 4;
            dataUsuarios.CellClick += dataUsuarios_CellClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(30, 30, 31);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txbRol);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbApellido);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txbNombre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbContrasena);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbID);
            panel1.Location = new Point(886, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 570);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Orange;
            label7.Location = new Point(59, 101);
            label7.Name = "label7";
            label7.Size = new Size(55, 33);
            label7.TabIndex = 13;
            label7.Text = "Rol";
            // 
            // txbRol
            // 
            txbRol.BackColor = SystemColors.Window;
            txbRol.BorderColor = Color.Peru;
            txbRol.BorderFocusColor = Color.Gold;
            txbRol.BorderRadius = 0;
            txbRol.BorderSize = 2;
            txbRol.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbRol.ForeColor = Color.FromArgb(64, 64, 64);
            txbRol.Location = new Point(59, 138);
            txbRol.Margin = new Padding(4);
            txbRol.Multiline = false;
            txbRol.Name = "txbRol";
            txbRol.Padding = new Padding(10, 7, 10, 7);
            txbRol.PasswordChar = false;
            txbRol.PlaceholderColor = Color.DarkGray;
            txbRol.PlaceholderText = "";
            txbRol.Size = new Size(311, 31);
            txbRol.TabIndex = 12;
            txbRol.Texts = "";
            txbRol.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Orange;
            label6.Location = new Point(59, 423);
            label6.Name = "label6";
            label6.Size = new Size(125, 33);
            label6.TabIndex = 11;
            label6.Text = "Apellido";
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
            txbApellido.Location = new Point(59, 460);
            txbApellido.Margin = new Padding(4);
            txbApellido.Multiline = false;
            txbApellido.Name = "txbApellido";
            txbApellido.Padding = new Padding(10, 7, 10, 7);
            txbApellido.PasswordChar = false;
            txbApellido.PlaceholderColor = Color.DarkGray;
            txbApellido.PlaceholderText = "";
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
            label5.Location = new Point(163, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 33);
            label5.TabIndex = 9;
            label5.Text = "Datos";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOrange;
            btnDelete.BackgroundColor = Color.DarkOrange;
            btnDelete.BorderColor = Color.White;
            btnDelete.BorderRadius = 15;
            btnDelete.BorderSize = 1;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(286, 516);
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
            btnUpdate.BackColor = Color.DarkOrange;
            btnUpdate.BackgroundColor = Color.DarkOrange;
            btnUpdate.BorderColor = Color.White;
            btnUpdate.BorderRadius = 15;
            btnUpdate.BorderSize = 1;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(28, 516);
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
            label4.Location = new Point(59, 187);
            label4.Name = "label4";
            label4.Size = new Size(266, 33);
            label4.TabIndex = 7;
            label4.Text = "Nombre de usuario";
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
            txbUsuario.Location = new Point(59, 224);
            txbUsuario.Margin = new Padding(4);
            txbUsuario.Multiline = false;
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Padding = new Padding(10, 7, 10, 7);
            txbUsuario.PasswordChar = false;
            txbUsuario.PlaceholderColor = Color.DarkGray;
            txbUsuario.PlaceholderText = "";
            txbUsuario.Size = new Size(311, 31);
            txbUsuario.TabIndex = 6;
            txbUsuario.Texts = "";
            txbUsuario.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(59, 351);
            label3.Name = "label3";
            label3.Size = new Size(123, 33);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
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
            txbNombre.Location = new Point(59, 388);
            txbNombre.Margin = new Padding(4);
            txbNombre.Multiline = false;
            txbNombre.Name = "txbNombre";
            txbNombre.Padding = new Padding(10, 7, 10, 7);
            txbNombre.PasswordChar = false;
            txbNombre.PlaceholderColor = Color.DarkGray;
            txbNombre.PlaceholderText = "";
            txbNombre.Size = new Size(311, 31);
            txbNombre.TabIndex = 4;
            txbNombre.Texts = "";
            txbNombre.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(59, 269);
            label2.Name = "label2";
            label2.Size = new Size(169, 33);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txbContrasena
            // 
            txbContrasena.BackColor = SystemColors.Window;
            txbContrasena.BorderColor = Color.Peru;
            txbContrasena.BorderFocusColor = Color.Gold;
            txbContrasena.BorderRadius = 0;
            txbContrasena.BorderSize = 2;
            txbContrasena.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txbContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            txbContrasena.Location = new Point(59, 316);
            txbContrasena.Margin = new Padding(4);
            txbContrasena.Multiline = false;
            txbContrasena.Name = "txbContrasena";
            txbContrasena.Padding = new Padding(10, 7, 10, 7);
            txbContrasena.PasswordChar = false;
            txbContrasena.PlaceholderColor = Color.DarkGray;
            txbContrasena.PlaceholderText = "";
            txbContrasena.Size = new Size(311, 31);
            txbContrasena.TabIndex = 2;
            txbContrasena.Texts = "";
            txbContrasena.UnderlinedStyle = false;
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
            txbID.PlaceholderText = "";
            txbID.Size = new Size(311, 31);
            txbID.TabIndex = 0;
            txbID.Texts = "";
            txbID.UnderlinedStyle = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1338, 698);
            Controls.Add(panelCentral);
            Controls.Add(panelOptions);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios";
            Text = "Clientes";
            Load += Clientes_Load;
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CustomControls.RJControls.RJTextBox txbUsuario;
        private Label label3;
        private CustomControls.RJControls.RJTextBox txbNombre;
        private Label label2;
        private CustomControls.RJControls.RJTextBox txbContrasena;
        private Label label1;
        private CustomControls.RJControls.RJTextBox txbID;
        private Label label6;
        private CustomControls.RJControls.RJTextBox txbApellido;
        private Label label7;
        private CustomControls.RJControls.RJTextBox txbRol;
        private DataGridView dataUsuarios;
    }
}