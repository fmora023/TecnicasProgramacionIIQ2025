﻿namespace WFViewExample
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // LoginBtn
            // 
            button1.Location = new Point(55, 48);
            button1.Name = "LoginBtn";
            button1.Size = new Size(172, 94);
            button1.TabIndex = 0;
            button1.Text = "CalculatorFrm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(55, 168);
            button2.Name = "button2";
            button2.Size = new Size(172, 94);
            button2.TabIndex = 1;
            button2.Text = "Examples";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 651);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
