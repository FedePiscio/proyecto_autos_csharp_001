namespace ProyectForms.Formularios
{
    partial class Form8
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
            dataGridView1 = new DataGridView();
            Col_indice = new DataGridViewTextBoxColumn();
            Column1NId = new DataGridViewTextBoxColumn();
            Column1Modelo = new DataGridViewTextBoxColumn();
            Column2Anio = new DataGridViewTextBoxColumn();
            Column3Duenio = new DataGridViewTextBoxColumn();
            Column5Color = new DataGridViewTextBoxColumn();
            Col_Ultimo_Serv = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Col_Sin_Serv = new DataGridViewTextBoxColumn();
            Column1Carga = new DataGridViewTextBoxColumn();
            Column1Autonomia = new DataGridViewTextBoxColumn();
            Column1Asientos = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Col_indice, Column1NId, Column1Modelo, Column2Anio, Column3Duenio, Column5Color, Col_Ultimo_Serv, Column4, Col_Sin_Serv, Column1Carga, Column1Autonomia, Column1Asientos });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1188, 435);
            dataGridView1.TabIndex = 0;
            // 
            // Col_indice
            // 
            Col_indice.HeaderText = "Indice";
            Col_indice.Name = "Col_indice";
            Col_indice.ReadOnly = true;
            Col_indice.Width = 50;
            // 
            // Column1NId
            // 
            Column1NId.HeaderText = "N_Id";
            Column1NId.Name = "Column1NId";
            Column1NId.ReadOnly = true;
            Column1NId.Width = 50;
            // 
            // Column1Modelo
            // 
            Column1Modelo.HeaderText = "Modelo";
            Column1Modelo.Name = "Column1Modelo";
            Column1Modelo.ReadOnly = true;
            Column1Modelo.Width = 150;
            // 
            // Column2Anio
            // 
            Column2Anio.HeaderText = "Año";
            Column2Anio.Name = "Column2Anio";
            Column2Anio.ReadOnly = true;
            Column2Anio.Width = 50;
            // 
            // Column3Duenio
            // 
            Column3Duenio.HeaderText = "Dueño-Empresa";
            Column3Duenio.Name = "Column3Duenio";
            Column3Duenio.ReadOnly = true;
            Column3Duenio.Width = 200;
            // 
            // Column5Color
            // 
            Column5Color.HeaderText = "Color";
            Column5Color.Name = "Column5Color";
            Column5Color.ReadOnly = true;
            Column5Color.Width = 50;
            // 
            // Col_Ultimo_Serv
            // 
            Col_Ultimo_Serv.HeaderText = "Km_Hs_Ult_Serv";
            Col_Ultimo_Serv.Name = "Col_Ultimo_Serv";
            Col_Ultimo_Serv.ReadOnly = true;
            Col_Ultimo_Serv.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Km-Hs Actual";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 80;
            // 
            // Col_Sin_Serv
            // 
            Col_Sin_Serv.HeaderText = "Km_Hs_Sin_Serv";
            Col_Sin_Serv.Name = "Col_Sin_Serv";
            Col_Sin_Serv.ReadOnly = true;
            Col_Sin_Serv.Width = 80;
            // 
            // Column1Carga
            // 
            Column1Carga.HeaderText = "%_Carga_Comb";
            Column1Carga.Name = "Column1Carga";
            Column1Carga.ReadOnly = true;
            Column1Carga.Width = 50;
            // 
            // Column1Autonomia
            // 
            Column1Autonomia.HeaderText = "Autonomia";
            Column1Autonomia.Name = "Column1Autonomia";
            Column1Autonomia.ReadOnly = true;
            Column1Autonomia.Width = 50;
            // 
            // Column1Asientos
            // 
            Column1Asientos.HeaderText = "Asientos";
            Column1Asientos.Name = "Column1Asientos";
            Column1Asientos.ReadOnly = true;
            Column1Asientos.Width = 50;
            // 
            // button1
            // 
            button1.Location = new Point(1125, 475);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 520);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn Col_indice;
        private DataGridViewTextBoxColumn Column1NId;
        private DataGridViewTextBoxColumn Column1Modelo;
        private DataGridViewTextBoxColumn Column2Anio;
        private DataGridViewTextBoxColumn Column3Duenio;
        private DataGridViewTextBoxColumn Column5Color;
        private DataGridViewTextBoxColumn Col_Ultimo_Serv;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Col_Sin_Serv;
        private DataGridViewTextBoxColumn Column1Carga;
        private DataGridViewTextBoxColumn Column1Autonomia;
        private DataGridViewTextBoxColumn Column1Asientos;
    }
}