namespace PrimecinemaOG
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            label1 = new Label();
            Grilla = new DataGridView();
            N_Column = new DataGridViewTextBoxColumn();
            CC_Column = new DataGridViewTextBoxColumn();
            DUI_Column = new DataGridViewTextBoxColumn();
            D_Column = new DataGridViewTextBoxColumn();
            T_Column = new DataGridViewTextBoxColumn();
            C_Column = new DataGridViewTextBoxColumn();
            M_Button = new Button();
            label2 = new Label();
            Grillo = new DataGridView();
            T_S_Column = new DataGridViewTextBoxColumn();
            N_G_Column = new DataGridViewTextBoxColumn();
            N_S_Column = new DataGridViewTextBoxColumn();
            D_S_Column = new DataGridViewTextBoxColumn();
            S_Column = new DataGridViewTextBoxColumn();
            Register_button = new Button();
            Export_Button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grillo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 263);
            label1.Name = "label1";
            label1.Size = new Size(272, 29);
            label1.TabIndex = 0;
            label1.Text = "Registros de Clientes ";
            label1.Click += label1_Click;
            // 
            // Grilla
            // 
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Columns.AddRange(new DataGridViewColumn[] { N_Column, CC_Column, DUI_Column, D_Column, T_Column, C_Column });
            Grilla.Location = new Point(47, 299);
            Grilla.Name = "Grilla";
            Grilla.RowTemplate.Height = 25;
            Grilla.Size = new Size(641, 150);
            Grilla.TabIndex = 2;
            Grilla.CellContentClick += Grilla_CellContentClick;
            // 
            // N_Column
            // 
            N_Column.HeaderText = "Nombre";
            N_Column.Name = "N_Column";
            // 
            // CC_Column
            // 
            CC_Column.HeaderText = "Contraseña";
            CC_Column.Name = "CC_Column";
            // 
            // DUI_Column
            // 
            DUI_Column.HeaderText = "DUI";
            DUI_Column.Name = "DUI_Column";
            // 
            // D_Column
            // 
            D_Column.HeaderText = "Dirección";
            D_Column.Name = "D_Column";
            // 
            // T_Column
            // 
            T_Column.HeaderText = "Telefono";
            T_Column.Name = "T_Column";
            // 
            // C_Column
            // 
            C_Column.HeaderText = "Correo";
            C_Column.Name = "C_Column";
            // 
            // M_Button
            // 
            M_Button.Location = new Point(581, 220);
            M_Button.Name = "M_Button";
            M_Button.Size = new Size(107, 30);
            M_Button.TabIndex = 3;
            M_Button.Text = "mostrar datos";
            M_Button.UseVisualStyleBackColor = true;
            M_Button.Click += M_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 64);
            label2.Name = "label2";
            label2.Size = new Size(225, 29);
            label2.TabIndex = 4;
            label2.Text = "Datos de Sucursal";
            label2.Click += label2_Click;
            // 
            // Grillo
            // 
            Grillo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grillo.Columns.AddRange(new DataGridViewColumn[] { T_S_Column, N_G_Column, N_S_Column, D_S_Column, S_Column });
            Grillo.Location = new Point(59, 100);
            Grillo.Name = "Grillo";
            Grillo.RowTemplate.Height = 25;
            Grillo.Size = new Size(516, 150);
            Grillo.TabIndex = 5;
            Grillo.CellContentClick += Grillo_CellContentClick;
            // 
            // T_S_Column
            // 
            T_S_Column.HeaderText = "Telefono de Sucursal";
            T_S_Column.Name = "T_S_Column";
            T_S_Column.Resizable = DataGridViewTriState.False;
            // 
            // N_G_Column
            // 
            N_G_Column.HeaderText = "Nombre de Gerente";
            N_G_Column.Name = "N_G_Column";
            // 
            // N_S_Column
            // 
            N_S_Column.HeaderText = "Nombre de Sucursal";
            N_S_Column.Name = "N_S_Column";
            // 
            // D_S_Column
            // 
            D_S_Column.HeaderText = "Direccion de Sucursal";
            D_S_Column.Name = "D_S_Column";
            // 
            // S_Column
            // 
            S_Column.HeaderText = "Numero de Salas";
            S_Column.Name = "S_Column";
            // 
            // Register_button
            // 
            Register_button.Location = new Point(581, 167);
            Register_button.Name = "Register_button";
            Register_button.Size = new Size(107, 30);
            Register_button.TabIndex = 6;
            Register_button.Text = "registrar datos";
            Register_button.UseVisualStyleBackColor = true;
            Register_button.Click += Register_button_Click;
            // 
            // Export_Button
            // 
            Export_Button.Location = new Point(581, 111);
            Export_Button.Name = "Export_Button";
            Export_Button.Size = new Size(107, 30);
            Export_Button.TabIndex = 7;
            Export_Button.Text = "exportar datos";
            Export_Button.UseVisualStyleBackColor = true;
            Export_Button.Click += Export_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(740, 483);
            Controls.Add(pictureBox1);
            Controls.Add(Export_Button);
            Controls.Add(Register_button);
            Controls.Add(Grillo);
            Controls.Add(label2);
            Controls.Add(M_Button);
            Controls.Add(Grilla);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grillo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Grilla;
        private Button M_Button;
        private Label label2;
        private DataGridView Grillo;
        private DataGridViewTextBoxColumn N_Column;
        private DataGridViewTextBoxColumn CC_Column;
        private DataGridViewTextBoxColumn DUI_Column;
        private DataGridViewTextBoxColumn D_Column;
        private DataGridViewTextBoxColumn T_Column;
        private DataGridViewTextBoxColumn C_Column;
        private Button Register_button;
        private DataGridViewTextBoxColumn T_S_Column;
        private DataGridViewTextBoxColumn N_G_Column;
        private DataGridViewTextBoxColumn N_S_Column;
        private DataGridViewTextBoxColumn D_S_Column;
        private DataGridViewTextBoxColumn S_Column;
        private Button Export_Button;
        private PictureBox pictureBox1;
    }
}