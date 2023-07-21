namespace ProyectForms.Formularios
{
    partial class Form4
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
            textBox1 = new TextBox();
            label1 = new Label();
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 50);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 268);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 1;
            label1.Text = "*** ¡¡¡ ATENCION !!!***";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(24, 359);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "ELIMINAR";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(327, 359);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "CANCELAR";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 413);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonEliminar;
        private Button buttonCancelar;
    }
}