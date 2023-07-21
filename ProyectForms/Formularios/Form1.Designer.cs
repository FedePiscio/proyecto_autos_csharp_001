namespace ProyectForms
{
    partial class Form1
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
            buttonaAltas = new Button();
            button1 = new Button();
            button2 = new Button();
            buttonTeslaViejo = new Button();
            SuspendLayout();
            // 
            // buttonaAltas
            // 
            buttonaAltas.Location = new Point(21, 12);
            buttonaAltas.Name = "buttonaAltas";
            buttonaAltas.Size = new Size(367, 23);
            buttonaAltas.TabIndex = 0;
            buttonaAltas.Text = "ALTAS";
            buttonaAltas.UseVisualStyleBackColor = true;
            buttonaAltas.Click += buttonaAltas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 41);
            button1.Name = "button1";
            button1.Size = new Size(367, 23);
            button1.TabIndex = 1;
            button1.Text = "GESTION VEHICULOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 70);
            button2.Name = "button2";
            button2.Size = new Size(367, 23);
            button2.TabIndex = 2;
            button2.Text = "LISTA DE INFORMACION";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonTeslaViejo
            // 
            buttonTeslaViejo.Location = new Point(21, 99);
            buttonTeslaViejo.Name = "buttonTeslaViejo";
            buttonTeslaViejo.Size = new Size(367, 23);
            buttonTeslaViejo.TabIndex = 3;
            buttonTeslaViejo.Text = "TESLA MAS VIEJO";
            buttonTeslaViejo.UseVisualStyleBackColor = true;
            buttonTeslaViejo.Click += buttonTeslaViejo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 148);
            Controls.Add(buttonTeslaViejo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonaAltas);
            Name = "Form1";
            Text = "MENU PRINCIPAL - SOFTWARE TESLA / SPACEX";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonaAltas;
        private Button button1;
        private Button button2;
        private Button buttonTeslaViejo;
    }
}