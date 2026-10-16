namespace Interfaz.Admin
{
    partial class MenuAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(316, 107);
            button1.Name = "button1";
            button1.Size = new Size(89, 29);
            button1.TabIndex = 0;
            button1.Text = " Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 200);
            button2.Name = "button2";
            button2.Size = new Size(199, 29);
            button2.TabIndex = 1;
            button2.Text = "Registrar Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(316, 257);
            button3.Name = "button3";
            button3.Size = new Size(199, 29);
            button3.TabIndex = 2;
            button3.Text = "Ver Reportes";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(316, 59);
            button4.Name = "button4";
            button4.Size = new Size(199, 29);
            button4.TabIndex = 4;
            button4.Text = "Registrar Tipos Vehiculo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 5;
            label2.Text = "Vehiculo :";
            // 
            // button5
            // 
            button5.Location = new Point(426, 107);
            button5.Name = "button5";
            button5.Size = new Size(89, 29);
            button5.TabIndex = 6;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(368, 142);
            button6.Name = "button6";
            button6.Size = new Size(107, 29);
            button6.TabIndex = 7;
            button6.Text = "Modificar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MenuAdmin";
            Text = "MenuAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Label label2;
        private Button button5;
        private Button button6;
    }
}