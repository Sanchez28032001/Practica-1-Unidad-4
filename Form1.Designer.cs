namespace Practica_1__Unidad_4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            Sumar = new Button();
            Restar = new Button();
            Multiplicar = new Button();
            Dividir = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 79);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 110);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Numero 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 232);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Resultados:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(107, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // Sumar
            // 
            Sumar.Location = new Point(281, 58);
            Sumar.Name = "Sumar";
            Sumar.Size = new Size(75, 23);
            Sumar.TabIndex = 7;
            Sumar.Text = "Sumar";
            Sumar.UseVisualStyleBackColor = true;
            Sumar.Click += Sumar_Click;
            // 
            // Restar
            // 
            Restar.Location = new Point(281, 87);
            Restar.Name = "Restar";
            Restar.Size = new Size(75, 23);
            Restar.TabIndex = 8;
            Restar.Text = "Restar";
            Restar.UseVisualStyleBackColor = true;
            Restar.Click += Restar_Click;
            // 
            // Multiplicar
            // 
            Multiplicar.Location = new Point(281, 116);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(75, 23);
            Multiplicar.TabIndex = 9;
            Multiplicar.Text = "Multiplicar";
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += Multiplicar_Click;
            // 
            // Dividir
            // 
            Dividir.Location = new Point(281, 145);
            Dividir.Name = "Dividir";
            Dividir.Size = new Size(75, 23);
            Dividir.TabIndex = 10;
            Dividir.Text = "Dividir";
            Dividir.UseVisualStyleBackColor = true;
            Dividir.Click += Dividir_Click;
            // 
            // Limpiar
            // 
            Limpiar.Location = new Point(87, 174);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 11;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = true;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 299);
            Controls.Add(Limpiar);
            Controls.Add(Dividir);
            Controls.Add(Multiplicar);
            Controls.Add(Restar);
            Controls.Add(Sumar);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Propiedades y funciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button Sumar;
        private Button Restar;
        private Button Multiplicar;
        private Button Dividir;
        private Button Limpiar;
    }
}