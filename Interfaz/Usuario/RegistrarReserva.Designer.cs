namespace Interfaz.Usuario
{
    partial class RegistrarReserva
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
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listBox3 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(403, 54);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(385, 84);
            listBox2.TabIndex = 2;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 23);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Choferes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 194);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Vehiculos";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(403, 222);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(385, 84);
            listBox3.TabIndex = 6;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(492, 19);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(492, 190);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(187, 279);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 9;
            button4.Text = "Registrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 85);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 11;
            label5.Text = "ChoferId :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 131);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 12;
            label6.Text = "VehiculoId :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 175);
            label7.Name = "label7";
            label7.Size = new Size(121, 20);
            label7.TabIndex = 13;
            label7.Text = "Dias de Reserva :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 225);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 14;
            label8.Text = "Seguro : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(221, 335);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 15;
            label9.Text = "Seña :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(187, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(187, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(187, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 19;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(187, 358);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 21;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(71, 241);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Contra todo $35000", "Choque Frotal $30000", "Basico $20000" });
            comboBox1.Location = new Point(187, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 24;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(12, 9);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Volver";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 85);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 26;
            label1.Text = "Opcional";
            // 
            // RegistrarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Name = "RegistrarReserva";
            Text = "RegistrarReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private ListBox listBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label11;
        private ComboBox comboBox1;
        private Button button5;
        private Label label1;
    }
}