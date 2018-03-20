namespace Pisces_Game
{
    partial class Sustainability2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.Incorrect = new System.Windows.Forms.Label();
            this.Correct = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1254, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Tragedy of The Commons deals with the subject of:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 126);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. Over consumption of resources\r\n2.  Paying it foreward \r\n3. Altruism\r\n";
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(570, 508);
            this.Answer.Margin = new System.Windows.Forms.Padding(6);
            this.Answer.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(144, 31);
            this.Answer.TabIndex = 18;
            this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 508);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect.ForeColor = System.Drawing.Color.Red;
            this.Incorrect.Location = new System.Drawing.Point(769, 581);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(203, 49);
            this.Incorrect.TabIndex = 16;
            this.Incorrect.Text = "Incorrect";
            this.Incorrect.Visible = false;
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct.ForeColor = System.Drawing.Color.ForestGreen;
            this.Correct.Location = new System.Drawing.Point(547, 581);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(176, 49);
            this.Correct.TabIndex = 15;
            this.Correct.Text = "Correct";
            this.Correct.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(556, 678);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(423, 141);
            this.Continue.TabIndex = 14;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Sustainability2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1637, 1162);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sustainability2";
            this.Text = "Sustainability2";
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Button Continue;
    }
}