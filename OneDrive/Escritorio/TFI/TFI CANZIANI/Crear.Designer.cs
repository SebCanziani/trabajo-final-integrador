﻿namespace TFI_CANZIANI
{
    partial class Crear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear));
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(149, 466);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 39);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 361);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(313, 39);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 39);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 39);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 39);
            textBox1.TabIndex = 19;
            // 
            // label5
            // 
            label5.Location = new Point(149, 227);
            label5.Name = "label5";
            label5.Size = new Size(190, 37);
            label5.TabIndex = 18;
            label5.Text = "Titulo:";
            // 
            // label4
            // 
            label4.Location = new Point(149, 426);
            label4.Name = "label4";
            label4.Size = new Size(190, 37);
            label4.TabIndex = 17;
            label4.Text = "Categoria:";
            // 
            // label3
            // 
            label3.Location = new Point(149, 321);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 16;
            label3.Text = "Precio:";
            // 
            // label2
            // 
            label2.Location = new Point(149, 26);
            label2.Name = "label2";
            label2.Size = new Size(190, 37);
            label2.TabIndex = 15;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.Location = new Point(149, 126);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 14;
            label1.Text = "Descripcion:";
            // 
            // button2
            // 
            button2.Location = new Point(128, 571);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 13;
            button2.Text = "Aceptar ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(328, 571);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Crear
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(608, 674);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Crear";
            Text = "Nuevo Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}