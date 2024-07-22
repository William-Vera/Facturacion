namespace Facturacion
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            dataGridView1 = new DataGridView();
            clCliente = new DataGridViewTextBoxColumn();
            clProducto = new DataGridViewTextBoxColumn();
            clCantidad = new DataGridViewTextBoxColumn();
            clPrecio = new DataGridViewTextBoxColumn();
            clSubtotal = new DataGridViewTextBoxColumn();
            cliva = new DataGridViewTextBoxColumn();
            clTotal = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clCliente, clProducto, clCantidad, clPrecio, clSubtotal, cliva, clTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1112, 441);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clCliente
            // 
            clCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clCliente.HeaderText = "CLIENTE";
            clCliente.Name = "clCliente";
            clCliente.ReadOnly = true;
            // 
            // clProducto
            // 
            clProducto.HeaderText = "PRODUCTO";
            clProducto.Name = "clProducto";
            clProducto.ReadOnly = true;
            // 
            // clCantidad
            // 
            clCantidad.HeaderText = "CANTIDAD";
            clCantidad.Name = "clCantidad";
            clCantidad.ReadOnly = true;
            // 
            // clPrecio
            // 
            clPrecio.HeaderText = "PRECIO";
            clPrecio.Name = "clPrecio";
            clPrecio.ReadOnly = true;
            // 
            // clSubtotal
            // 
            clSubtotal.HeaderText = "SUBTOTAL";
            clSubtotal.Name = "clSubtotal";
            clSubtotal.ReadOnly = true;
            // 
            // cliva
            // 
            cliva.HeaderText = "IVA";
            cliva.Name = "cliva";
            cliva.ReadOnly = true;
            // 
            // clTotal
            // 
            clTotal.HeaderText = "TOTAL";
            clTotal.Name = "clTotal";
            clTotal.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(689, 38);
            button1.Name = "button1";
            button1.Size = new Size(120, 33);
            button1.TabIndex = 1;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.AutoSize = true;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(830, 38);
            button2.Name = "button2";
            button2.Size = new Size(120, 33);
            button2.TabIndex = 2;
            button2.Text = "Deshacer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold);
            button3.Location = new Point(962, 38);
            button3.Name = "button3";
            button3.Size = new Size(128, 33);
            button3.TabIndex = 3;
            button3.Text = "Realizar Venta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 27);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Times New Roman", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(205, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 27);
            comboBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 12F);
            dateTimePicker1.Location = new Point(461, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 26);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(354, 46);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 26);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(62, 19);
            label1.TabIndex = 9;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(205, 24);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 10;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(350, 24);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 11;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(460, 24);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 12;
            label4.Text = "Fecha";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "tanjiro-kamado-de-kimetsu-no-yaiba_3840x2160_xtrafondos.com.jpg");
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 103);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1116, 445);
            panel2.TabIndex = 14;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 548);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn clCliente;
        private DataGridViewTextBoxColumn clProducto;
        private DataGridViewTextBoxColumn clCantidad;
        private DataGridViewTextBoxColumn clPrecio;
        private DataGridViewTextBoxColumn clSubtotal;
        private DataGridViewTextBoxColumn cliva;
        private DataGridViewTextBoxColumn clTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private ImageList imageList1;
        private Panel panel1;
        private Panel panel2;
    }
}