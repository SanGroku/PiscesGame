namespace Pisces_Game
{
    partial class Sustainability5
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Incorrect = new System.Windows.Forms.Label();
            this.Correct = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(342, 480);
            this.Answer.Margin = new System.Windows.Forms.Padding(6);
            this.Answer.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(144, 31);
            this.Answer.TabIndex = 36;
            this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(561, 480);
            this.Confirm.Margin = new System.Windows.Forms.Padding(6);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(200, 38);
            this.Confirm.TabIndex = 35;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect.ForeColor = System.Drawing.Color.Red;
            this.Incorrect.Location = new System.Drawing.Point(558, 553);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(203, 49);
            this.Incorrect.TabIndex = 34;
            this.Incorrect.Text = "Incorrect";
            this.Incorrect.Visible = false;
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct.ForeColor = System.Drawing.Color.ForestGreen;
            this.Correct.Location = new System.Drawing.Point(336, 553);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(176, 49);
            this.Correct.TabIndex = 33;
            this.Correct.Text = "Correct";
            this.Correct.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(345, 650);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(423, 141);
            this.Continue.TabIndex = 32;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(411, 126);
            this.label4.TabIndex = 31;
            this.label4.Text = "1. Common land\r\n2.A town\r\n3.Something in relation\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 54);
            this.label3.TabIndex = 30;
            this.label3.Text = "What is a common?";
            // 
            // Sustainability5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1169, 894);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Sustainability5";
            this.Text = "Sustainability5";
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Answer;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}