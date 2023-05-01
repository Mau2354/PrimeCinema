namespace Gerencia
{
    partial class ger1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ger1));
            Title1 = new Label();
            Title2 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            btn_reg = new Button();
            btn_exit = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            N_Salas = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Title1
            // 
            Title1.AutoSize = true;
            Title1.BackColor = Color.Transparent;
            Title1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title1.ForeColor = Color.Black;
            Title1.Location = new Point(176, 32);
            Title1.Name = "Title1";
            Title1.Size = new Size(233, 33);
            Title1.TabIndex = 0;
            Title1.Text = "[ Prime Cinema ]";
            // 
            // Title2
            // 
            Title2.AutoSize = true;
            Title2.BackColor = Color.Transparent;
            Title2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title2.ForeColor = Color.Black;
            Title2.Location = new Point(127, 81);
            Title2.Name = "Title2";
            Title2.Size = new Size(317, 33);
            Title2.TabIndex = 1;
            Title2.Text = "Registro de Sucursales";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(84, 143);
            label1.Name = "label1";
            label1.Size = new Size(190, 29);
            label1.TabIndex = 3;
            label1.Text = "Nombre de Sucursal:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(84, 189);
            label2.Name = "label2";
            label2.Size = new Size(190, 29);
            label2.TabIndex = 5;
            label2.Text = "Nombre de Gerente:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(68, 235);
            label3.Name = "label3";
            label3.Size = new Size(206, 29);
            label3.TabIndex = 7;
            label3.Text = "Telefono de Sucursal:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(280, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(68, 277);
            label4.Name = "label4";
            label4.Size = new Size(215, 29);
            label4.TabIndex = 9;
            label4.Text = "Dirección de Sucursal:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(280, 283);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 23);
            textBox4.TabIndex = 8;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(392, 374);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(96, 39);
            btn_reg.TabIndex = 10;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(101, 374);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(96, 39);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "Salir";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += Btn_exit_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(67, 319);
            label5.Name = "label5";
            label5.Size = new Size(190, 29);
            label5.TabIndex = 14;
            label5.Text = "Numero de Salas:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // N_Salas
            // 
            N_Salas.Location = new Point(280, 325);
            N_Salas.Name = "N_Salas";
            N_Salas.Size = new Size(209, 23);
            N_Salas.TabIndex = 13;
            N_Salas.TextChanged += N_Salas_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // ger1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(589, 453);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(N_Salas);
            Controls.Add(comboBox1);
            Controls.Add(btn_exit);
            Controls.Add(btn_reg);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(Title2);
            Controls.Add(Title1);
            Name = "ger1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Management Window";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label Title1;
        private Label Title2;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button btn_reg;
        private Button btn_exit;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox N_Salas;
        private PictureBox pictureBox1;
    }
}