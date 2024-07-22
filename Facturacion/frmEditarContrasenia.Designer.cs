namespace Facturacion
{
    partial class frmEditarContrasenia
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtContra2 = new TextBox();
            txtContra1 = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 8);
            label1.Name = "label1";
            label1.Size = new Size(110, 24);
            label1.TabIndex = 3;
            label1.Text = "USUARIO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.Location = new Point(72, 68);
            label2.Name = "label2";
            label2.Size = new Size(208, 24);
            label2.TabIndex = 4;
            label2.Text = "Ingrese Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label3.Location = new Point(64, 143);
            label3.Name = "label3";
            label3.Size = new Size(233, 24);
            label3.TabIndex = 5;
            label3.Text = "Confirmar Contraseña";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(70, 223);
            button1.Name = "button1";
            button1.Size = new Size(209, 47);
            button1.TabIndex = 6;
            button1.Text = "Cambiar Contraseña";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContra2
            // 
            txtContra2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            txtContra2.Location = new Point(63, 170);
            txtContra2.Multiline = true;
            txtContra2.Name = "txtContra2";
            txtContra2.PasswordChar = '*';
            txtContra2.Size = new Size(223, 36);
            txtContra2.TabIndex = 7;
            txtContra2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContra1
            // 
            txtContra1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            txtContra1.Location = new Point(63, 95);
            txtContra1.Multiline = true;
            txtContra1.Name = "txtContra1";
            txtContra1.PasswordChar = '*';
            txtContra1.Size = new Size(223, 36);
            txtContra1.TabIndex = 8;
            txtContra1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtContra1);
            panel1.Controls.Add(txtContra2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(244, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 308);
            panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(341, 40);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // frmEditarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Como_cambiar_la_imagen_de_fondo_del_inicio_de_sesion_en_tu_Mac_professor_falken_com_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditarContrasenia";
            Text = "frmEditarContrasenia";
            TransparencyKey = SystemColors.ActiveCaption;
            Load += frmEditarContrasenia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtContra2;
        private TextBox txtContra1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}