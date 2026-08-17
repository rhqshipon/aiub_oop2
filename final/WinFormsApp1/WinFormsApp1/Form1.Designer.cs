namespace WinFormsApp1
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
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtNumber1
            // 
            txtNumber1.Location = new Point(20, 38);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(118, 27);
            txtNumber1.TabIndex = 0;

            // 
            // txtNumber2
            // 
            txtNumber2.Location = new Point(156, 38);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(116, 27);
            txtNumber2.TabIndex = 1;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(20, 118);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(38, 29);
            btnPlus.TabIndex = 2;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click_1;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(93, 118);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(34, 29);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // button3
            // 
            button3.Location = new Point(165, 118);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 4;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(233, 118);
            button4.Name = "button4";
            button4.Size = new Size(39, 29);
            button4.TabIndex = 5;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 173);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnPlus;
        private Button btnMinus;
        private Button button3;
        private Button button4;
    }
}
