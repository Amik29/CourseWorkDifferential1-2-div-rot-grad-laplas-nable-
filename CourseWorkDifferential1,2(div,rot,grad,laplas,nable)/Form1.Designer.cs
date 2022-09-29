namespace CourseWorkDifferential1_2_div_rot_grad_laplas_nable_
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Function1 = new System.Windows.Forms.RadioButton();
            this.Function2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(78, 51);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(153, 27);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(291, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(153, 27);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // Function1
            // 
            this.Function1.AutoSize = true;
            this.Function1.Location = new System.Drawing.Point(78, 104);
            this.Function1.Name = "Function1";
            this.Function1.Size = new System.Drawing.Size(82, 19);
            this.Function1.TabIndex = 3;
            this.Function1.TabStop = true;
            this.Function1.Text = "Функция 1";
            this.Function1.UseVisualStyleBackColor = true;
            // 
            // Function2
            // 
            this.Function2.AutoSize = true;
            this.Function2.Location = new System.Drawing.Point(291, 104);
            this.Function2.Name = "Function2";
            this.Function2.Size = new System.Drawing.Size(82, 19);
            this.Function2.TabIndex = 4;
            this.Function2.TabStop = true;
            this.Function2.Text = "Функция 2";
            this.Function2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.Function2);
            this.Controls.Add(this.Function1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RadioButton Function1;
        private RadioButton Function2;
    }
}