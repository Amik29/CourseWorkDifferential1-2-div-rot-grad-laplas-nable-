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
            this.aPole = new System.Windows.Forms.Label();
            this.bPole = new System.Windows.Forms.Label();
            this.cPole = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.Label();
            this.betta = new System.Windows.Forms.Label();
            this.gamma = new System.Windows.Forms.Label();
            this.PictureEquation1 = new System.Windows.Forms.PictureBox();
            this.AInput = new System.Windows.Forms.TextBox();
            this.BInput = new System.Windows.Forms.TextBox();
            this.CInput = new System.Windows.Forms.TextBox();
            this.AlphaInput = new System.Windows.Forms.TextBox();
            this.BettaInput = new System.Windows.Forms.TextBox();
            this.GammaInput = new System.Windows.Forms.TextBox();
            this.GradInPoint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEquation1)).BeginInit();
            this.SuspendLayout();
            // 
            // aPole
            // 
            this.aPole.AutoSize = true;
            this.aPole.Location = new System.Drawing.Point(607, 26);
            this.aPole.Name = "aPole";
            this.aPole.Size = new System.Drawing.Size(16, 15);
            this.aPole.TabIndex = 5;
            this.aPole.Text = "a:";
            // 
            // bPole
            // 
            this.bPole.AutoSize = true;
            this.bPole.Location = new System.Drawing.Point(607, 54);
            this.bPole.Name = "bPole";
            this.bPole.Size = new System.Drawing.Size(17, 15);
            this.bPole.TabIndex = 6;
            this.bPole.Text = "b:";
            // 
            // cPole
            // 
            this.cPole.AutoSize = true;
            this.cPole.Location = new System.Drawing.Point(607, 80);
            this.cPole.Name = "cPole";
            this.cPole.Size = new System.Drawing.Size(16, 15);
            this.cPole.TabIndex = 7;
            this.cPole.Text = "c:";
            // 
            // alpha
            // 
            this.alpha.AutoSize = true;
            this.alpha.Location = new System.Drawing.Point(584, 108);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(39, 15);
            this.alpha.TabIndex = 8;
            this.alpha.Text = "alpha:";
            // 
            // betta
            // 
            this.betta.AutoSize = true;
            this.betta.Location = new System.Drawing.Point(586, 135);
            this.betta.Name = "betta";
            this.betta.Size = new System.Drawing.Size(37, 15);
            this.betta.TabIndex = 9;
            this.betta.Text = "betta:";
            // 
            // gamma
            // 
            this.gamma.AutoSize = true;
            this.gamma.Location = new System.Drawing.Point(573, 159);
            this.gamma.Name = "gamma";
            this.gamma.Size = new System.Drawing.Size(51, 15);
            this.gamma.TabIndex = 10;
            this.gamma.Text = "gamma:";
            // 
            // PictureEquation1
            // 
            this.PictureEquation1.Image = global::CourseWorkDifferential1_2_div_rot_grad_laplas_nable_.Properties.Resources.equation;
            this.PictureEquation1.ImageLocation = "";
            this.PictureEquation1.Location = new System.Drawing.Point(12, 12);
            this.PictureEquation1.Name = "PictureEquation1";
            this.PictureEquation1.Size = new System.Drawing.Size(143, 26);
            this.PictureEquation1.TabIndex = 11;
            this.PictureEquation1.TabStop = false;
            // 
            // AInput
            // 
            this.AInput.Location = new System.Drawing.Point(628, 26);
            this.AInput.Name = "AInput";
            this.AInput.Size = new System.Drawing.Size(84, 23);
            this.AInput.TabIndex = 13;
            // 
            // BInput
            // 
            this.BInput.Location = new System.Drawing.Point(628, 51);
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(84, 23);
            this.BInput.TabIndex = 14;
            // 
            // CInput
            // 
            this.CInput.Location = new System.Drawing.Point(628, 77);
            this.CInput.Name = "CInput";
            this.CInput.Size = new System.Drawing.Size(84, 23);
            this.CInput.TabIndex = 15;
            // 
            // AlphaInput
            // 
            this.AlphaInput.Location = new System.Drawing.Point(628, 104);
            this.AlphaInput.Name = "AlphaInput";
            this.AlphaInput.Size = new System.Drawing.Size(84, 23);
            this.AlphaInput.TabIndex = 16;
            // 
            // BettaInput
            // 
            this.BettaInput.Location = new System.Drawing.Point(628, 130);
            this.BettaInput.Name = "BettaInput";
            this.BettaInput.Size = new System.Drawing.Size(84, 23);
            this.BettaInput.TabIndex = 17;
            // 
            // GammaInput
            // 
            this.GammaInput.Location = new System.Drawing.Point(628, 156);
            this.GammaInput.Name = "GammaInput";
            this.GammaInput.Size = new System.Drawing.Size(84, 23);
            this.GammaInput.TabIndex = 18;
            // 
            // GradInPoint
            // 
            this.GradInPoint.Location = new System.Drawing.Point(12, 60);
            this.GradInPoint.Name = "GradInPoint";
            this.GradInPoint.Size = new System.Drawing.Size(143, 54);
            this.GradInPoint.TabIndex = 25;
            this.GradInPoint.Text = "Gradient";
            this.GradInPoint.UseVisualStyleBackColor = true;
            this.GradInPoint.Click += new System.EventHandler(this.GradInPoint_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(737, 472);
            this.Controls.Add(this.GradInPoint);
            this.Controls.Add(this.GammaInput);
            this.Controls.Add(this.BettaInput);
            this.Controls.Add(this.AlphaInput);
            this.Controls.Add(this.CInput);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.PictureEquation1);
            this.Controls.Add(this.gamma);
            this.Controls.Add(this.betta);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.cPole);
            this.Controls.Add(this.bPole);
            this.Controls.Add(this.aPole);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureEquation1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label aPole;
        private Label bPole;
        private Label cPole;
        private Label alpha;
        private Label betta;
        private Label gamma;
        private PictureBox PictureEquation1;
        private TextBox AInput;
        private TextBox BInput;
        private TextBox CInput;
        private TextBox AlphaInput;
        private TextBox BettaInput;
        private TextBox GammaInput;
        private Button GradInPoint;
    }
}