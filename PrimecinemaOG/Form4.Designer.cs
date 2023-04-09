namespace PrimecinemaOG
{
    partial class Cartelera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cartelera));
            cb_sucurales = new ComboBox();
            lbl_sucursal = new Label();
            pb_1 = new PictureBox();
            pb_2 = new PictureBox();
            pb_3 = new PictureBox();
            pb_4 = new PictureBox();
            pb_5 = new PictureBox();
            pb_6 = new PictureBox();
            lbl_pelis = new Label();
            btn_siguiente = new Button();
            button2 = new Button();
            lbl_press = new Label();
            label1 = new Label();
            btn_salir = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).BeginInit();
            SuspendLayout();
            // 
            // cb_sucurales
            // 
            cb_sucurales.FormattingEnabled = true;
            cb_sucurales.Location = new Point(76, 94);
            cb_sucurales.MaxDropDownItems = 10;
            cb_sucurales.Name = "cb_sucurales";
            cb_sucurales.Size = new Size(194, 23);
            cb_sucurales.TabIndex = 0;
            cb_sucurales.SelectedIndexChanged += cb_sucurales_SelectedIndexChanged;
            // 
            // lbl_sucursal
            // 
            lbl_sucursal.AutoSize = true;
            lbl_sucursal.Location = new Point(76, 23);
            lbl_sucursal.Name = "lbl_sucursal";
            lbl_sucursal.Size = new Size(51, 15);
            lbl_sucursal.TabIndex = 1;
            lbl_sucursal.Text = "Sucursal";
            // 
            // pb_1
            // 
            pb_1.Image = (Image)resources.GetObject("pb_1.Image");
            pb_1.Location = new Point(352, 71);
            pb_1.Name = "pb_1";
            pb_1.Size = new Size(122, 155);
            pb_1.SizeMode = PictureBoxSizeMode.Zoom;
            pb_1.TabIndex = 2;
            pb_1.TabStop = false;
            pb_1.Click += pb_1_Click;
            // 
            // pb_2
            // 
            pb_2.Image = (Image)resources.GetObject("pb_2.Image");
            pb_2.Location = new Point(480, 71);
            pb_2.Name = "pb_2";
            pb_2.Size = new Size(122, 155);
            pb_2.SizeMode = PictureBoxSizeMode.Zoom;
            pb_2.TabIndex = 3;
            pb_2.TabStop = false;
            pb_2.Click += pb_2_Click;
            // 
            // pb_3
            // 
            pb_3.Image = (Image)resources.GetObject("pb_3.Image");
            pb_3.Location = new Point(608, 71);
            pb_3.Name = "pb_3";
            pb_3.Size = new Size(122, 155);
            pb_3.SizeMode = PictureBoxSizeMode.Zoom;
            pb_3.TabIndex = 4;
            pb_3.TabStop = false;
            pb_3.Click += pb_3_Click;
            // 
            // pb_4
            // 
            pb_4.Image = (Image)resources.GetObject("pb_4.Image");
            pb_4.Location = new Point(352, 232);
            pb_4.Name = "pb_4";
            pb_4.Size = new Size(122, 155);
            pb_4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_4.TabIndex = 5;
            pb_4.TabStop = false;
            pb_4.Click += pb_4_Click;
            // 
            // pb_5
            // 
            pb_5.Image = (Image)resources.GetObject("pb_5.Image");
            pb_5.Location = new Point(480, 232);
            pb_5.Name = "pb_5";
            pb_5.Size = new Size(122, 155);
            pb_5.SizeMode = PictureBoxSizeMode.Zoom;
            pb_5.TabIndex = 6;
            pb_5.TabStop = false;
            pb_5.Click += pb_5_Click;
            // 
            // pb_6
            // 
            pb_6.Image = (Image)resources.GetObject("pb_6.Image");
            pb_6.Location = new Point(608, 232);
            pb_6.Name = "pb_6";
            pb_6.Size = new Size(122, 155);
            pb_6.SizeMode = PictureBoxSizeMode.Zoom;
            pb_6.TabIndex = 7;
            pb_6.TabStop = false;
            pb_6.Click += pb_6_Click;
            // 
            // lbl_pelis
            // 
            lbl_pelis.AutoSize = true;
            lbl_pelis.Location = new Point(480, 23);
            lbl_pelis.Name = "lbl_pelis";
            lbl_pelis.Size = new Size(54, 15);
            lbl_pelis.TabIndex = 8;
            lbl_pelis.Text = "Cartelera";
            // 
            // btn_siguiente
            // 
            btn_siguiente.Location = new Point(76, 255);
            btn_siguiente.Name = "btn_siguiente";
            btn_siguiente.Size = new Size(75, 23);
            btn_siguiente.TabIndex = 9;
            btn_siguiente.Text = "Siguiente";
            btn_siguiente.UseVisualStyleBackColor = true;
            btn_siguiente.Click += btn_siguiente_Click;
            // 
            // button2
            // 
            button2.Location = new Point(195, 255);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl_press
            // 
            lbl_press.AutoSize = true;
            lbl_press.Location = new Point(352, 407);
            lbl_press.Name = "lbl_press";
            lbl_press.Size = new Size(231, 15);
            lbl_press.TabIndex = 11;
            lbl_press.Text = "(Presionar el poster para mas informacion)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 76);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 12;
            label1.Text = "Seleccionar sucursal";
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(12, 407);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 23);
            btn_salir.TabIndex = 13;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += button1_Click;
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(784, 441);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(lbl_press);
            Controls.Add(button2);
            Controls.Add(btn_siguiente);
            Controls.Add(lbl_pelis);
            Controls.Add(pb_6);
            Controls.Add(pb_5);
            Controls.Add(pb_4);
            Controls.Add(pb_3);
            Controls.Add(pb_2);
            Controls.Add(pb_1);
            Controls.Add(lbl_sucursal);
            Controls.Add(cb_sucurales);
            Name = "Cartelera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cartelera";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pb_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_sucurales;
        private Label lbl_sucursal;
        private PictureBox pb_1;
        private PictureBox pb_2;
        private PictureBox pb_3;
        private PictureBox pb_4;
        private PictureBox pb_5;
        private PictureBox pb_6;
        private Label lbl_pelis;
        private Button btn_siguiente;
        private Button button2;
        private Label lbl_press;
        private Label label1;
        private Button btn_salir;
    }
}