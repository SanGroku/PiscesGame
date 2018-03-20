namespace Pisces_Game
{
    partial class Sustainability6
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
            this.Answer = new System.Windows.Forms.NumericUpDown();
            this.Incorrect = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Correct = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(685, 748);
            this.Answer.Margin = new System.Windows.Forms.Padding(6);
            this.Answer.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(144, 31);
            this.Answer.TabIndex = 21;
            this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect.ForeColor = System.Drawing.Color.Red;
            this.Incorrect.Location = new System.Drawing.Point(914, 821);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(203, 49);
            this.Incorrect.TabIndex = 19;
            this.Incorrect.Text = "Incorrect";
            this.Incorrect.Visible = false;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(906, 748);
            this.Confirm.Margin = new System.Windows.Forms.Padding(6);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(200, 38);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct.ForeColor = System.Drawing.Color.ForestGreen;
            this.Correct.Location = new System.Drawing.Point(692, 816);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(176, 49);
            this.Correct.TabIndex = 18;
            this.Correct.Text = "Correct";
            this.Correct.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(659, 924);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(423, 141);
            this.Continue.TabIndex = 17;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1394, 216);
            this.label3.TabIndex = 16;
            this.label3.Text = "1. Not enough money\r\n2. The Spanish Inquisition\r\n3. Spam\r\n4. Ill planning in cons" +
    "ervation and the excess use of resources\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(871, 78);
            this.label1.TabIndex = 14;
            this.label1.Text = "What causes the Tragedy?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sustainability6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1890, 1267);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Sustainability6";
            this.Text = "Sustainability6";
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Answer;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}