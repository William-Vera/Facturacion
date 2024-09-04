namespace Facturacion
{
    partial class frmProductos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            dgvAggProductos = new DataGridView();
            panel1 = new Panel();
            label4 = new Label();
            comboBox4 = new ComboBox();
            comboBox1 = new ComboBox();
            btnBuscar = new Button();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnAggProductos = new Button();
            txtPrecioProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtBuscarProducto = new TextBox();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dgvEditar = new DataGridView();
            panel3 = new Panel();
            label8 = new Label();
            comboBox5 = new ComboBox();
            comboBox2 = new ComboBox();
            btnBuscarEditar = new Button();
            btnEditar = new Button();
            txtPrecioEdit = new TextBox();
            label6 = new Label();
            btnLimpiarEditar = new Button();
            label7 = new Label();
            label5 = new Label();
            txtNombreProEdi = new TextBox();
            txtBuscarEditar = new TextBox();
            tabPage3 = new TabPage();
            panel6 = new Panel();
            dgvEliminar = new DataGridView();
            panel5 = new Panel();
            label11 = new Label();
            comboBox6 = new ComboBox();
            comboBox3 = new ComboBox();
            btnBuscarEliminar = new Button();
            btnLimpiarEliminar = new Button();
            label12 = new Label();
            btnEliminar = new Button();
            label10 = new Label();
            label9 = new Label();
            txtPrecioeliminar = new TextBox();
            txtNombreEliminar = new TextBox();
            txtBuscarEliminar = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAggProductos).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditar).BeginInit();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEliminar).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Bold);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 450);
            tabControl1.TabIndex = 0;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1192, 418);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dgvAggProductos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 308);
            panel2.TabIndex = 34;
            // 
            // dgvAggProductos
            // 
            dgvAggProductos.AllowUserToAddRows = false;
            dgvAggProductos.AllowUserToDeleteRows = false;
            dgvAggProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAggProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAggProductos.Dock = DockStyle.Fill;
            dgvAggProductos.Location = new Point(0, 0);
            dgvAggProductos.Name = "dgvAggProductos";
            dgvAggProductos.ReadOnly = true;
            dgvAggProductos.ScrollBars = ScrollBars.Vertical;
            dgvAggProductos.Size = new Size(1178, 304);
            dgvAggProductos.TabIndex = 22;
            dgvAggProductos.CellClick += dgvAggProductos_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnAggProductos);
            panel1.Controls.Add(txtPrecioProducto);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(txtBuscarProducto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 100);
            panel1.TabIndex = 33;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(316, 15);
            label4.Name = "label4";
            label4.Size = new Size(89, 19);
            label4.TabIndex = 36;
            label4.Text = "Proveedor";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(316, 37);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(152, 27);
            comboBox4.TabIndex = 35;
            comboBox4.DropDown += comboBox4_DropDown;
            comboBox4.KeyDown += comboBox4_KeyDown;
            comboBox4.Leave += comboBox4_Leave;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Right;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NOMBRE", "PRECIO_UNITARIO", "PROVEEDOR" });
            comboBox1.Location = new Point(745, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 27);
            comboBox1.TabIndex = 34;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(915, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(77, 35);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(1003, 29);
            button1.Name = "button1";
            button1.Size = new Size(77, 35);
            button1.TabIndex = 30;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(206, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 28;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(474, 37);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 32;
            label1.Text = "Buscar:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(8, 15);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 27;
            label3.Text = "Nombre";
            // 
            // btnAggProductos
            // 
            btnAggProductos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAggProductos.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggProductos.Location = new Point(1091, 29);
            btnAggProductos.Name = "btnAggProductos";
            btnAggProductos.Size = new Size(77, 35);
            btnAggProductos.TabIndex = 29;
            btnAggProductos.Text = "Agregar";
            btnAggProductos.UseVisualStyleBackColor = true;
            btnAggProductos.Click += btnAggProductos_Click;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Anchor = AnchorStyles.Left;
            txtPrecioProducto.Font = new Font("Times New Roman", 12F);
            txtPrecioProducto.Location = new Point(201, 37);
            txtPrecioProducto.MaxLength = 8;
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(94, 26);
            txtPrecioProducto.TabIndex = 25;
            txtPrecioProducto.KeyPress += textBox2_KeyPress;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Anchor = AnchorStyles.Left;
            txtNombreProducto.Font = new Font("Times New Roman", 12F);
            txtNombreProducto.Location = new Point(8, 37);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(174, 26);
            txtNombreProducto.TabIndex = 24;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Font = new Font("Times New Roman", 12F);
            txtBuscarProducto.Location = new Point(544, 33);
            txtBuscarProducto.MaxLength = 10;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(160, 26);
            txtBuscarProducto.TabIndex = 31;
            txtBuscarProducto.KeyPress += txtBuscarProducto_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1192, 418);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dgvEditar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(1182, 308);
            panel4.TabIndex = 35;
            // 
            // dgvEditar
            // 
            dgvEditar.AllowUserToAddRows = false;
            dgvEditar.AllowUserToDeleteRows = false;
            dgvEditar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditar.Dock = DockStyle.Fill;
            dgvEditar.Location = new Point(0, 0);
            dgvEditar.Name = "dgvEditar";
            dgvEditar.ReadOnly = true;
            dgvEditar.ScrollBars = ScrollBars.Vertical;
            dgvEditar.Size = new Size(1178, 304);
            dgvEditar.TabIndex = 22;
            dgvEditar.CellClick += dgvEditar_CellClick;
            dgvEditar.CellContentClick += dgvEditar_CellContentClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBox5);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(btnBuscarEditar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(txtPrecioEdit);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(btnLimpiarEditar);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtNombreProEdi);
            panel3.Controls.Add(txtBuscarEditar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 100);
            panel3.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(316, 15);
            label8.Name = "label8";
            label8.Size = new Size(89, 19);
            label8.TabIndex = 38;
            label8.Text = "Proveedor";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(316, 37);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(152, 27);
            comboBox5.TabIndex = 37;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Right;
            comboBox2.Font = new Font("Times New Roman", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "NOMBRE", "PRECIO_UNITARIO", "PROVEEDOR" });
            comboBox2.Location = new Point(745, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 27);
            comboBox2.TabIndex = 36;
            // 
            // btnBuscarEditar
            // 
            btnBuscarEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarEditar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnBuscarEditar.Location = new Point(915, 29);
            btnBuscarEditar.Name = "btnBuscarEditar";
            btnBuscarEditar.Size = new Size(77, 35);
            btnBuscarEditar.TabIndex = 35;
            btnBuscarEditar.Text = "Buscar";
            btnBuscarEditar.UseVisualStyleBackColor = true;
            btnBuscarEditar.Click += btnBuscarEditar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Enabled = false;
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(1091, 29);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(77, 35);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPrecioEdit
            // 
            txtPrecioEdit.Anchor = AnchorStyles.Left;
            txtPrecioEdit.Font = new Font("Times New Roman", 12F);
            txtPrecioEdit.Location = new Point(201, 37);
            txtPrecioEdit.Name = "txtPrecioEdit";
            txtPrecioEdit.Size = new Size(94, 26);
            txtPrecioEdit.TabIndex = 33;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(206, 15);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 28;
            label6.Text = "Precio";
            // 
            // btnLimpiarEditar
            // 
            btnLimpiarEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarEditar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiarEditar.Location = new Point(1003, 29);
            btnLimpiarEditar.Name = "btnLimpiarEditar";
            btnLimpiarEditar.Size = new Size(77, 35);
            btnLimpiarEditar.TabIndex = 30;
            btnLimpiarEditar.Text = "Limpiar";
            btnLimpiarEditar.UseVisualStyleBackColor = true;
            btnLimpiarEditar.Click += btnLimpiarEditar_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(8, 15);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 27;
            label7.Text = "Nombre";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(474, 37);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 32;
            label5.Text = "Buscar";
            // 
            // txtNombreProEdi
            // 
            txtNombreProEdi.Anchor = AnchorStyles.Left;
            txtNombreProEdi.Font = new Font("Times New Roman", 12F);
            txtNombreProEdi.Location = new Point(8, 37);
            txtNombreProEdi.Name = "txtNombreProEdi";
            txtNombreProEdi.Size = new Size(174, 26);
            txtNombreProEdi.TabIndex = 24;
            txtNombreProEdi.TextChanged += txtNombreProEdi_TextChanged;
            // 
            // txtBuscarEditar
            // 
            txtBuscarEditar.Anchor = AnchorStyles.Left;
            txtBuscarEditar.Font = new Font("Times New Roman", 12F);
            txtBuscarEditar.Location = new Point(544, 33);
            txtBuscarEditar.MaxLength = 10;
            txtBuscarEditar.Name = "txtBuscarEditar";
            txtBuscarEditar.Size = new Size(160, 26);
            txtBuscarEditar.TabIndex = 31;
            txtBuscarEditar.KeyPress += txtBuscarEditar_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(panel6);
            tabPage3.Controls.Add(panel5);
            tabPage3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1192, 418);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(dgvEliminar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 103);
            panel6.Name = "panel6";
            panel6.Size = new Size(1182, 308);
            panel6.TabIndex = 45;
            // 
            // dgvEliminar
            // 
            dgvEliminar.AllowUserToAddRows = false;
            dgvEliminar.AllowUserToDeleteRows = false;
            dgvEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEliminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEliminar.Dock = DockStyle.Fill;
            dgvEliminar.Location = new Point(0, 0);
            dgvEliminar.Name = "dgvEliminar";
            dgvEliminar.ReadOnly = true;
            dgvEliminar.ScrollBars = ScrollBars.Vertical;
            dgvEliminar.Size = new Size(1178, 304);
            dgvEliminar.TabIndex = 33;
            dgvEliminar.CellClick += dgvEliminar_CellClick;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(comboBox6);
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(btnBuscarEliminar);
            panel5.Controls.Add(btnLimpiarEliminar);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtPrecioeliminar);
            panel5.Controls.Add(txtNombreEliminar);
            panel5.Controls.Add(txtBuscarEliminar);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1182, 100);
            panel5.TabIndex = 44;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.Location = new Point(316, 15);
            label11.Name = "label11";
            label11.Size = new Size(89, 19);
            label11.TabIndex = 47;
            label11.Text = "Proveedor";
            // 
            // comboBox6
            // 
            comboBox6.Enabled = false;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(316, 37);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(152, 27);
            comboBox6.TabIndex = 46;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Right;
            comboBox3.Font = new Font("Times New Roman", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "NOMBRE", "PRECIO_UNITARIO", "PROVEEDOR" });
            comboBox3.Location = new Point(745, 33);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(163, 27);
            comboBox3.TabIndex = 45;
            // 
            // btnBuscarEliminar
            // 
            btnBuscarEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarEliminar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnBuscarEliminar.Location = new Point(915, 29);
            btnBuscarEliminar.Name = "btnBuscarEliminar";
            btnBuscarEliminar.Size = new Size(77, 35);
            btnBuscarEliminar.TabIndex = 44;
            btnBuscarEliminar.Text = "Buscar";
            btnBuscarEliminar.UseVisualStyleBackColor = true;
            btnBuscarEliminar.Click += btnBuscarEliminar_Click;
            // 
            // btnLimpiarEliminar
            // 
            btnLimpiarEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarEliminar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiarEliminar.Location = new Point(1003, 29);
            btnLimpiarEliminar.Name = "btnLimpiarEliminar";
            btnLimpiarEliminar.Size = new Size(77, 35);
            btnLimpiarEliminar.TabIndex = 40;
            btnLimpiarEliminar.Text = "Limpiar";
            btnLimpiarEliminar.UseVisualStyleBackColor = true;
            btnLimpiarEliminar.Click += btnLimpiarEliminar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold);
            label12.Location = new Point(8, 15);
            label12.Name = "label12";
            label12.Size = new Size(70, 19);
            label12.TabIndex = 43;
            label12.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Enabled = false;
            btnEliminar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1091, 29);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 35);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold);
            label10.Location = new Point(206, 15);
            label10.Name = "label10";
            label10.Size = new Size(58, 19);
            label10.TabIndex = 38;
            label10.Text = "Precio";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(474, 37);
            label9.Name = "label9";
            label9.Size = new Size(64, 19);
            label9.TabIndex = 42;
            label9.Text = "Buscar";
            // 
            // txtPrecioeliminar
            // 
            txtPrecioeliminar.Anchor = AnchorStyles.Left;
            txtPrecioeliminar.Enabled = false;
            txtPrecioeliminar.Font = new Font("Times New Roman", 12F);
            txtPrecioeliminar.Location = new Point(201, 37);
            txtPrecioeliminar.Name = "txtPrecioeliminar";
            txtPrecioeliminar.Size = new Size(94, 26);
            txtPrecioeliminar.TabIndex = 36;
            // 
            // txtNombreEliminar
            // 
            txtNombreEliminar.Anchor = AnchorStyles.Left;
            txtNombreEliminar.Enabled = false;
            txtNombreEliminar.Font = new Font("Times New Roman", 12F);
            txtNombreEliminar.Location = new Point(8, 37);
            txtNombreEliminar.Name = "txtNombreEliminar";
            txtNombreEliminar.Size = new Size(174, 26);
            txtNombreEliminar.TabIndex = 35;
            // 
            // txtBuscarEliminar
            // 
            txtBuscarEliminar.Anchor = AnchorStyles.Left;
            txtBuscarEliminar.Font = new Font("Times New Roman", 12F);
            txtBuscarEliminar.Location = new Point(544, 33);
            txtBuscarEliminar.MaxLength = 10;
            txtBuscarEliminar.Name = "txtBuscarEliminar";
            txtBuscarEliminar.Size = new Size(160, 26);
            txtBuscarEliminar.TabIndex = 41;
            txtBuscarEliminar.KeyPress += txtBuscarEliminar_KeyPress;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "frm_AgregarCleinte";
            Load += frm_AgregarCleinte_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAggProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEliminar).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Label label12;
        private Label label9;
        private TextBox txtBuscarEliminar;
        private Button btnLimpiarEliminar;
        private Button btnEliminar;
        private Label label10;
        private Label label11;
        private TextBox txtPrecioeliminar;
        private TextBox txtNombreEliminar;
        private TextBox txtCedulaEliminar;
        private DataGridView dgvEliminar;
        private Label label5;
        private TextBox txtBuscarEditar;
        private Button btnLimpiarEditar;
        private Button btnEditar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtApellidosEditar;
        private TextBox txtNombreProEdi;
        private TextBox txtCedulaEditar;
        private DataGridView dgvEditar;
        private Label label1;
        private TextBox txtBuscarProducto;
        private Button button1;
        private Button btnAggProductos;
        private Label label2;
        private Label label3;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private DataGridView dgvAggProductos;
        private TextBox txtPrecioEdit;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private ComboBox comboBox1;
        private Button btnBuscar;
        private ComboBox comboBox2;
        private Button btnBuscarEditar;
        private ComboBox comboBox3;
        private Button btnBuscarEliminar;
        private Label label4;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
    }
}