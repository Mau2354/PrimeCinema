namespace PrimecinemaOG
{
    partial class Compra_bolet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra_bolet));
            cb_formato = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btn_siguiente = new Button();
            btn_regresar = new Button();
            numericUpDown1 = new NumericUpDown();
            btn_salir = new Button();
            cb_edad = new CheckBox();
            pb_6 = new PictureBox();
            pb_5 = new PictureBox();
            pb_4 = new PictureBox();
            pb_3 = new PictureBox();
            pb_2 = new PictureBox();
            pb_1 = new PictureBox();
            chk_barbi1 = new CheckBox();
            chk_barbi2 = new CheckBox();
            chk_barbi3 = new CheckBox();
            chk_it = new CheckBox();
            chk_saw = new CheckBox();
            chk_rpf = new CheckBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).BeginInit();
            SuspendLayout();
            // 
            // cb_formato
            // 
            cb_formato.FormattingEnabled = true;
            cb_formato.Location = new Point(125, 206);
            cb_formato.Name = "cb_formato";
            cb_formato.Size = new Size(121, 23);
            cb_formato.TabIndex = 0;
            cb_formato.SelectedIndexChanged += cb_formato_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 60);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Cantidad de tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 163);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Formato";
            // 
            // btn_siguiente
            // 
            btn_siguiente.Location = new Point(125, 307);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(75, 23);
            btn_siguiente.TabIndex = 3;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = true;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // btn_regresar
            // 
            btn_regresar.Location = new Point(268, 307);
            btn_regresar.Name = "btn_regresar";
            btn_regresar.Size = new Size(75, 23);
            btn_regresar.TabIndex = 4;
            btn_regresar.Text = "Regresar";
            btn_regresar.UseVisualStyleBackColor = true;
            btn_regresar.Click += btn_regresar_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(125, 109);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(121, 23);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 406);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 10;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // cb_edad
            // 
            cb_edad.AutoSize = true;
            cb_edad.Location = new Point(125, 257);
            cb_edad.Name = "cb_edad";
            cb_edad.Size = new Size(92, 19);
            cb_edad.TabIndex = 12;
            cb_edad.Text = "Tercera edad";
            cb_edad.UseVisualStyleBackColor = true;
            // 
            // pb_6
            // 
            pb_6.Image = (Image)resources.GetObject("pb_6.Image");
            pb_6.Location = new Point(617, 211);
            pb_6.Name = "pb_6";
            pb_6.Size = new Size(85, 124);
            pb_6.SizeMode = PictureBoxSizeMode.Zoom;
            pb_6.TabIndex = 18;
            pb_6.TabStop = false;
            pb_6.Click += pb_6_Click;
            // 
            // pb_5
            // 
            pb_5.Image = (Image)resources.GetObject("pb_5.Image");
            pb_5.Location = new Point(526, 211);
            pb_5.Name = "pb_5";
            pb_5.Size = new Size(85, 124);
            pb_5.SizeMode = PictureBoxSizeMode.Zoom;
            pb_5.TabIndex = 17;
            pb_5.TabStop = false;
            pb_5.Click += pb_5_Click;
            // 
            // pb_4
            // 
            pb_4.Image = (Image)resources.GetObject("pb_4.Image");
            pb_4.Location = new Point(435, 211);
            pb_4.Name = "pb_4";
            pb_4.Size = new Size(85, 124);
            pb_4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_4.TabIndex = 16;
            pb_4.TabStop = false;
            pb_4.Click += pb_4_Click;
            // 
            // pb_3
            // 
            pb_3.Image = (Image)resources.GetObject("pb_3.Image");
            pb_3.Location = new Point(617, 81);
            pb_3.Name = "pb_3";
            pb_3.Size = new Size(85, 124);
            pb_3.SizeMode = PictureBoxSizeMode.Zoom;
            pb_3.TabIndex = 15;
            pb_3.TabStop = false;
            pb_3.Click += pb_3_Click;
            // 
            // pb_2
            // 
            pb_2.Image = (Image)resources.GetObject("pb_2.Image");
            pb_2.Location = new Point(526, 81);
            pb_2.Name = "pb_2";
            pb_2.Size = new Size(85, 124);
            pb_2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_2.TabIndex = 14;
            pb_2.TabStop = false;
            pb_2.Click += pb_2_Click;
            // 
            // pb_1
            // 
            pb_1.Image = (Image)resources.GetObject("pb_1.Image");
            pb_1.Location = new Point(435, 81);
            pb_1.Name = "pb_1";
            pb_1.Size = new Size(85, 124);
            pb_1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_1.TabIndex = 13;
            pb_1.TabStop = false;
            pb_1.Click += pb_1_Click;
            // 
            // chk_barbi1
            // 
            chk_barbi1.AutoSize = true;
            chk_barbi1.Location = new Point(435, 81);
            chk_barbi1.Name = "chk_barbi1";
            chk_barbi1.Size = new Size(15, 14);
            chk_barbi1.TabIndex = 19;
            chk_barbi1.UseVisualStyleBackColor = true;
            chk_barbi1.CheckedChanged += chk_barbi1_CheckedChanged;
            // 
            // chk_barbi2
            // 
            chk_barbi2.AutoSize = true;
            chk_barbi2.Location = new Point(526, 81);
            chk_barbi2.Name = "chk_barbi2";
            chk_barbi2.Size = new Size(15, 14);
            chk_barbi2.TabIndex = 20;
            chk_barbi2.UseVisualStyleBackColor = true;
            chk_barbi2.CheckedChanged += chk_barbi2_CheckedChanged;
            // 
            // chk_barbi3
            // 
            chk_barbi3.AutoSize = true;
            chk_barbi3.Location = new Point(617, 81);
            chk_barbi3.Name = "chk_barbi3";
            chk_barbi3.Size = new Size(15, 14);
            chk_barbi3.TabIndex = 21;
            chk_barbi3.UseVisualStyleBackColor = true;
            chk_barbi3.CheckedChanged += chk_barbi3_CheckedChanged;
            // 
            // chk_it
            // 
            chk_it.AutoSize = true;
            chk_it.Location = new Point(435, 211);
            chk_it.Name = "chk_it";
            chk_it.Size = new Size(15, 14);
            chk_it.TabIndex = 22;
            chk_it.UseVisualStyleBackColor = true;
            chk_it.CheckedChanged += chk_it_CheckedChanged;
            // 
            // chk_saw
            // 
            chk_saw.AutoSize = true;
            chk_saw.Location = new Point(526, 211);
            chk_saw.Name = "chk_saw";
            chk_saw.Size = new Size(15, 14);
            chk_saw.TabIndex = 23;
            chk_saw.UseVisualStyleBackColor = true;
            chk_saw.CheckedChanged += chk_saw_CheckedChanged;
            // 
            // chk_rpf
            // 
            chk_rpf.AutoSize = true;
            chk_rpf.Location = new Point(617, 210);
            chk_rpf.Name = "chk_rpf";
            chk_rpf.Size = new Size(15, 14);
            chk_rpf.TabIndex = 24;
            chk_rpf.UseVisualStyleBackColor = true;
            chk_rpf.CheckedChanged += chk_rpf_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 49);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 25;
            label3.Text = "Elegirr pelicula";
            // 
            // Compra_bolet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(784, 441);
            Controls.Add(label3);
            Controls.Add(chk_rpf);
            Controls.Add(chk_saw);
            Controls.Add(chk_it);
            Controls.Add(chk_barbi3);
            Controls.Add(chk_barbi2);
            Controls.Add(chk_barbi1);
            Controls.Add(pb_6);
            Controls.Add(pb_5);
            Controls.Add(pb_4);
            Controls.Add(pb_3);
            Controls.Add(pb_2);
            Controls.Add(pb_1);
            Controls.Add(cb_edad);
            Controls.Add(btn_salir);
            Controls.Add(numericUpDown1);
            Controls.Add(btn_regresar);
            Controls.Add(btn_siguiente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_formato);
            Name = "Compra_bolet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
            Load += Compra_bolet_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_formato;
        private Label label1;
        private Label label2;
        private Button btn_siguiente;
        private Button btn_regresar;
        private NumericUpDown numericUpDown1;
        private Button btn_salir;
        private CheckBox cb_edad;
        private PictureBox pb_6;
        private PictureBox pb_5;
        private PictureBox pb_4;
        private PictureBox pb_3;
        private PictureBox pb_2;
        private PictureBox pb_1;
        private CheckBox chk_barbi1;
        private CheckBox chk_barbi2;
        private CheckBox chk_barbi3;
        private CheckBox chk_it;
        private CheckBox chk_saw;
        private CheckBox chk_rpf;
        private Label label3;
    }
}