﻿namespace Facturacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_lateral = new Panel();
            btnProveedores = new Button();
            btnEmpleados = new Button();
            panel_iz_inf = new Panel();
            textBox1 = new TextBox();
            btn_ventas = new Button();
            btm_facturas = new Button();
            btn_productos = new Button();
            btn_clientes = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel_central = new Panel();
            panel2 = new Panel();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel_inferior = new Panel();
            textBox2 = new TextBox();
            panel_lateral.SuspendLayout();
            panel_iz_inf.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_central.SuspendLayout();
            panel2.SuspendLayout();
            panel_inferior.SuspendLayout();
            SuspendLayout();
            // 
            // panel_lateral
            // 
            panel_lateral.AutoScroll = true;
            panel_lateral.BackColor = Color.SteelBlue;
            panel_lateral.Controls.Add(btnProveedores);
            panel_lateral.Controls.Add(btnEmpleados);
            panel_lateral.Controls.Add(panel_iz_inf);
            panel_lateral.Controls.Add(btn_ventas);
            panel_lateral.Controls.Add(btm_facturas);
            panel_lateral.Controls.Add(btn_productos);
            panel_lateral.Controls.Add(btn_clientes);
            panel_lateral.Controls.Add(panel1);
            panel_lateral.Dock = DockStyle.Left;
            panel_lateral.Location = new Point(0, 0);
            panel_lateral.Name = "panel_lateral";
            panel_lateral.Size = new Size(200, 591);
            panel_lateral.TabIndex = 0;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.SteelBlue;
            btnProveedores.Dock = DockStyle.Top;
            btnProveedores.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.Black;
            btnProveedores.Location = new Point(0, 375);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(200, 45);
            btnProveedores.TabIndex = 10;
            btnProveedores.Text = "Proveedores";
            btnProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.SteelBlue;
            btnEmpleados.Dock = DockStyle.Top;
            btnEmpleados.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btnEmpleados.ForeColor = Color.Black;
            btnEmpleados.Location = new Point(0, 330);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(200, 45);
            btnEmpleados.TabIndex = 9;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Visible = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // panel_iz_inf
            // 
            panel_iz_inf.Controls.Add(textBox1);
            panel_iz_inf.Dock = DockStyle.Bottom;
            panel_iz_inf.Location = new Point(0, 511);
            panel_iz_inf.Name = "panel_iz_inf";
            panel_iz_inf.Size = new Size(200, 80);
            panel_iz_inf.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SteelBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 80);
            textBox1.TabIndex = 0;
            textBox1.Text = "\r\nGCS-Grupo X\r\n2024-2025";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_ventas
            // 
            btn_ventas.BackColor = Color.SteelBlue;
            btn_ventas.Dock = DockStyle.Top;
            btn_ventas.FlatAppearance.BorderSize = 0;
            btn_ventas.FlatStyle = FlatStyle.Flat;
            btn_ventas.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_ventas.ForeColor = Color.Black;
            btn_ventas.Location = new Point(0, 285);
            btn_ventas.Name = "btn_ventas";
            btn_ventas.Size = new Size(200, 45);
            btn_ventas.TabIndex = 7;
            btn_ventas.Text = "Ventas";
            btn_ventas.TextAlign = ContentAlignment.MiddleLeft;
            btn_ventas.UseVisualStyleBackColor = false;
            btn_ventas.Click += btn_ventas_Click;
            // 
            // btm_facturas
            // 
            btm_facturas.BackColor = Color.SteelBlue;
            btm_facturas.Dock = DockStyle.Top;
            btm_facturas.FlatAppearance.BorderSize = 0;
            btm_facturas.FlatStyle = FlatStyle.Flat;
            btm_facturas.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btm_facturas.ForeColor = Color.Black;
            btm_facturas.Location = new Point(0, 240);
            btm_facturas.Name = "btm_facturas";
            btm_facturas.Size = new Size(200, 45);
            btm_facturas.TabIndex = 5;
            btm_facturas.Text = "Facturas";
            btm_facturas.TextAlign = ContentAlignment.MiddleLeft;
            btm_facturas.UseVisualStyleBackColor = false;
            btm_facturas.Click += btm_facturas_Click;
            // 
            // btn_productos
            // 
            btn_productos.BackColor = Color.SteelBlue;
            btn_productos.Dock = DockStyle.Top;
            btn_productos.FlatAppearance.BorderSize = 0;
            btn_productos.FlatStyle = FlatStyle.Flat;
            btn_productos.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_productos.ForeColor = Color.Black;
            btn_productos.Location = new Point(0, 195);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(200, 45);
            btn_productos.TabIndex = 3;
            btn_productos.Text = "Productos";
            btn_productos.TextAlign = ContentAlignment.MiddleLeft;
            btn_productos.UseVisualStyleBackColor = false;
            btn_productos.Click += btn_productos_Click;
            // 
            // btn_clientes
            // 
            btn_clientes.BackColor = Color.SteelBlue;
            btn_clientes.Dock = DockStyle.Top;
            btn_clientes.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btn_clientes.FlatAppearance.BorderSize = 0;
            btn_clientes.FlatStyle = FlatStyle.Flat;
            btn_clientes.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            btn_clientes.ForeColor = Color.Black;
            btn_clientes.Location = new Point(0, 150);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(200, 45);
            btn_clientes.TabIndex = 1;
            btn_clientes.Text = "Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_clientes.UseVisualStyleBackColor = false;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 150);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_central
            // 
            panel_central.AutoScroll = true;
            panel_central.BackgroundImage = Properties.Resources.Como_cambiar_la_imagen_de_fondo_del_inicio_de_sesion_en_tu_Mac_professor_falken_com_;
            panel_central.BackgroundImageLayout = ImageLayout.Stretch;
            panel_central.Controls.Add(panel2);
            panel_central.Dock = DockStyle.Fill;
            panel_central.Location = new Point(200, 0);
            panel_central.Name = "panel_central";
            panel_central.Size = new Size(794, 591);
            panel_central.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(251, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 337);
            panel2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Britannic Bold", 14.25F);
            textBox3.Location = new Point(54, 93);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 29);
            textBox3.TabIndex = 0;
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Britannic Bold", 16F);
            button1.Location = new Point(54, 218);
            button1.Name = "button1";
            button1.Size = new Size(192, 41);
            button1.TabIndex = 4;
            button1.Text = "INICIAR SESION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Britannic Bold", 14.25F);
            textBox4.Location = new Point(54, 165);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(192, 29);
            textBox4.TabIndex = 1;
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 16F);
            label2.Location = new Point(83, 137);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 65);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 2;
            label1.Text = "USUARIO";
            // 
            // panel_inferior
            // 
            panel_inferior.BackColor = Color.SteelBlue;
            panel_inferior.Controls.Add(textBox2);
            panel_inferior.Dock = DockStyle.Bottom;
            panel_inferior.Location = new Point(200, 491);
            panel_inferior.Name = "panel_inferior";
            panel_inferior.Size = new Size(794, 100);
            panel_inferior.TabIndex = 2;
            panel_inferior.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.SteelBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(0, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(794, 100);
            textBox2.TabIndex = 1;
            textBox2.Text = "\r\nGCS-Grupo X\r\n2024-2025";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 591);
            Controls.Add(panel_inferior);
            Controls.Add(panel_central);
            Controls.Add(panel_lateral);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "GCS FACTURA";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel_lateral.ResumeLayout(false);
            panel_iz_inf.ResumeLayout(false);
            panel_iz_inf.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_central.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_inferior.ResumeLayout(false);
            panel_inferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_central;
        private Panel panel_lateral;
        private Panel panel_inferior;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btn_clientes;
        private Button btn_productos;
        private Button btm_facturas;
        private Button btn_ventas;
        private Panel panel_iz_inf;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnEmpleados;
        private Panel panel2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label2;
        private Label label1;
        private Button btnProveedores;
    }
}
