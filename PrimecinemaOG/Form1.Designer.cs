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
            pictureBox1 = new PictureBox();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtb_correo1
            // 
            txtb_correo1.Anchor = AnchorStyles.Bottom;
            txtb_correo1.Location = new Point(289, 216);
            txtb_correo1.Name = "txtb_correo1";
            txtb_correo1.Size = new Size(213, 23);
            txtb_correo1.TabIndex = 0;
            // 
            // lbl_inicio
            // 
            lbl_inicio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_inicio.Location = new Point(257, 147);
            lbl_inicio.Name = "lbl_inicio";
            lbl_inicio.Size = new Size(276, 55);
            lbl_inicio.TabIndex = 5;
            lbl_inicio.Text = "PrimeCinema";
            lbl_inicio.TextAlign = ContentAlignment.TopCenter;
            lbl_inicio.Click += lbl_inicio_Click;
            // 
            // lbl_correo
            // 
            lbl_correo.Anchor = AnchorStyles.Bottom;
            lbl_correo.AutoSize = true;
            lbl_correo.Location = new Point(289, 198);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(43, 15);
            lbl_correo.TabIndex = 6;
            lbl_correo.Text = "Correo";
            // 
            // txtb_contra
            // 
            txtb_contra.Anchor = AnchorStyles.Bottom;
            txtb_contra.Location = new Point(289, 275);
            txtb_contra.Name = "txtb_contra";
            txtb_contra.Size = new Size(213, 23);
            txtb_contra.TabIndex = 1;
            // 
            // lbl_contra
            // 
            lbl_contra.Anchor = AnchorStyles.Bottom;
            lbl_contra.AutoSize = true;
            lbl_contra.Location = new Point(289, 257);
            lbl_contra.Name = "lbl_contra";
            lbl_contra.Size = new Size(67, 15);
            lbl_contra.TabIndex = 7;
            lbl_contra.Text = "Contraseña";
            // 
            // chk_mostrar_contra
            // 
            chk_mostrar_contra.Anchor = AnchorStyles.Bottom;
            chk_mostrar_contra.AutoSize = true;
            chk_mostrar_contra.Location = new Point(289, 304);
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
            btn_iniciar_ses.Location = new Point(289, 338);
            btn_iniciar_ses.Name = "btn_iniciar_ses";
            btn_iniciar_ses.Size = new Size(87, 23);
            btn_iniciar_ses.TabIndex = 2;
            btn_iniciar_ses.Text = "Iniciar sesion";
            btn_iniciar_ses.UseVisualStyleBackColor = true;
            btn_iniciar_ses.Click += btn_iniciar_ses_Click;
            // 
            // btn_registro
            // 
            btn_registro.Anchor = AnchorStyles.Bottom;
            btn_registro.Location = new Point(427, 338);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(75, 23);
            btn_registro.TabIndex = 3;
            btn_registro.Text = "Registrarse";
            btn_registro.UseVisualStyleBackColor = true;
            btn_registro.Click += btn_registro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 406);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 9;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += button1_Click;
            // 
            // inicio_ses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(784, 441);
            Controls.Add(btn_salir);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_contra);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_inicio);
            Controls.Add(chk_mostrar_contra);
            Controls.Add(btn_registro);
            Controls.Add(btn_iniciar_ses);
            Controls.Add(txtb_contra);
            Controls.Add(txtb_correo1);
            Name = "inicio_ses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeCinema";
            Load += inicio_ses_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Button btn_salir;
    }
}