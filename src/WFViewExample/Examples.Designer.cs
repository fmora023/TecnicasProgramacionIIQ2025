namespace WFViewExample
{
    partial class Examples
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            lbl_ResultEx1 = new Label();
            label1 = new Label();
            txtElemetosEjercicio1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbl_ResultEx1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtElemetosEjercicio1);
            groupBox1.Location = new Point(26, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 476);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // LoginBtn
            // 
            button1.Location = new Point(274, 206);
            button1.Name = "LoginBtn";
            button1.Size = new Size(127, 75);
            button1.TabIndex = 2;
            button1.Text = "Ejercicio #1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_ResultEx1
            // 
            lbl_ResultEx1.AutoSize = true;
            lbl_ResultEx1.Location = new Point(26, 206);
            lbl_ResultEx1.Name = "lbl_ResultEx1";
            lbl_ResultEx1.Size = new Size(95, 20);
            lbl_ResultEx1.TabIndex = 3;
            lbl_ResultEx1.Text = "lbl_ResultEx1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 9);
            label1.Name = "label1";
            label1.Size = new Size(342, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite los elementos a sumar separados por coma";
            // 
            // txtElemetosEjercicio1
            // 
            txtElemetosEjercicio1.Location = new Point(26, 96);
            txtElemetosEjercicio1.Name = "txtElemetosEjercicio1";
            txtElemetosEjercicio1.Size = new Size(375, 27);
            txtElemetosEjercicio1.TabIndex = 0;
            // 
            // Examples
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 610);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Examples";
            Text = "Examples";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_ResultEx1;
        private Button button1;
        private Label label1;
        private TextBox txtElemetosEjercicio1;
    }
}