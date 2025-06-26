namespace WFViewExample
{
    partial class CalculatorFrm
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
            txt_Input1 = new TextBox();
            txt_Input2 = new TextBox();
            txt_Result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_Sum = new Button();
            btn_Mult = new Button();
            SuspendLayout();
            // 
            // txt_Input1
            // 
            txt_Input1.Location = new Point(412, 119);
            txt_Input1.Name = "txt_Input1";
            txt_Input1.Size = new Size(173, 27);
            txt_Input1.TabIndex = 0;
            // 
            // txt_Input2
            // 
            txt_Input2.Location = new Point(412, 202);
            txt_Input2.Name = "txt_Input2";
            txt_Input2.Size = new Size(173, 27);
            txt_Input2.TabIndex = 1;
            // 
            // txt_Result
            // 
            txt_Result.Enabled = false;
            txt_Result.Location = new Point(412, 299);
            txt_Result.Name = "txt_Result";
            txt_Result.Size = new Size(173, 27);
            txt_Result.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 122);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 205);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 4;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 299);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Resultado: ";
            // 
            // btn_Sum
            // 
            btn_Sum.Location = new Point(143, 470);
            btn_Sum.Name = "btn_Sum";
            btn_Sum.Size = new Size(181, 55);
            btn_Sum.TabIndex = 6;
            btn_Sum.Text = "Sum";
            btn_Sum.UseVisualStyleBackColor = true;
            btn_Sum.Click += btn_Sum_Click;
            // 
            // btn_Mult
            // 
            btn_Mult.Location = new Point(437, 470);
            btn_Mult.Name = "btn_Mult";
            btn_Mult.Size = new Size(148, 55);
            btn_Mult.TabIndex = 7;
            btn_Mult.Text = "Mult";
            btn_Mult.UseVisualStyleBackColor = true;
            // 
            // CalculatorFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 625);
            Controls.Add(btn_Mult);
            Controls.Add(btn_Sum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Result);
            Controls.Add(txt_Input2);
            Controls.Add(txt_Input1);
            Name = "CalculatorFrm";
            Text = "CalculatorFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Input1;
        private TextBox txt_Input2;
        private TextBox txt_Result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_Sum;
        private Button btn_Mult;
    }
}