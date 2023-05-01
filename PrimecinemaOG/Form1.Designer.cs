namespace PrimecinemaOG
{
    partial class inicio_ses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio_ses));
            txtb_correo1 = new TextBox();
            lbl_inicio = new Label();
            lbl_correo = new Label();
            txtb_contra = new TextBox();
            lbl_contra = new Label();
            chk_mostrar_contra = new CheckBox();
            btn_iniciar_ses = new Button();
            btn_registro = new Button();
            btn_salir = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtb_correo1
            // 
            txtb_correo1.Anchor = AnchorStyles.Bottom;
            txtb_correo1.Location = new Point(380, 177);
            txtb_correo1.Name = "txtb_correo1";
            txtb_correo1.Size = new Size(221, 23);
            txtb_correo1.TabIndex = 0;
            // 
            // lbl_inicio
            // 
            lbl_inicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_inicio.BackColor = Color.Black;
            lbl_inicio.Font = new Font("Segoe MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_inicio.ForeColor = Color.Red;
            lbl_inicio.Location = new Point(0, 19);
            lbl_inicio.Name = "lbl_inicio";
            lbl_inicio.Size = new Size(277, 46);
            lbl_inicio.TabIndex = 5;
            lbl_inicio.Text = "PrimeCinema";
            lbl_inicio.TextAlign = ContentAlignment.TopCenter;
            lbl_inicio.Click += lbl_inicio_Click_1;
            // 
            // lbl_correo
            // 
            lbl_correo.Anchor = AnchorStyles.Bottom;
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(380, 159);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(43, 15);
            lbl_correo.TabIndex = 6;
            lbl_correo.Text = "Correo";
            // 
            // txtb_contra
            // 
            txtb_contra.Anchor = AnchorStyles.Bottom;
            txtb_contra.Location = new Point(380, 236);
            txtb_contra.Name = "txtb_contra";
            txtb_contra.Size = new Size(221, 23);
            txtb_contra.TabIndex = 1;
            // 
            // lbl_contra
            // 
            lbl_contra.Anchor = AnchorStyles.Bottom;
            lbl_contra.AutoSize = true;
            lbl_contra.Location = new Point(380, 218);
            lbl_contra.Name = "lbl_contra";
            lbl_contra.Size = new Size(67, 15);
            lbl_contra.TabIndex = 7;
            lbl_contra.Text = "Contraseña";
            // 
            // chk_mostrar_contra
            // 
            chk_mostrar_contra.Anchor = AnchorStyles.Bottom;
            chk_mostrar_contra.AutoSize = true;
            chk_mostrar_contra.Location = new Point(380, 265);
            chk_mostrar_contra.Name = "chk_mostrar_contra";
            chk_mostrar_contra.Size = new Size(128, 19);
            chk_mostrar_contra.TabIndex = 4;
            chk_mostrar_contra.Text = "Mostrar contraseña";
            chk_mostrar_contra.UseVisualStyleBackColor = true;
            chk_mostrar_contra.CheckedChanged += chk_mostrar_contra_CheckedChanged;
            // 
            // btn_iniciar_ses
            // 
            btn_iniciar_ses.Anchor = AnchorStyles.Bottom;
            btn_iniciar_ses.Location = new Point(380, 299);
            btn_iniciar_ses.Name = "btn_iniciar_ses";
            btn_iniciar_ses.Size = new Size(95, 25);
            btn_iniciar_ses.TabIndex = 2;
            btn_iniciar_ses.Text = "Iniciar sesion";
            btn_iniciar_ses.UseVisualStyleBackColor = true;
            btn_iniciar_ses.Click += btn_iniciar_ses_Click_1;
            // 
            // btn_registro
            // 
            btn_registro.Anchor = AnchorStyles.Bottom;
            btn_registro.Location = new Point(518, 299);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(83, 25);
            btn_registro.TabIndex = 3;
            btn_registro.Text = "Registrarse";
            btn_registro.UseVisualStyleBackColor = true;
            btn_registro.Click += btn_registro_Click_1;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(52, 397);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_inicio);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 89);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(556, 29);
            label2.Name = "label2";
            label2.Size = new Size(203, 35);
            label2.TabIndex = 13;
            label2.Text = "BIENVENID@S";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 216);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(73, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 218);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(58, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 218);
            panel2.TabIndex = 14;
            // 
            // inicio_ses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(784, 441);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_salir);
            Controls.Add(lbl_contra);
            Controls.Add(lbl_correo);
            Controls.Add(chk_mostrar_contra);
            Controls.Add(btn_registro);
            Controls.Add(btn_iniciar_ses);
            Controls.Add(txtb_contra);
            Controls.Add(txtb_correo1);
            Name = "inicio_ses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeCinema";
            Load += inicio_ses_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_correo1;
        private Label lbl_inicio;
        private Label lbl_correo;
        private TextBox txtb_contra;
        private Label lbl_contra;
        private CheckBox chk_mostrar_contra;
        private Button btn_iniciar_ses;
        private Button btn_registro;
        private Button btn_salir;
        private Panel panel1;
        public Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel2;
    }
}