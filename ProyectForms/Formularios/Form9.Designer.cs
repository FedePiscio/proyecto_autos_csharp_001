namespace ProyectForms.Formularios
{
    partial class Form9
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
            textBoxTeslaViejo = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxTeslaViejo
            // 
            textBoxTeslaViejo.Location = new Point(12, 40);
            textBoxTeslaViejo.Multiline = true;
            textBoxTeslaViejo.Name = "textBoxTeslaViejo";
            textBoxTeslaViejo.Size = new Size(679, 285);
            textBoxTeslaViejo.TabIndex = 0;
            textBoxTeslaViejo.TextChanged += textBoxTeslaViejo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(267, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 1;
            label1.Text = "TESLAS MAS VIEJOS";
            // 
            // button1
            // 
            button1.Location = new Point(616, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 384);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxTeslaViejo);
            Name = "Form9";
            Text = "Form9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTeslaViejo;
        private Label label1;
        private Button button1;
    }
}