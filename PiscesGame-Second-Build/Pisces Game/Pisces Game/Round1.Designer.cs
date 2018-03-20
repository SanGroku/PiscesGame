namespace Pisces_Game
{
    partial class Round1
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.showZodiacLbl = new System.Windows.Forms.Label();
            this.PromptLbl = new System.Windows.Forms.Label();
            this.eatFishBtn = new System.Windows.Forms.Button();
            this.eatFishLbl = new System.Windows.Forms.Label();
            this.round1EndBtn = new System.Windows.Forms.Button();
            this.eatFishBox = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(353, 9);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(270, 56);
            this.HeaderLbl.TabIndex = 1;
            this.HeaderLbl.Text = "ROUND 1";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showZodiacLbl
            // 
            this.showZodiacLbl.AutoSize = true;
            this.showZodiacLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showZodiacLbl.Location = new System.Drawing.Point(414, 102);
            this.showZodiacLbl.Name = "showZodiacLbl";
            this.showZodiacLbl.Size = new System.Drawing.Size(232, 29);
            this.showZodiacLbl.TabIndex = 2;
            this.showZodiacLbl.Text = "Here be the zodiac";
            this.showZodiacLbl.Visible = false;
            // 
            // PromptLbl
            // 
            this.PromptLbl.AutoSize = true;
            this.PromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLbl.Location = new System.Drawing.Point(269, 170);
            this.PromptLbl.Name = "PromptLbl";
            this.PromptLbl.Size = new System.Drawing.Size(436, 23);
            this.PromptLbl.TabIndex = 3;
            this.PromptLbl.Text = "How many fish do you want to eat this round?";
            // 
            // eatFishBtn
            // 
            this.eatFishBtn.Location = new System.Drawing.Point(467, 222);
            this.eatFishBtn.Name = "eatFishBtn";
            this.eatFishBtn.Size = new System.Drawing.Size(100, 20);
            this.eatFishBtn.TabIndex = 5;
            this.eatFishBtn.Text = "Eat";
            this.eatFishBtn.UseVisualStyleBackColor = true;
            this.eatFishBtn.Click += new System.EventHandler(this.eatFishBtn_Click);
            // 
            // eatFishLbl
            // 
            this.eatFishLbl.AutoSize = true;
            this.eatFishLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatFishLbl.Location = new System.Drawing.Point(319, 266);
            this.eatFishLbl.Name = "eatFishLbl";
            this.eatFishLbl.Size = new System.Drawing.Size(117, 23);
            this.eatFishLbl.TabIndex = 7;
            this.eatFishLbl.Text = "Eat the fish";
            this.eatFishLbl.Visible = false;
            // 
            // round1EndBtn
            // 
            this.round1EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1EndBtn.Location = new System.Drawing.Point(405, 637);
            this.round1EndBtn.Name = "round1EndBtn";
            this.round1EndBtn.Size = new System.Drawing.Size(171, 69);
            this.round1EndBtn.TabIndex = 8;
            this.round1EndBtn.Text = "End Round";
            this.round1EndBtn.UseVisualStyleBackColor = true;
            this.round1EndBtn.Click += new System.EventHandler(this.round1EndBtn_Click);
            // 
            // eatFishBox
            // 
            this.eatFishBox.Location = new System.Drawing.Point(389, 222);
            this.eatFishBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.eatFishBox.Name = "eatFishBox";
            this.eatFishBox.Size = new System.Drawing.Size(72, 20);
            this.eatFishBox.TabIndex = 6;
            this.eatFishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Round1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.round1EndBtn);
            this.Controls.Add(this.eatFishLbl);
            this.Controls.Add(this.eatFishBox);
            this.Controls.Add(this.eatFishBtn);
            this.Controls.Add(this.PromptLbl);
            this.Controls.Add(this.showZodiacLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Round1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pisces Game";
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label showZodiacLbl;
        private System.Windows.Forms.Label PromptLbl;
        private System.Windows.Forms.Button eatFishBtn;
        private System.Windows.Forms.Label eatFishLbl;
        private System.Windows.Forms.Button round1EndBtn;
        private System.Windows.Forms.NumericUpDown eatFishBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}