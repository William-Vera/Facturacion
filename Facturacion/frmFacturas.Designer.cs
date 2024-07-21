namespace Facturacion
{
    partial class frmFacturas
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            btnBuscarFactura = new Button();
            label5 = new Label();
            txttotal = new TextBox();
            label3 = new Label();
            txtfecha = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label1 = new Label();
            btnImprimir = new Button();
            txtcliente = new TextBox();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 603);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel1);
            tabPage2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1192, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Facturas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 468);
            panel3.TabIndex = 26;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SpringGreen;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1182, 468);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnBuscarFactura);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txttotal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtfecha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtfactura);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnImprimir);
            panel1.Controls.Add(txtcliente);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 89);
            panel1.TabIndex = 24;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CLIENTE", "EMPLEADO", "FECHA", "TOTAL" });
            comboBox1.Location = new Point(758, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 27);
            comboBox1.TabIndex = 25;
            // 
            // btnBuscarFactura
            // 
            btnBuscarFactura.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarFactura.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnBuscarFactura.Location = new Point(905, 25);
            btnBuscarFactura.Margin = new Padding(30, 3, 30, 3);
            btnBuscarFactura.Name = "btnBuscarFactura";
            btnBuscarFactura.Size = new Size(79, 35);
            btnBuscarFactura.TabIndex = 24;
            btnBuscarFactura.Text = "Buscar";
            btnBuscarFactura.UseVisualStyleBackColor = true;
            btnBuscarFactura.Click += btnBuscarFactura_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(408, 18);
            label5.Margin = new Padding(15, 0, 15, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 19);
            label5.TabIndex = 23;
            label5.Text = "Total";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Arial", 12F, FontStyle.Bold);
            txttotal.Location = new Point(403, 40);
            txttotal.Margin = new Padding(15, 3, 15, 3);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(66, 26);
            txttotal.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(247, 18);
            label3.Margin = new Padding(15, 0, 15, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 17;
            label3.Text = "Fecha";
            label3.Click += label3_Click;
            // 
            // txtfecha
            // 
            txtfecha.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtfecha.Location = new Point(243, 40);
            txtfecha.Margin = new Padding(15, 3, 15, 3);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(147, 26);
            txtfecha.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(164, 18);
            label2.Margin = new Padding(15, 0, 15, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 16;
            label2.Text = "Factura";
            // 
            // txtfactura
            // 
            txtfactura.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtfactura.Location = new Point(165, 40);
            txtfactura.Margin = new Padding(15, 3, 15, 3);
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(66, 26);
            txtfactura.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Margin = new Padding(15, 0, 15, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 15;
            label1.Text = "Cliente";
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImprimir.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnImprimir.Location = new Point(1087, 25);
            btnImprimir.Margin = new Padding(30, 3, 30, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(79, 35);
            btnImprimir.TabIndex = 18;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // txtcliente
            // 
            txtcliente.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtcliente.Location = new Point(7, 40);
            txtcliente.Margin = new Padding(15, 3, 15, 3);
            txtcliente.MaxLength = 10;
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(149, 26);
            txtcliente.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiar.Location = new Point(997, 26);
            btnLimpiar.Margin = new Padding(30, 3, 30, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(79, 35);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtBuscar.Location = new Point(553, 30);
            txtBuscar.Margin = new Padding(10, 3, 30, 3);
            txtBuscar.MaxLength = 10;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(155, 26);
            txtBuscar.TabIndex = 20;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(484, 33);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 21;
            label4.Text = "Buscar:";
            // 
            // frmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 603);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFacturas";
            Text = "frmFacturas";
            Load += frmFacturas_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label4;
        private TextBox txtBuscar;
        private Button btnLimpiar;
        private Button btnImprimir;
        private Label label3;
        private Label label2;
        private TextBox txtfecha;
        private TextBox txtfactura;
        private TextBox txtcliente;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox txttotal;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBox1;
        private Button btnBuscarFactura;
    }
}