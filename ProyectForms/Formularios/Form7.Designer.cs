namespace ProyectForms.Formularios
{
    partial class Form7
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
            label1 = new Label();
            textBoxCargas = new TextBox();
            buttonFinaCarga = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 0;
            label1.Text = "RECARGA BATERIA / COMBUSTIBLE";
            // 
            // textBoxCargas
            // 
            textBoxCargas.Location = new Point(21, 46);
            textBoxCargas.Multiline = true;
            textBoxCargas.Name = "textBoxCargas";
            textBoxCargas.Size = new Size(398, 234);
            textBoxCargas.TabIndex = 1;
            // 
            // buttonFinaCarga
            // 
            buttonFinaCarga.Location = new Point(271, 301);
            buttonFinaCarga.Name = "buttonFinaCarga";
            buttonFinaCarga.Size = new Size(148, 23);
            buttonFinaCarga.TabIndex = 2;
            buttonFinaCarga.Text = "FINALIZAR";
            buttonFinaCarga.UseVisualStyleBackColor = true;
            buttonFinaCarga.Click += buttonFinaCarga_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 301);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 3;
            button1.Text = "RECARGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 336);
            Controls.Add(button1);
            Controls.Add(buttonFinaCarga);
            Controls.Add(textBoxCargas);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCargas;
        private Button buttonFinaCarga;
        private Button button1;
    }
}