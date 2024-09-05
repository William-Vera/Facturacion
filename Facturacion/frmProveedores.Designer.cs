namespace Facturacion
{
    partial class frmProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvAgregarProve = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtCorreoAgg = new TextBox();
            txtTelefinoAgg = new TextBox();
            txtDirAgg = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNomProAgg = new TextBox();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btnBuscarAgg = new Button();
            btnLimpiarAgg = new Button();
            txtBuscarProducto = new TextBox();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            dgvEditar = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtCorreoEditar = new TextBox();
            txtTelEditar = new TextBox();
            txtDirEditar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtNombreEditar = new TextBox();
            btnEditar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            cbxEditar = new ComboBox();
            btnBuscarEditar = new Button();
            btnLimpiarEditar = new Button();
            txtBuscarEditar = new TextBox();
            tabPage3 = new TabPage();
            dgvEliminar = new DataGridView();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtCorreoEliminar = new TextBox();
            txtTelEliminar = new TextBox();
            txtDirEliminar = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtNombreEliminar = new TextBox();
            btnEliminar = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            label11 = new Label();
            cbxEliminar = new ComboBox();
            btnBuscarEliminar = new Button();
            btnLimpiarEliminar = new Button();
            txtBuscarEliminar = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgregarProve).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditar).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEliminar).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            tabControl1.Size = new Size(1116, 548);
            tabControl1.TabIndex = 0;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(dgvAgregarProve);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1108, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAgregarProve
            // 
            dgvAgregarProve.AllowUserToAddRows = false;
            dgvAgregarProve.AllowUserToDeleteRows = false;
            dgvAgregarProve.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgregarProve.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAgregarProve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgregarProve.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAgregarProve.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAgregarProve.Dock = DockStyle.Fill;
            dgvAgregarProve.Location = new Point(3, 163);
            dgvAgregarProve.Name = "dgvAgregarProve";
            dgvAgregarProve.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAgregarProve.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAgregarProve.Size = new Size(1098, 346);
            dgvAgregarProve.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227127F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.69845F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.25613F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227051F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(txtCorreoAgg, 3, 1);
            tableLayoutPanel2.Controls.Add(txtTelefinoAgg, 2, 1);
            tableLayoutPanel2.Controls.Add(txtDirAgg, 1, 1);
            tableLayoutPanel2.Controls.Add(label5, 3, 0);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(label3, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtNomProAgg, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAgregar, 4, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 70);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1098, 93);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // txtCorreoAgg
            // 
            txtCorreoAgg.Dock = DockStyle.Fill;
            txtCorreoAgg.Font = new Font("Times New Roman", 12F);
            txtCorreoAgg.Location = new Point(741, 36);
            txtCorreoAgg.Margin = new Padding(7, 3, 7, 22);
            txtCorreoAgg.Multiline = true;
            txtCorreoAgg.Name = "txtCorreoAgg";
            txtCorreoAgg.Size = new Size(231, 35);
            txtCorreoAgg.TabIndex = 7;
            txtCorreoAgg.KeyPress += txtCorreoAgg_KeyPress;
            // 
            // txtTelefinoAgg
            // 
            txtTelefinoAgg.Dock = DockStyle.Fill;
            txtTelefinoAgg.Font = new Font("Times New Roman", 12F);
            txtTelefinoAgg.Location = new Point(562, 36);
            txtTelefinoAgg.Margin = new Padding(7, 3, 7, 22);
            txtTelefinoAgg.MaxLength = 15;
            txtTelefinoAgg.Multiline = true;
            txtTelefinoAgg.Name = "txtTelefinoAgg";
            txtTelefinoAgg.Size = new Size(165, 35);
            txtTelefinoAgg.TabIndex = 6;
            txtTelefinoAgg.KeyPress += txtTelefinoAgg_KeyPress;
            // 
            // txtDirAgg
            // 
            txtDirAgg.Dock = DockStyle.Fill;
            txtDirAgg.Font = new Font("Times New Roman", 12F);
            txtDirAgg.Location = new Point(252, 36);
            txtDirAgg.Margin = new Padding(7, 3, 7, 22);
            txtDirAgg.Multiline = true;
            txtDirAgg.Name = "txtDirAgg";
            txtDirAgg.Size = new Size(296, 35);
            txtDirAgg.TabIndex = 5;
            txtDirAgg.KeyPress += txtDirAgg_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Location = new Point(777, 7);
            label5.Margin = new Padding(3, 7, 3, 7);
            label5.Name = "label5";
            label5.Size = new Size(159, 19);
            label5.TabIndex = 3;
            label5.Text = "Correo Eléctronico:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(604, 7);
            label4.Margin = new Padding(3, 7, 3, 7);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 2;
            label4.Text = "Teléfono:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(356, 7);
            label3.Margin = new Padding(3, 7, 3, 7);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 1;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(42, 7);
            label2.Margin = new Padding(3, 7, 3, 7);
            label2.Name = "label2";
            label2.Size = new Size(160, 19);
            label2.TabIndex = 0;
            label2.Text = "Nombre Proveedor:";
            // 
            // txtNomProAgg
            // 
            txtNomProAgg.Dock = DockStyle.Fill;
            txtNomProAgg.Font = new Font("Times New Roman", 12F);
            txtNomProAgg.Location = new Point(7, 36);
            txtNomProAgg.Margin = new Padding(7, 3, 7, 22);
            txtNomProAgg.Multiline = true;
            txtNomProAgg.Name = "txtNomProAgg";
            txtNomProAgg.Size = new Size(231, 35);
            txtNomProAgg.TabIndex = 4;
            txtNomProAgg.KeyPress += txtNomProAgg_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(982, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 37);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBuscarAgg, 3, 0);
            tableLayoutPanel1.Controls.Add(btnLimpiarAgg, 5, 0);
            tableLayoutPanel1.Controls.Add(txtBuscarProducto, 1, 0);
            tableLayoutPanel1.Controls.Add(comboBox1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1098, 67);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(70, 19);
            label1.TabIndex = 33;
            label1.Text = "Buscar:";
            // 
            // btnBuscarAgg
            // 
            btnBuscarAgg.Anchor = AnchorStyles.None;
            btnBuscarAgg.Location = new Point(867, 15);
            btnBuscarAgg.Name = "btnBuscarAgg";
            btnBuscarAgg.Size = new Size(111, 37);
            btnBuscarAgg.TabIndex = 2;
            btnBuscarAgg.Text = "Buscar";
            btnBuscarAgg.UseVisualStyleBackColor = true;
            btnBuscarAgg.Click += btnBuscarAgg_Click;
            // 
            // btnLimpiarAgg
            // 
            btnLimpiarAgg.Anchor = AnchorStyles.None;
            btnLimpiarAgg.Location = new Point(984, 15);
            btnLimpiarAgg.Name = "btnLimpiarAgg";
            btnLimpiarAgg.Size = new Size(111, 37);
            btnLimpiarAgg.TabIndex = 1;
            btnLimpiarAgg.Text = "Limpiar";
            btnLimpiarAgg.UseVisualStyleBackColor = true;
            btnLimpiarAgg.Click += btnLimpiarAgg_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.Left;
            txtBuscarProducto.Font = new Font("Times New Roman", 12F);
            txtBuscarProducto.Location = new Point(79, 18);
            txtBuscarProducto.MaxLength = 10;
            txtBuscarProducto.Multiline = true;
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(379, 31);
            txtBuscarProducto.TabIndex = 34;
            txtBuscarProducto.KeyPress += txtBuscarProducto_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NOMBRE", "DIRECCION", "TELEFONO", "EMAIL", "FECHA_REGISTRO" });
            comboBox1.Location = new Point(610, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 27);
            comboBox1.TabIndex = 35;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(dgvEditar);
            tabPage2.Controls.Add(tableLayoutPanel4);
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1108, 516);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Editar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEditar
            // 
            dgvEditar.AllowUserToAddRows = false;
            dgvEditar.AllowUserToDeleteRows = false;
            dgvEditar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditar.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEditar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEditar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvEditar.DefaultCellStyle = dataGridViewCellStyle5;
            dgvEditar.Dock = DockStyle.Fill;
            dgvEditar.Location = new Point(3, 163);
            dgvEditar.Name = "dgvEditar";
            dgvEditar.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEditar.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvEditar.Size = new Size(1098, 346);
            dgvEditar.TabIndex = 3;
            dgvEditar.CellClick += dgvEditar_CellClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227127F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.69845F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.25613F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227089F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.Controls.Add(txtCorreoEditar, 3, 1);
            tableLayoutPanel4.Controls.Add(txtTelEditar, 2, 1);
            tableLayoutPanel4.Controls.Add(txtDirEditar, 1, 1);
            tableLayoutPanel4.Controls.Add(label7, 3, 0);
            tableLayoutPanel4.Controls.Add(label8, 2, 0);
            tableLayoutPanel4.Controls.Add(label9, 1, 0);
            tableLayoutPanel4.Controls.Add(label10, 0, 0);
            tableLayoutPanel4.Controls.Add(txtNombreEditar, 0, 1);
            tableLayoutPanel4.Controls.Add(btnEditar, 4, 1);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(3, 70);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1098, 93);
            tableLayoutPanel4.TabIndex = 2;
            tableLayoutPanel4.Paint += tableLayoutPanel4_Paint;
            // 
            // txtCorreoEditar
            // 
            txtCorreoEditar.Dock = DockStyle.Fill;
            txtCorreoEditar.Font = new Font("Times New Roman", 12F);
            txtCorreoEditar.Location = new Point(741, 36);
            txtCorreoEditar.Margin = new Padding(7, 3, 7, 22);
            txtCorreoEditar.Multiline = true;
            txtCorreoEditar.Name = "txtCorreoEditar";
            txtCorreoEditar.Size = new Size(231, 35);
            txtCorreoEditar.TabIndex = 7;
            // 
            // txtTelEditar
            // 
            txtTelEditar.Dock = DockStyle.Fill;
            txtTelEditar.Font = new Font("Times New Roman", 12F);
            txtTelEditar.Location = new Point(562, 36);
            txtTelEditar.Margin = new Padding(7, 3, 7, 22);
            txtTelEditar.MaxLength = 15;
            txtTelEditar.Multiline = true;
            txtTelEditar.Name = "txtTelEditar";
            txtTelEditar.Size = new Size(165, 35);
            txtTelEditar.TabIndex = 6;
            txtTelEditar.KeyPress += txtTelEditar_KeyPress;
            // 
            // txtDirEditar
            // 
            txtDirEditar.Dock = DockStyle.Fill;
            txtDirEditar.Font = new Font("Times New Roman", 12F);
            txtDirEditar.Location = new Point(252, 36);
            txtDirEditar.Margin = new Padding(7, 3, 7, 22);
            txtDirEditar.Multiline = true;
            txtDirEditar.Name = "txtDirEditar";
            txtDirEditar.Size = new Size(296, 35);
            txtDirEditar.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(777, 7);
            label7.Margin = new Padding(3, 7, 3, 7);
            label7.Name = "label7";
            label7.Size = new Size(159, 19);
            label7.TabIndex = 3;
            label7.Text = "Correo Eléctronico:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Location = new Point(604, 7);
            label8.Margin = new Padding(3, 7, 3, 7);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 2;
            label8.Text = "Teléfono:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(356, 7);
            label9.Margin = new Padding(3, 7, 3, 7);
            label9.Name = "label9";
            label9.Size = new Size(88, 19);
            label9.TabIndex = 1;
            label9.Text = "Dirección:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Location = new Point(42, 7);
            label10.Margin = new Padding(3, 7, 3, 7);
            label10.Name = "label10";
            label10.Size = new Size(160, 19);
            label10.TabIndex = 0;
            label10.Text = "Nombre Proveedor:";
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Dock = DockStyle.Fill;
            txtNombreEditar.Font = new Font("Times New Roman", 12F);
            txtNombreEditar.Location = new Point(7, 36);
            txtNombreEditar.Margin = new Padding(7, 3, 7, 22);
            txtNombreEditar.Multiline = true;
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(231, 35);
            txtNombreEditar.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(982, 36);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 37);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(cbxEditar, 2, 0);
            tableLayoutPanel3.Controls.Add(btnBuscarEditar, 3, 0);
            tableLayoutPanel3.Controls.Add(btnLimpiarEditar, 5, 0);
            tableLayoutPanel3.Controls.Add(txtBuscarEditar, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1098, 67);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(3, 24);
            label6.Name = "label6";
            label6.Size = new Size(70, 19);
            label6.TabIndex = 33;
            label6.Text = "Buscar:";
            // 
            // cbxEditar
            // 
            cbxEditar.Anchor = AnchorStyles.None;
            cbxEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEditar.Font = new Font("Times New Roman", 12F);
            cbxEditar.FormattingEnabled = true;
            cbxEditar.Items.AddRange(new object[] { "NOMBRE", "DIRECCION", "TELEFONO", "EMAIL", "FECHA_REGISTRO" });
            cbxEditar.Location = new Point(610, 20);
            cbxEditar.Name = "cbxEditar";
            cbxEditar.Size = new Size(251, 27);
            cbxEditar.TabIndex = 35;
            // 
            // btnBuscarEditar
            // 
            btnBuscarEditar.Anchor = AnchorStyles.None;
            btnBuscarEditar.Location = new Point(867, 15);
            btnBuscarEditar.Name = "btnBuscarEditar";
            btnBuscarEditar.Size = new Size(111, 37);
            btnBuscarEditar.TabIndex = 2;
            btnBuscarEditar.Text = "Buscar";
            btnBuscarEditar.UseVisualStyleBackColor = true;
            btnBuscarEditar.Click += btnBuscarEditar_Click;
            // 
            // btnLimpiarEditar
            // 
            btnLimpiarEditar.Anchor = AnchorStyles.None;
            btnLimpiarEditar.Location = new Point(984, 15);
            btnLimpiarEditar.Name = "btnLimpiarEditar";
            btnLimpiarEditar.Size = new Size(111, 37);
            btnLimpiarEditar.TabIndex = 1;
            btnLimpiarEditar.Text = "Limpiar";
            btnLimpiarEditar.UseVisualStyleBackColor = true;
            btnLimpiarEditar.Click += btnLimpiarEditar_Click;
            // 
            // txtBuscarEditar
            // 
            txtBuscarEditar.Anchor = AnchorStyles.Left;
            txtBuscarEditar.Font = new Font("Times New Roman", 12F);
            txtBuscarEditar.Location = new Point(79, 18);
            txtBuscarEditar.MaxLength = 10;
            txtBuscarEditar.Multiline = true;
            txtBuscarEditar.Name = "txtBuscarEditar";
            txtBuscarEditar.Size = new Size(379, 31);
            txtBuscarEditar.TabIndex = 34;
            txtBuscarEditar.KeyPress += txtBuscarEditar_KeyPress;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(dgvEliminar);
            tabPage3.Controls.Add(tableLayoutPanel6);
            tabPage3.Controls.Add(tableLayoutPanel5);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1108, 516);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Eliminar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvEliminar
            // 
            dgvEliminar.AllowUserToAddRows = false;
            dgvEliminar.AllowUserToDeleteRows = false;
            dgvEliminar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEliminar.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEliminar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvEliminar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvEliminar.DefaultCellStyle = dataGridViewCellStyle8;
            dgvEliminar.Dock = DockStyle.Fill;
            dgvEliminar.Location = new Point(3, 163);
            dgvEliminar.Name = "dgvEliminar";
            dgvEliminar.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvEliminar.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvEliminar.Size = new Size(1098, 346);
            dgvEliminar.TabIndex = 4;
            dgvEliminar.CellClick += dgvEliminar_CellClick;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227127F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.69845F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.25613F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0227051F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel6.Controls.Add(txtCorreoEliminar, 3, 1);
            tableLayoutPanel6.Controls.Add(txtTelEliminar, 2, 1);
            tableLayoutPanel6.Controls.Add(txtDirEliminar, 1, 1);
            tableLayoutPanel6.Controls.Add(label12, 3, 0);
            tableLayoutPanel6.Controls.Add(label13, 2, 0);
            tableLayoutPanel6.Controls.Add(label14, 1, 0);
            tableLayoutPanel6.Controls.Add(label15, 0, 0);
            tableLayoutPanel6.Controls.Add(txtNombreEliminar, 0, 1);
            tableLayoutPanel6.Controls.Add(btnEliminar, 4, 1);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(3, 70);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1098, 93);
            tableLayoutPanel6.TabIndex = 3;
            tableLayoutPanel6.Paint += tableLayoutPanel6_Paint;
            // 
            // txtCorreoEliminar
            // 
            txtCorreoEliminar.Dock = DockStyle.Fill;
            txtCorreoEliminar.Enabled = false;
            txtCorreoEliminar.Font = new Font("Times New Roman", 12F);
            txtCorreoEliminar.Location = new Point(741, 36);
            txtCorreoEliminar.Margin = new Padding(7, 3, 7, 22);
            txtCorreoEliminar.Multiline = true;
            txtCorreoEliminar.Name = "txtCorreoEliminar";
            txtCorreoEliminar.Size = new Size(231, 35);
            txtCorreoEliminar.TabIndex = 7;
            // 
            // txtTelEliminar
            // 
            txtTelEliminar.Dock = DockStyle.Fill;
            txtTelEliminar.Enabled = false;
            txtTelEliminar.Font = new Font("Times New Roman", 12F);
            txtTelEliminar.Location = new Point(562, 36);
            txtTelEliminar.Margin = new Padding(7, 3, 7, 22);
            txtTelEliminar.Multiline = true;
            txtTelEliminar.Name = "txtTelEliminar";
            txtTelEliminar.Size = new Size(165, 35);
            txtTelEliminar.TabIndex = 6;
            // 
            // txtDirEliminar
            // 
            txtDirEliminar.Dock = DockStyle.Fill;
            txtDirEliminar.Enabled = false;
            txtDirEliminar.Font = new Font("Times New Roman", 12F);
            txtDirEliminar.Location = new Point(252, 36);
            txtDirEliminar.Margin = new Padding(7, 3, 7, 22);
            txtDirEliminar.Multiline = true;
            txtDirEliminar.Name = "txtDirEliminar";
            txtDirEliminar.Size = new Size(296, 35);
            txtDirEliminar.TabIndex = 5;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Location = new Point(777, 7);
            label12.Margin = new Padding(3, 7, 3, 7);
            label12.Name = "label12";
            label12.Size = new Size(159, 19);
            label12.TabIndex = 3;
            label12.Text = "Correo Eléctronico:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Location = new Point(604, 7);
            label13.Margin = new Padding(3, 7, 3, 7);
            label13.Name = "label13";
            label13.Size = new Size(81, 19);
            label13.TabIndex = 2;
            label13.Text = "Teléfono:";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Location = new Point(356, 7);
            label14.Margin = new Padding(3, 7, 3, 7);
            label14.Name = "label14";
            label14.Size = new Size(88, 19);
            label14.TabIndex = 1;
            label14.Text = "Dirección:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Bottom;
            label15.AutoSize = true;
            label15.Location = new Point(42, 7);
            label15.Margin = new Padding(3, 7, 3, 7);
            label15.Name = "label15";
            label15.Size = new Size(160, 19);
            label15.TabIndex = 0;
            label15.Text = "Nombre Proveedor:";
            // 
            // txtNombreEliminar
            // 
            txtNombreEliminar.Dock = DockStyle.Fill;
            txtNombreEliminar.Enabled = false;
            txtNombreEliminar.Font = new Font("Times New Roman", 12F);
            txtNombreEliminar.Location = new Point(7, 36);
            txtNombreEliminar.Margin = new Padding(7, 3, 7, 22);
            txtNombreEliminar.Multiline = true;
            txtNombreEliminar.Name = "txtNombreEliminar";
            txtNombreEliminar.Size = new Size(231, 35);
            txtNombreEliminar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(982, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(111, 37);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.Controls.Add(label11, 0, 0);
            tableLayoutPanel5.Controls.Add(cbxEliminar, 2, 0);
            tableLayoutPanel5.Controls.Add(btnBuscarEliminar, 3, 0);
            tableLayoutPanel5.Controls.Add(btnLimpiarEliminar, 5, 0);
            tableLayoutPanel5.Controls.Add(txtBuscarEliminar, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Margin = new Padding(3, 10, 3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1098, 67);
            tableLayoutPanel5.TabIndex = 2;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.Location = new Point(3, 24);
            label11.Name = "label11";
            label11.Size = new Size(70, 19);
            label11.TabIndex = 33;
            label11.Text = "Buscar:";
            // 
            // cbxEliminar
            // 
            cbxEliminar.Anchor = AnchorStyles.None;
            cbxEliminar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEliminar.Font = new Font("Times New Roman", 12F);
            cbxEliminar.FormattingEnabled = true;
            cbxEliminar.Items.AddRange(new object[] { "NOMBRE", "DIRECCION", "TELEFONO", "EMAIL", "FECHA_REGISTRO" });
            cbxEliminar.Location = new Point(610, 20);
            cbxEliminar.Name = "cbxEliminar";
            cbxEliminar.Size = new Size(251, 27);
            cbxEliminar.TabIndex = 35;
            // 
            // btnBuscarEliminar
            // 
            btnBuscarEliminar.Anchor = AnchorStyles.None;
            btnBuscarEliminar.Location = new Point(867, 15);
            btnBuscarEliminar.Name = "btnBuscarEliminar";
            btnBuscarEliminar.Size = new Size(111, 37);
            btnBuscarEliminar.TabIndex = 2;
            btnBuscarEliminar.Text = "Buscar";
            btnBuscarEliminar.UseVisualStyleBackColor = true;
            btnBuscarEliminar.Click += btnBuscarEliminar_Click;
            // 
            // btnLimpiarEliminar
            // 
            btnLimpiarEliminar.Anchor = AnchorStyles.None;
            btnLimpiarEliminar.Location = new Point(984, 15);
            btnLimpiarEliminar.Name = "btnLimpiarEliminar";
            btnLimpiarEliminar.Size = new Size(111, 37);
            btnLimpiarEliminar.TabIndex = 1;
            btnLimpiarEliminar.Text = "Limpiar";
            btnLimpiarEliminar.UseVisualStyleBackColor = true;
            btnLimpiarEliminar.Click += btnLimpiarEliminar_Click;
            // 
            // txtBuscarEliminar
            // 
            txtBuscarEliminar.Anchor = AnchorStyles.Left;
            txtBuscarEliminar.Font = new Font("Times New Roman", 12F);
            txtBuscarEliminar.Location = new Point(79, 18);
            txtBuscarEliminar.MaxLength = 10;
            txtBuscarEliminar.Multiline = true;
            txtBuscarEliminar.Name = "txtBuscarEliminar";
            txtBuscarEliminar.Size = new Size(379, 31);
            txtBuscarEliminar.TabIndex = 34;
            txtBuscarEliminar.KeyPress += txtBuscarEliminar_KeyPress;
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 548);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProveedores";
            Text = "frmProveedores";
            Load += frmProveedores_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAgregarProve).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditar).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEliminar).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TabPage tabPage3;
        private Button btnLimpiarAgg;
        private Button btnBuscarAgg;
        private Label label1;
        private TextBox txtBuscarProducto;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNomProAgg;
        private TextBox txtCorreoAgg;
        private TextBox txtTelefinoAgg;
        private TextBox txtDirAgg;
        private DataGridView dgvAgregarProve;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private ComboBox cbxEditar;
        private Button btnBuscarEditar;
        private Button btnLimpiarEditar;
        private TextBox txtBuscarEditar;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtCorreoEditar;
        private TextBox txtTelEditar;
        private TextBox txtDirEditar;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtNombreEditar;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label11;
        private ComboBox cbxEliminar;
        private Button btnBuscarEliminar;
        private Button btnLimpiarEliminar;
        private TextBox txtBuscarEliminar;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtCorreoEliminar;
        private TextBox txtTelEliminar;
        private TextBox txtDirEliminar;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtNombreEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnEliminar;
        private DataGridView dgvEditar;
        private DataGridView dgvEliminar;
        private ComboBox comboBox1;
    }
}