namespace ProyectForms
{
    partial class Form2
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
            button1ValidDatos = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1NId = new TextBox();
            textBox2Duenio = new TextBox();
            textBox3Anio = new TextBox();
            textBox4KmActual = new TextBox();
            textBoxDatos = new TextBox();
            comboBox1Modelo = new ComboBox();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            Column1NId = new DataGridViewTextBoxColumn();
            Column1Modelo = new DataGridViewTextBoxColumn();
            Column2Anio = new DataGridViewTextBoxColumn();
            Column3Duenio = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5Color = new DataGridViewTextBoxColumn();
            label12NId = new Label();
            label14Duenio = new Label();
            label15Anio = new Label();
            label16kmActual = new Label();
            label17Color = new Label();
            comboBox2Color = new ComboBox();
            label12Modelo = new Label();
            button2FinAlta = new Button();
            button1ModifDato = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1ValidDatos
            // 
            button1ValidDatos.Location = new Point(19, 287);
            button1ValidDatos.Name = "button1ValidDatos";
            button1ValidDatos.Size = new Size(409, 23);
            button1ValidDatos.TabIndex = 6;
            button1ValidDatos.Text = "VALIDAR DATOS";
            button1ValidDatos.UseVisualStyleBackColor = true;
            button1ValidDatos.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 62);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 9;
            label5.Text = "N° IDENTIFICADOR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 148);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 10;
            label6.Text = "AÑO FABRICACION";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 192);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 11;
            label7.Text = "KM-HS-ACTUAL";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 236);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 12;
            label8.Text = "COLOR";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 106);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 13;
            label9.Text = "DUEÑO-EMPRESA";
            // 
            // textBox1NId
            // 
            textBox1NId.Location = new Point(146, 54);
            textBox1NId.Name = "textBox1NId";
            textBox1NId.Size = new Size(282, 23);
            textBox1NId.TabIndex = 14;
            textBox1NId.TextChanged += textBox1_TextChanged;
            // 
            // textBox2Duenio
            // 
            textBox2Duenio.Location = new Point(146, 98);
            textBox2Duenio.Name = "textBox2Duenio";
            textBox2Duenio.Size = new Size(282, 23);
            textBox2Duenio.TabIndex = 15;
            textBox2Duenio.TextChanged += textBox2Duenio_TextChanged;
            // 
            // textBox3Anio
            // 
            textBox3Anio.Location = new Point(146, 140);
            textBox3Anio.Name = "textBox3Anio";
            textBox3Anio.Size = new Size(282, 23);
            textBox3Anio.TabIndex = 16;
            textBox3Anio.TextChanged += textBox3Anio_TextChanged;
            // 
            // textBox4KmActual
            // 
            textBox4KmActual.Location = new Point(146, 184);
            textBox4KmActual.Name = "textBox4KmActual";
            textBox4KmActual.Size = new Size(282, 23);
            textBox4KmActual.TabIndex = 17;
            textBox4KmActual.TextChanged += textBox4KmActual_TextChanged;
            // 
            // textBoxDatos
            // 
            textBoxDatos.Enabled = false;
            textBoxDatos.Location = new Point(19, 316);
            textBoxDatos.Multiline = true;
            textBoxDatos.Name = "textBoxDatos";
            textBoxDatos.Size = new Size(409, 231);
            textBoxDatos.TabIndex = 22;
            // 
            // comboBox1Modelo
            // 
            comboBox1Modelo.FormattingEnabled = true;
            comboBox1Modelo.Items.AddRange(new object[] { "Tesla Modelo - S", "Tesla Modelo - X", "Tesla Modelo - Cybertruck", "EspaceX - Starship", "EspaceX - Falcon 9" });
            comboBox1Modelo.Location = new Point(146, 12);
            comboBox1Modelo.Name = "comboBox1Modelo";
            comboBox1Modelo.Size = new Size(282, 23);
            comboBox1Modelo.TabIndex = 23;
            comboBox1Modelo.SelectedIndexChanged += comboBox1Modelo_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 20);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 25;
            label13.Text = "MODELO";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1NId, Column1Modelo, Column2Anio, Column3Duenio, Column4, Column5Color });
            dataGridView1.Location = new Point(456, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(653, 593);
            dataGridView1.TabIndex = 26;
            // 
            // Column1NId
            // 
            Column1NId.HeaderText = "N_ID";
            Column1NId.Name = "Column1NId";
            Column1NId.ReadOnly = true;
            // 
            // Column1Modelo
            // 
            Column1Modelo.HeaderText = "Modelo";
            Column1Modelo.Name = "Column1Modelo";
            Column1Modelo.ReadOnly = true;
            // 
            // Column2Anio
            // 
            Column2Anio.HeaderText = "Año";
            Column2Anio.Name = "Column2Anio";
            Column2Anio.ReadOnly = true;
            // 
            // Column3Duenio
            // 
            Column3Duenio.HeaderText = "Dueño-Empresa";
            Column3Duenio.Name = "Column3Duenio";
            Column3Duenio.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Km-Hs-Actual";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5Color
            // 
            Column5Color.HeaderText = "Color";
            Column5Color.Name = "Column5Color";
            Column5Color.ReadOnly = true;
            // 
            // label12NId
            // 
            label12NId.AutoSize = true;
            label12NId.Location = new Point(146, 80);
            label12NId.Name = "label12NId";
            label12NId.Size = new Size(10, 15);
            label12NId.TabIndex = 27;
            label12NId.Text = ".";
            // 
            // label14Duenio
            // 
            label14Duenio.AutoSize = true;
            label14Duenio.Location = new Point(146, 122);
            label14Duenio.Name = "label14Duenio";
            label14Duenio.Size = new Size(10, 15);
            label14Duenio.TabIndex = 28;
            label14Duenio.Text = ".";
            // 
            // label15Anio
            // 
            label15Anio.AutoSize = true;
            label15Anio.Location = new Point(146, 166);
            label15Anio.Name = "label15Anio";
            label15Anio.Size = new Size(10, 15);
            label15Anio.TabIndex = 29;
            label15Anio.Text = ".";
            // 
            // label16kmActual
            // 
            label16kmActual.AutoSize = true;
            label16kmActual.Location = new Point(146, 210);
            label16kmActual.Name = "label16kmActual";
            label16kmActual.Size = new Size(10, 15);
            label16kmActual.TabIndex = 30;
            label16kmActual.Text = ".";
            // 
            // label17Color
            // 
            label17Color.AutoSize = true;
            label17Color.Location = new Point(146, 254);
            label17Color.Name = "label17Color";
            label17Color.Size = new Size(10, 15);
            label17Color.TabIndex = 31;
            label17Color.Text = ".";
            // 
            // comboBox2Color
            // 
            comboBox2Color.FormattingEnabled = true;
            comboBox2Color.Items.AddRange(new object[] { "Negro", "Blanco", "Gris", "Rojo", "Azul", "Verde", "Amarillo", "Naranja", "Marrón" });
            comboBox2Color.Location = new Point(146, 228);
            comboBox2Color.Name = "comboBox2Color";
            comboBox2Color.Size = new Size(282, 23);
            comboBox2Color.TabIndex = 32;
            comboBox2Color.SelectedIndexChanged += comboBox2Color_SelectedIndexChanged;
            // 
            // label12Modelo
            // 
            label12Modelo.AutoSize = true;
            label12Modelo.Location = new Point(146, 36);
            label12Modelo.Name = "label12Modelo";
            label12Modelo.Size = new Size(10, 15);
            label12Modelo.TabIndex = 33;
            label12Modelo.Text = ".";
            // 
            // button2FinAlta
            // 
            button2FinAlta.Location = new Point(19, 582);
            button2FinAlta.Name = "button2FinAlta";
            button2FinAlta.Size = new Size(409, 23);
            button2FinAlta.TabIndex = 34;
            button2FinAlta.Text = "FINALIZAR ALTA";
            button2FinAlta.UseVisualStyleBackColor = true;
            button2FinAlta.Click += button2FinAlta_Click;
            // 
            // button1ModifDato
            // 
            button1ModifDato.Location = new Point(18, 553);
            button1ModifDato.Name = "button1ModifDato";
            button1ModifDato.Size = new Size(409, 23);
            button1ModifDato.TabIndex = 35;
            button1ModifDato.Text = "MODIFICAR DATOS PRECARGADOS";
            button1ModifDato.UseVisualStyleBackColor = true;
            button1ModifDato.Click += button1_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(1115, 567);
            button1.Name = "button1";
            button1.Size = new Size(41, 38);
            button1.TabIndex = 36;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 618);
            Controls.Add(button1);
            Controls.Add(button1ModifDato);
            Controls.Add(button2FinAlta);
            Controls.Add(label12Modelo);
            Controls.Add(comboBox2Color);
            Controls.Add(label17Color);
            Controls.Add(label16kmActual);
            Controls.Add(label15Anio);
            Controls.Add(label14Duenio);
            Controls.Add(label12NId);
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(comboBox1Modelo);
            Controls.Add(textBoxDatos);
            Controls.Add(textBox4KmActual);
            Controls.Add(textBox3Anio);
            Controls.Add(textBox2Duenio);
            Controls.Add(textBox1NId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1ValidDatos);
            Name = "Form2";
            Text = "ALTAS TESLAS - SPACEX";
            Click += Form2_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1ValidDatos;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1NId;
        private TextBox textBox2Duenio;
        private TextBox textBox3Anio;
        private TextBox textBox4KmActual;
        private TextBox textBoxDatos;
        private ComboBox comboBox1Modelo;
        private Label label13;
        private DataGridView dataGridView1;
        private Label label12NId;
        private Label label14Duenio;
        private Label label15Anio;
        private Label label16kmActual;
        private Label label17Color;
        private ComboBox comboBox2Color;
        private Label label12Modelo;
        private Button button2FinAlta;
        private Button button1ModifDato;
        private DataGridViewTextBoxColumn Column1NId;
        private DataGridViewTextBoxColumn Column1Modelo;
        private DataGridViewTextBoxColumn Column2Anio;
        private DataGridViewTextBoxColumn Column3Duenio;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5Color;
        private Button button1;
    }
}