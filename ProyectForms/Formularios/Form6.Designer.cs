namespace ProyectForms.Formularios
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
            textBoxInicio = new TextBox();
            label1 = new Label();
            textBoxFinal = new TextBox();
            label2 = new Label();
            textBoxKmHsRecorrer = new TextBox();
            buttonRecorrer = new Button();
            labelKmHsRecorrer = new Label();
            buttonFinRecorrido = new Button();
            SuspendLayout();
            // 
            // textBoxInicio
            // 
            textBoxInicio.Location = new Point(12, 37);
            textBoxInicio.Multiline = true;
            textBoxInicio.Name = "textBoxInicio";
            textBoxInicio.Size = new Size(283, 179);
            textBoxInicio.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 1;
            label1.Text = "MOVIMIENTO";
            // 
            // textBoxFinal
            // 
            textBoxFinal.Location = new Point(12, 302);
            textBoxFinal.Multiline = true;
            textBoxFinal.Name = "textBoxFinal";
            textBoxFinal.Size = new Size(283, 210);
            textBoxFinal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 230);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "KM-HS a recorrer:";
            // 
            // textBoxKmHsRecorrer
            // 
            textBoxKmHsRecorrer.Location = new Point(134, 222);
            textBoxKmHsRecorrer.Name = "textBoxKmHsRecorrer";
            textBoxKmHsRecorrer.Size = new Size(161, 23);
            textBoxKmHsRecorrer.TabIndex = 4;
            textBoxKmHsRecorrer.TextChanged += textBoxKmHsRecorrer_TextChanged;
            // 
            // buttonRecorrer
            // 
            buttonRecorrer.Location = new Point(94, 273);
            buttonRecorrer.Name = "buttonRecorrer";
            buttonRecorrer.Size = new Size(129, 23);
            buttonRecorrer.TabIndex = 5;
            buttonRecorrer.Text = "RECORRER";
            buttonRecorrer.UseVisualStyleBackColor = true;
            buttonRecorrer.Click += button1_Click;
            // 
            // labelKmHsRecorrer
            // 
            labelKmHsRecorrer.AutoSize = true;
            labelKmHsRecorrer.Location = new Point(12, 245);
            labelKmHsRecorrer.Name = "labelKmHsRecorrer";
            labelKmHsRecorrer.Size = new Size(10, 15);
            labelKmHsRecorrer.TabIndex = 6;
            labelKmHsRecorrer.Text = ".";
            // 
            // buttonFinRecorrido
            // 
            buttonFinRecorrido.Location = new Point(94, 518);
            buttonFinRecorrido.Name = "buttonFinRecorrido";
            buttonFinRecorrido.Size = new Size(129, 23);
            buttonFinRecorrido.TabIndex = 7;
            buttonFinRecorrido.Text = "FINALIZAR RECORRIDO";
            buttonFinRecorrido.UseVisualStyleBackColor = true;
            buttonFinRecorrido.Click += buttonFinRecorrido_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 553);
            Controls.Add(buttonFinRecorrido);
            Controls.Add(labelKmHsRecorrer);
            Controls.Add(buttonRecorrer);
            Controls.Add(textBoxKmHsRecorrer);
            Controls.Add(label2);
            Controls.Add(textBoxFinal);
            Controls.Add(label1);
            Controls.Add(textBoxInicio);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInicio;
        private Label label1;
        private TextBox textBoxFinal;
        private Label label2;
        private TextBox textBoxKmHsRecorrer;
        private Button buttonRecorrer;
        private Label labelKmHsRecorrer;
        private Button buttonFinRecorrido;
    }
}