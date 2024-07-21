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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 54);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(290, 114);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 4;
            label2.Text = "Ingrese Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 189);
            label3.Name = "label3";
            label3.Size = new Size(217, 23);
            label3.TabIndex = 5;
            label3.Text = "Confirmar Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(308, 257);
            button1.Name = "button1";
            button1.Size = new Size(153, 23);
            button1.TabIndex = 6;
            button1.Text = "Cambiar Contraseña";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContra2
            // 
            txtContra2.Location = new Point(275, 215);
            txtContra2.Name = "txtContra2";
            txtContra2.Size = new Size(206, 23);
            txtContra2.TabIndex = 7;
            // 
            // txtContra1
            // 
            txtContra1.Location = new Point(275, 140);
            txtContra1.Name = "txtContra1";
            txtContra1.Size = new Size(206, 23);
            txtContra1.TabIndex = 8;
            // 
            // frmEditarContrasenia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContra1);
            Controls.Add(txtContra2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditarContrasenia";
            Text = "frmEditarContrasenia";
            TransparencyKey = SystemColors.ActiveCaption;
            Load += frmEditarContrasenia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtContra2;
        private TextBox txtContra1;
    }
}