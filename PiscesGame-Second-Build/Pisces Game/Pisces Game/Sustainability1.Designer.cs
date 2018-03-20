namespace Pisces_Game
{
    partial class Sustainability1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sustainability1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Incorrect = new System.Windows.Forms.Label();
            this.Correct = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1776, 336);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "This is an example of;\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 144);
            this.label3.TabIndex = 7;
            this.label3.Text = "1. Stone Soup\r\n2. Prisoner\'s Dilemma\r\n3. Nash Equilibrium\r\n4. Tragedy of The Comm" +
    "ons\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(855, 711);
            this.Confirm.Margin = new System.Windows.Forms.Padding(6);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(200, 38);
            this.Confirm.TabIndex = 12;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect.ForeColor = System.Drawing.Color.Red;
            this.Incorrect.Location = new System.Drawing.Point(892, 792);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(203, 49);
            this.Incorrect.TabIndex = 11;
            this.Incorrect.Text = "Incorrect";
            this.Incorrect.Visible = false;
            // 
            // Correct
            // 
            this.Correct.AutoSize = true;
            this.Correct.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct.ForeColor = System.Drawing.Color.ForestGreen;
            this.Correct.Location = new System.Drawing.Point(641, 779);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(176, 49);
            this.Correct.TabIndex = 10;
            this.Correct.Text = "Correct";
            this.Correct.Visible = false;
            this.Correct.Click += new System.EventHandler(this.Correct_Click);
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.Location = new System.Drawing.Point(608, 887);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(423, 141);
            this.Continue.TabIndex = 9;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(634, 711);
            this.Answer.Margin = new System.Windows.Forms.Padding(6);
            this.Answer.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(144, 31);
            this.Answer.TabIndex = 13;
            this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Answer.ValueChanged += new System.EventHandler(this.Answer_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(863, 784);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 49);
            this.label5.TabIndex = 11;
            this.label5.Text = "Incorrect";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Sustainability1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1796, 1162);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.Correct);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sustainability1";
            this.Text = "Sustainability1";
            ((System.ComponentModel.ISupportInitialize)(this.Answer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label Incorrect;
        private System.Windows.Forms.Label Correct;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.NumericUpDown Answer;
        private System.Windows.Forms.Label label5;
    }
}