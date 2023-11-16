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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            panelOptions = new Panel();
            btnCerrar = new PictureBox();
            panelCentral = new Panel();
            dataClientes = new DataGridView();
            panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panelCentral.SuspendLayout();
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
            // panelCentral
            // 
            panelCentral.Controls.Add(dataClientes);
            panelCentral.Dock = DockStyle.Fill;
            panelCentral.Location = new Point(0, 49);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new Size(1338, 649);
            panelCentral.TabIndex = 2;
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
            dataClientes.Location = new Point(18, 18);
            dataClientes.Name = "dataClientes";
            dataClientes.ReadOnly = true;
            dataClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Gray;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
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
            dataClientes.Size = new Size(1308, 612);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Productos";
            Load += Ventas_Load;
            panelOptions.ResumeLayout(false);
            panelOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Panel panelOptions;
        private PictureBox btnCerrar;
        private Panel panelCentral;
        private DataGridView dataClientes;
    }
}