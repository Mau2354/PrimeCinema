namespace WinFormsApp2
{
    partial class Asiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asiento));
            label1 = new Label();
            label2 = new Label();
            textfila = new TextBox();
            textcolumna = new TextBox();
            btnReguistrar = new Button();
            btncancelar = new Button();
            grilla = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 61);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Fila: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 109);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Columna: \r\n";
            // 
            // textfila
            // 
            textfila.Location = new Point(106, 53);
            textfila.Name = "textfila";
            textfila.Size = new Size(100, 23);
            textfila.TabIndex = 2;
            // 
            // textcolumna
            // 
            textcolumna.Location = new Point(106, 106);
            textcolumna.Name = "textcolumna";
            textcolumna.Size = new Size(100, 23);
            textcolumna.TabIndex = 3;
            // 
            // btnReguistrar
            // 
            btnReguistrar.Location = new Point(90, 178);
            btnReguistrar.Name = "btnReguistrar";
            btnReguistrar.Size = new Size(92, 47);
            btnReguistrar.TabIndex = 4;
            btnReguistrar.Text = "Reguistrar";
            btnReguistrar.UseVisualStyleBackColor = true;
            btnReguistrar.Click += btnReguistrar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(380, 178);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(92, 47);
            btncancelar.TabIndex = 5;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(31, 241);
            grilla.Name = "grilla";
            grilla.RowTemplate.Height = 25;
            grilla.Size = new Size(514, 76);
            grilla.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Asiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(592, 362);
            Controls.Add(pictureBox1);
            Controls.Add(grilla);
            Controls.Add(btncancelar);
            Controls.Add(btnReguistrar);
            Controls.Add(textcolumna);
            Controls.Add(textfila);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Asiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asiento";
            Load += Asiento_Load;
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textfila;
        private TextBox textcolumna;
        private Button btnReguistrar;
        private Button btncancelar;
        private DataGridView grilla;
        private PictureBox pictureBox1;
    }
}