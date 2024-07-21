namespace Facturacion
{
    partial class frmAgregarClientes
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            btnbuscar = new Button();
            txtBuscar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            label1 = new Label();
            txtApellido = new TextBox();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            txtCedula = new TextBox();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            dgvEditar = new DataGridView();
            panel3 = new Panel();
            comboBox2 = new ComboBox();
            bntBuscar = new Button();
            btnEditar = new Button();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label8 = new Label();
            btnLimpiarEditar = new Button();
            txtApellidosEditar = new TextBox();
            txtBuscarEditar = new TextBox();
            txtNombresEditar = new TextBox();
            txtCedulaEditar = new TextBox();
            tabPage3 = new TabPage();
            panel6 = new Panel();
            dgvEliminar = new DataGridView();
            panel5 = new Panel();
            comboBox3 = new ComboBox();
            button1 = new Button();
            btnEliminar = new Button();
            label12 = new Label();
            label10 = new Label();
            btnLimpiarEliminar = new Button();
            label11 = new Label();
            label9 = new Label();
            txtApellidoEliminar = new TextBox();
            txtBuscarEliminar = new TextBox();
            txtNombreEliminar = new TextBox();
            txtCedulaEliminar = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabControl1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1200, 603);
            tabControl1.TabIndex = 0;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1192, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 472);
            panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1178, 468);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtCedula);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Times New Roman", 12F);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 89);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.Font = new Font("Times New Roman", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cedula", "Nombres", "Apellidos" });
            comboBox1.Location = new Point(772, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbuscar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnbuscar.Location = new Point(907, 28);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(77, 35);
            btnbuscar.TabIndex = 11;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left;
            txtBuscar.Font = new Font("Times New Roman", 12F);
            txtBuscar.Location = new Point(588, 29);
            txtBuscar.MaxLength = 10;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(143, 26);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(343, 12);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 6;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(513, 32);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 10;
            label4.Text = "Buscar:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(162, 12);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 5;
            label2.Text = "Nombres";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(1086, 28);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(77, 35);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 4;
            label1.Text = "Cedula";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Left;
            txtApellido.Font = new Font("Times New Roman", 12F);
            txtApellido.Location = new Point(338, 34);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(158, 26);
            txtApellido.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiar.Location = new Point(997, 28);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 35);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left;
            txtNombre.Font = new Font("Times New Roman", 12F);
            txtNombre.Location = new Point(156, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 26);
            txtNombre.TabIndex = 2;
            // 
            // txtCedula
            // 
            txtCedula.Anchor = AnchorStyles.Left;
            txtCedula.Font = new Font("Times New Roman", 12F);
            txtCedula.Location = new Point(12, 34);
            txtCedula.MaxLength = 10;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(125, 26);
            txtCedula.TabIndex = 1;
            txtCedula.KeyPress += txtCedula_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1192, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(dgvEditar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 92);
            panel4.Name = "panel4";
            panel4.Size = new Size(1182, 472);
            panel4.TabIndex = 23;
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
            dgvEditar.Size = new Size(1178, 468);
            dgvEditar.TabIndex = 11;
            dgvEditar.CellClick += dgvEditar_CellClick;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(bntBuscar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(btnLimpiarEditar);
            panel3.Controls.Add(txtApellidosEditar);
            panel3.Controls.Add(txtBuscarEditar);
            panel3.Controls.Add(txtNombresEditar);
            panel3.Controls.Add(txtCedulaEditar);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1182, 89);
            panel3.TabIndex = 22;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.Font = new Font("Times New Roman", 12F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cedula", "Nombres", "Apellidos" });
            comboBox2.Location = new Point(772, 32);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 27);
            comboBox2.TabIndex = 23;
            comboBox2.KeyPress += txtBuscar_KeyPress;
            // 
            // bntBuscar
            // 
            bntBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntBuscar.Font = new Font("Arial", 12F, FontStyle.Bold);
            bntBuscar.Location = new Point(907, 28);
            bntBuscar.Name = "bntBuscar";
            bntBuscar.Size = new Size(77, 35);
            bntBuscar.TabIndex = 22;
            bntBuscar.Text = "Buscar";
            bntBuscar.UseVisualStyleBackColor = true;
            bntBuscar.Click += bntBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditar.Location = new Point(1086, 28);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(77, 35);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(343, 12);
            label6.Name = "label6";
            label6.Size = new Size(80, 19);
            label6.TabIndex = 17;
            label6.Text = "Apellidos";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(162, 12);
            label7.Name = "label7";
            label7.Size = new Size(79, 19);
            label7.TabIndex = 16;
            label7.Text = "Nombres";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(513, 32);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 21;
            label5.Text = "Buscar:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.Location = new Point(17, 12);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 15;
            label8.Text = "Cedula";
            // 
            // btnLimpiarEditar
            // 
            btnLimpiarEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarEditar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiarEditar.Location = new Point(997, 28);
            btnLimpiarEditar.Name = "btnLimpiarEditar";
            btnLimpiarEditar.Size = new Size(77, 35);
            btnLimpiarEditar.TabIndex = 19;
            btnLimpiarEditar.Text = "Limpiar";
            btnLimpiarEditar.UseVisualStyleBackColor = true;
            btnLimpiarEditar.Click += btnLimpiarEditar_Click;
            // 
            // txtApellidosEditar
            // 
            txtApellidosEditar.Anchor = AnchorStyles.Left;
            txtApellidosEditar.Font = new Font("Times New Roman", 12F);
            txtApellidosEditar.Location = new Point(338, 34);
            txtApellidosEditar.Name = "txtApellidosEditar";
            txtApellidosEditar.Size = new Size(158, 26);
            txtApellidosEditar.TabIndex = 14;
            // 
            // txtBuscarEditar
            // 
            txtBuscarEditar.Anchor = AnchorStyles.Left;
            txtBuscarEditar.Font = new Font("Times New Roman", 12F);
            txtBuscarEditar.Location = new Point(588, 29);
            txtBuscarEditar.MaxLength = 10;
            txtBuscarEditar.Name = "txtBuscarEditar";
            txtBuscarEditar.Size = new Size(143, 26);
            txtBuscarEditar.TabIndex = 20;
            txtBuscarEditar.KeyPress += txtBuscarEditar_KeyPress;
            // 
            // txtNombresEditar
            // 
            txtNombresEditar.Anchor = AnchorStyles.Left;
            txtNombresEditar.Font = new Font("Times New Roman", 12F);
            txtNombresEditar.Location = new Point(156, 34);
            txtNombresEditar.Name = "txtNombresEditar";
            txtNombresEditar.Size = new Size(158, 26);
            txtNombresEditar.TabIndex = 13;
            // 
            // txtCedulaEditar
            // 
            txtCedulaEditar.Anchor = AnchorStyles.Left;
            txtCedulaEditar.Font = new Font("Times New Roman", 12F);
            txtCedulaEditar.Location = new Point(12, 34);
            txtCedulaEditar.MaxLength = 10;
            txtCedulaEditar.Name = "txtCedulaEditar";
            txtCedulaEditar.Size = new Size(125, 26);
            txtCedulaEditar.TabIndex = 12;
            txtCedulaEditar.TextChanged += txtCedulaEditar_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(panel6);
            tabPage3.Controls.Add(panel5);
            tabPage3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1192, 571);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(dgvEliminar);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 92);
            panel6.Name = "panel6";
            panel6.Size = new Size(1182, 472);
            panel6.TabIndex = 34;
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
            dgvEliminar.Size = new Size(1178, 468);
            dgvEliminar.TabIndex = 22;
            dgvEliminar.CellClick += dgvEliminar_CellClick;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(comboBox3);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(btnLimpiarEliminar);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(txtApellidoEliminar);
            panel5.Controls.Add(txtBuscarEliminar);
            panel5.Controls.Add(txtNombreEliminar);
            panel5.Controls.Add(txtCedulaEliminar);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1182, 89);
            panel5.TabIndex = 33;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.Font = new Font("Times New Roman", 12F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cedula", "Nombres", "Apellidos" });
            comboBox3.Location = new Point(772, 32);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 27);
            comboBox3.TabIndex = 34;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(907, 28);
            button1.Name = "button1";
            button1.Size = new Size(77, 35);
            button1.TabIndex = 33;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1086, 28);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(77, 35);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold);
            label12.Location = new Point(162, 12);
            label12.Name = "label12";
            label12.Size = new Size(79, 19);
            label12.TabIndex = 32;
            label12.Text = "Nombres";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold);
            label10.Location = new Point(343, 12);
            label10.Name = "label10";
            label10.Size = new Size(80, 19);
            label10.TabIndex = 27;
            label10.Text = "Apellidos";
            // 
            // btnLimpiarEliminar
            // 
            btnLimpiarEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiarEliminar.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLimpiarEliminar.Location = new Point(997, 28);
            btnLimpiarEliminar.Name = "btnLimpiarEliminar";
            btnLimpiarEliminar.Size = new Size(77, 35);
            btnLimpiarEliminar.TabIndex = 29;
            btnLimpiarEliminar.Text = "Limpiar";
            btnLimpiarEliminar.UseVisualStyleBackColor = true;
            btnLimpiarEliminar.Click += btnLimpiarEliminar_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.Location = new Point(17, 12);
            label11.Name = "label11";
            label11.Size = new Size(63, 19);
            label11.TabIndex = 26;
            label11.Text = "Cedula";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold);
            label9.Location = new Point(513, 32);
            label9.Name = "label9";
            label9.Size = new Size(70, 19);
            label9.TabIndex = 31;
            label9.Text = "Buscar:";
            // 
            // txtApellidoEliminar
            // 
            txtApellidoEliminar.Anchor = AnchorStyles.Left;
            txtApellidoEliminar.Enabled = false;
            txtApellidoEliminar.Font = new Font("Times New Roman", 12F);
            txtApellidoEliminar.Location = new Point(338, 34);
            txtApellidoEliminar.Name = "txtApellidoEliminar";
            txtApellidoEliminar.Size = new Size(158, 26);
            txtApellidoEliminar.TabIndex = 25;
            // 
            // txtBuscarEliminar
            // 
            txtBuscarEliminar.Anchor = AnchorStyles.Left;
            txtBuscarEliminar.Font = new Font("Times New Roman", 12F);
            txtBuscarEliminar.Location = new Point(588, 29);
            txtBuscarEliminar.MaxLength = 10;
            txtBuscarEliminar.Name = "txtBuscarEliminar";
            txtBuscarEliminar.Size = new Size(143, 26);
            txtBuscarEliminar.TabIndex = 30;
            txtBuscarEliminar.KeyPress += txtBuscarEliminar_KeyPress;
            // 
            // txtNombreEliminar
            // 
            txtNombreEliminar.Anchor = AnchorStyles.Left;
            txtNombreEliminar.Enabled = false;
            txtNombreEliminar.Font = new Font("Times New Roman", 12F);
            txtNombreEliminar.Location = new Point(156, 34);
            txtNombreEliminar.Name = "txtNombreEliminar";
            txtNombreEliminar.Size = new Size(158, 26);
            txtNombreEliminar.TabIndex = 24;
            // 
            // txtCedulaEliminar
            // 
            txtCedulaEliminar.Anchor = AnchorStyles.Left;
            txtCedulaEliminar.Enabled = false;
            txtCedulaEliminar.Font = new Font("Times New Roman", 12F);
            txtCedulaEliminar.Location = new Point(12, 34);
            txtCedulaEliminar.MaxLength = 10;
            txtCedulaEliminar.Name = "txtCedulaEliminar";
            txtCedulaEliminar.Size = new Size(125, 26);
            txtCedulaEliminar.TabIndex = 23;
            // 
            // frmAgregarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 603);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgregarClientes";
            Text = "frm_Eliminar_Cliente";
            Load += frm_Eliminar_Cliente_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAgregar;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Label label4;
        private Label label5;
        private TextBox txtBuscarEditar;
        private Button btnLimpiarEditar;
        private Button btnEditar;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtApellidosEditar;
        private TextBox txtNombresEditar;
        private TextBox txtCedulaEditar;
        private DataGridView dgvEditar;
        private Label label9;
        private TextBox txtBuscarEliminar;
        private Button btnLimpiarEliminar;
        private Button btnEliminar;
        private Label label11;
        private DataGridView dgvEliminar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label12;
        private Label label10;
        private TextBox txtApellidoEliminar;
        private TextBox txtNombreEliminar;
        private TextBox txtCedulaEliminar;
        private Panel panel6;
        private Button btnbuscar;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button bntBuscar;
        private ComboBox comboBox3;
        private Button button1;
    }
}