namespace ProyectForms.Formularios
{
    partial class Form3
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
            dataGridView2 = new DataGridView();
            Column1NId = new DataGridViewTextBoxColumn();
            Column1Modelo = new DataGridViewTextBoxColumn();
            Column2Anio = new DataGridViewTextBoxColumn();
            Column3Duenio = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5Color = new DataGridViewTextBoxColumn();
            Column1Ver = new DataGridViewButtonColumn();
            textBoxForm3 = new TextBox();
            radioButtonEliminar = new RadioButton();
            label1 = new Label();
            radioButtonEscanear = new RadioButton();
            groupBoxOpciones = new GroupBox();
            radioButtonMovimiento = new RadioButton();
            radioButtonCargar = new RadioButton();
            buttonEjecutar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBoxOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1NId, Column1Modelo, Column2Anio, Column3Duenio, Column4, Column5Color, Column1Ver });
            dataGridView2.Location = new Point(354, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(752, 436);
            dataGridView2.TabIndex = 27;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
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
            // Column1Ver
            // 
            Column1Ver.HeaderText = "Ver";
            Column1Ver.Name = "Column1Ver";
            Column1Ver.ReadOnly = true;
            Column1Ver.Text = "Seleccionar";
            Column1Ver.UseColumnTextForButtonValue = true;
            // 
            // textBoxForm3
            // 
            textBoxForm3.Location = new Point(12, 45);
            textBoxForm3.Multiline = true;
            textBoxForm3.Name = "textBoxForm3";
            textBoxForm3.Size = new Size(317, 304);
            textBoxForm3.TabIndex = 28;
            // 
            // radioButtonEliminar
            // 
            radioButtonEliminar.AutoSize = true;
            radioButtonEliminar.Location = new Point(6, 22);
            radioButtonEliminar.Name = "radioButtonEliminar";
            radioButtonEliminar.Size = new Size(78, 19);
            radioButtonEliminar.TabIndex = 29;
            radioButtonEliminar.TabStop = true;
            radioButtonEliminar.Text = "ELIMINAR";
            radioButtonEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 30;
            label1.Text = "--- GESTION VEHICULOS ---";
            // 
            // radioButtonEscanear
            // 
            radioButtonEscanear.AutoSize = true;
            radioButtonEscanear.Location = new Point(6, 47);
            radioButtonEscanear.Name = "radioButtonEscanear";
            radioButtonEscanear.Size = new Size(83, 19);
            radioButtonEscanear.TabIndex = 31;
            radioButtonEscanear.TabStop = true;
            radioButtonEscanear.Text = "ESCANEAR";
            radioButtonEscanear.UseVisualStyleBackColor = true;
            // 
            // groupBoxOpciones
            // 
            groupBoxOpciones.Controls.Add(radioButtonMovimiento);
            groupBoxOpciones.Controls.Add(radioButtonCargar);
            groupBoxOpciones.Controls.Add(radioButtonEliminar);
            groupBoxOpciones.Controls.Add(radioButtonEscanear);
            groupBoxOpciones.Location = new Point(12, 355);
            groupBoxOpciones.Name = "groupBoxOpciones";
            groupBoxOpciones.Size = new Size(317, 126);
            groupBoxOpciones.TabIndex = 32;
            groupBoxOpciones.TabStop = false;
            groupBoxOpciones.Text = "Seleccione una Opcion";
            // 
            // radioButtonMovimiento
            // 
            radioButtonMovimiento.AutoSize = true;
            radioButtonMovimiento.Location = new Point(6, 72);
            radioButtonMovimiento.Name = "radioButtonMovimiento";
            radioButtonMovimiento.Size = new Size(157, 19);
            radioButtonMovimiento.TabIndex = 35;
            radioButtonMovimiento.TabStop = true;
            radioButtonMovimiento.Text = "MOVIMIENTO VEHICULO";
            radioButtonMovimiento.UseVisualStyleBackColor = true;
            // 
            // radioButtonCargar
            // 
            radioButtonCargar.AutoSize = true;
            radioButtonCargar.Location = new Point(6, 97);
            radioButtonCargar.Name = "radioButtonCargar";
            radioButtonCargar.Size = new Size(206, 19);
            radioButtonCargar.TabIndex = 34;
            radioButtonCargar.TabStop = true;
            radioButtonCargar.Text = "CARGAR BATERIA / COMBUSTIBLE";
            radioButtonCargar.UseVisualStyleBackColor = true;
            // 
            // buttonEjecutar
            // 
            buttonEjecutar.Location = new Point(107, 491);
            buttonEjecutar.Name = "buttonEjecutar";
            buttonEjecutar.Size = new Size(117, 31);
            buttonEjecutar.TabIndex = 33;
            buttonEjecutar.Text = "Ejecutar Oparacion";
            buttonEjecutar.UseVisualStyleBackColor = true;
            buttonEjecutar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1031, 499);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 34;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 534);
            Controls.Add(button1);
            Controls.Add(buttonEjecutar);
            Controls.Add(groupBoxOpciones);
            Controls.Add(label1);
            Controls.Add(textBoxForm3);
            Controls.Add(dataGridView2);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBoxOpciones.ResumeLayout(false);
            groupBoxOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private TextBox textBoxForm3;
        private DataGridViewTextBoxColumn Column1NId;
        private DataGridViewTextBoxColumn Column1Modelo;
        private DataGridViewTextBoxColumn Column2Anio;
        private DataGridViewTextBoxColumn Column3Duenio;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5Color;
        private DataGridViewButtonColumn Column1Ver;
        private RadioButton radioButtonEliminar;
        private Label label1;
        private RadioButton radioButtonEscanear;
        private GroupBox groupBoxOpciones;
        private Button buttonEjecutar;
        private RadioButton radioButtonCargar;
        private RadioButton radioButtonMovimiento;
        private Button button1;
    }
}