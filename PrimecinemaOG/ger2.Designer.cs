namespace Gerencia
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
            title1 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_r = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // title1
            // 
            title1.AutoSize = true;
            title1.BackColor = Color.Transparent;
            title1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            title1.ForeColor = Color.Black;
            title1.Location = new Point(143, 31);
            title1.Name = "title1";
            title1.Size = new Size(281, 31);
            title1.TabIndex = 0;
            title1.Text = "Datos de las Peliculas";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(143, 114);
            label1.Name = "label1";
            label1.Size = new Size(160, 23);
            label1.TabIndex = 2;
            label1.Text = "Numero de Salas";
            label1.Click += label1_Click;
            // 
            // btn_r
            // 
            btn_r.Location = new Point(413, 224);
            btn_r.Name = "btn_r";
            btn_r.Size = new Size(75, 23);
            btn_r.TabIndex = 3;
            btn_r.Text = "Registrar";
            btn_r.UseVisualStyleBackColor = true;
            btn_r.Click += btn_r_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(152, 224);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Salir";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Cartelera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(645, 327);
            Controls.Add(btn_exit);
            Controls.Add(btn_r);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(title1);
            Name = "Cartelera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cartelera";
            Load += Cartelera_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title1;
        private TextBox textBox1;
        private Label label1;
        private Button btn_r;
        private Button btn_exit;
    }
}