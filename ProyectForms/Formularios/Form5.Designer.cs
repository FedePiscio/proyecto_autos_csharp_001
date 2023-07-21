namespace ProyectForms.Formularios
{
    partial class Form5
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
            textBoxEscaner = new TextBox();
            label1 = new Label();
            textBoxEscanerService = new TextBox();
            buttonRealizarServ = new Button();
            buttonFinalizar = new Button();
            label2 = new Label();
            label3 = new Label();
            buttoneEscanear = new Button();
            label4 = new Label();
            textBoxKmHsServ = new TextBox();
            labelKmHsServ = new Label();
            SuspendLayout();
            // 
            // textBoxEscaner
            // 
            textBoxEscaner.Location = new Point(12, 133);
            textBoxEscaner.Multiline = true;
            textBoxEscaner.Name = "textBoxEscaner";
            textBoxEscaner.Size = new Size(409, 505);
            textBoxEscaner.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 1;
            label1.Text = "** ESCANER **";
            // 
            // textBoxEscanerService
            // 
            textBoxEscanerService.Location = new Point(582, 43);
            textBoxEscanerService.Multiline = true;
            textBoxEscanerService.Name = "textBoxEscanerService";
            textBoxEscanerService.Size = new Size(409, 547);
            textBoxEscanerService.TabIndex = 2;
            // 
            // buttonRealizarServ
            // 
            buttonRealizarServ.Location = new Point(427, 248);
            buttonRealizarServ.Name = "buttonRealizarServ";
            buttonRealizarServ.Size = new Size(149, 65);
            buttonRealizarServ.TabIndex = 3;
            buttonRealizarServ.Text = "Realizar Servicios Requeridos";
            buttonRealizarServ.UseVisualStyleBackColor = true;
            buttonRealizarServ.Click += button1_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(703, 615);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(209, 23);
            buttonFinalizar.TabIndex = 4;
            buttonFinalizar.Text = "FINALIZAR";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += buttonFinalizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(124, 13);
            label2.Name = "label2";
            label2.Size = new Size(201, 21);
            label2.TabIndex = 5;
            label2.Text = "Situacion Antes del Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(703, 13);
            label3.Name = "label3";
            label3.Size = new Size(221, 21);
            label3.TabIndex = 6;
            label3.Text = "Situacion Despues del Servicio";
            // 
            // buttoneEscanear
            // 
            buttoneEscanear.Location = new Point(124, 104);
            buttoneEscanear.Name = "buttoneEscanear";
            buttoneEscanear.Size = new Size(192, 23);
            buttoneEscanear.TabIndex = 7;
            buttoneEscanear.Text = "ESCANEAR";
            buttoneEscanear.UseVisualStyleBackColor = true;
            buttoneEscanear.Click += buttoneEscanear_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 51);
            label4.Name = "label4";
            label4.Size = new Size(204, 15);
            label4.TabIndex = 8;
            label4.Text = "Km-Hs-del Ultimo Servicio Realizado:";
            // 
            // textBoxKmHsServ
            // 
            textBoxKmHsServ.Location = new Point(244, 43);
            textBoxKmHsServ.Name = "textBoxKmHsServ";
            textBoxKmHsServ.Size = new Size(177, 23);
            textBoxKmHsServ.TabIndex = 9;
            textBoxKmHsServ.TextChanged += textBox1_TextChanged;
            // 
            // labelKmHsServ
            // 
            labelKmHsServ.AutoSize = true;
            labelKmHsServ.Location = new Point(244, 69);
            labelKmHsServ.Name = "labelKmHsServ";
            labelKmHsServ.Size = new Size(10, 15);
            labelKmHsServ.TabIndex = 10;
            labelKmHsServ.Text = ".";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 650);
            Controls.Add(labelKmHsServ);
            Controls.Add(textBoxKmHsServ);
            Controls.Add(label4);
            Controls.Add(buttoneEscanear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonRealizarServ);
            Controls.Add(textBoxEscanerService);
            Controls.Add(label1);
            Controls.Add(textBoxEscaner);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEscaner;
        private Label label1;
        private TextBox textBoxEscanerService;
        private Button buttonRealizarServ;
        private Button buttonFinalizar;
        private Label label2;
        private Label label3;
        private Button buttoneEscanear;
        private Label label4;
        private TextBox textBoxKmHsServ;
        private Label labelKmHsServ;
    }
}