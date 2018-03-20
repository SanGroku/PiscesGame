namespace Pisces_Game
{
    partial class Round6
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
            this.investFishLbl = new System.Windows.Forms.Label();
            this.investBtn = new System.Windows.Forms.Button();
            this.investBox = new System.Windows.Forms.NumericUpDown();
            this.noBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.fishCaughtLbl = new System.Windows.Forms.Label();
            this.catchfishBtn = new System.Windows.Forms.Button();
            this.catchFishBox = new System.Windows.Forms.NumericUpDown();
            this.catchPromptLbl = new System.Windows.Forms.Label();
            this.investPromptLbl = new System.Windows.Forms.Label();
            this.round1EndBtn = new System.Windows.Forms.Button();
            this.eatFishLbl = new System.Windows.Forms.Label();
            this.eatFishBtn = new System.Windows.Forms.Button();
            this.eatFishBox = new System.Windows.Forms.NumericUpDown();
            this.eatPromptLbl = new System.Windows.Forms.Label();
            this.showZodiacLbl = new System.Windows.Forms.Label();
            this.HeaderLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.investBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchFishBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).BeginInit();
            this.SuspendLayout();
            // 
            // investFishLbl
            // 
            this.investFishLbl.AutoSize = true;
            this.investFishLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investFishLbl.Location = new System.Drawing.Point(216, 1147);
            this.investFishLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.investFishLbl.Name = "investFishLbl";
            this.investFishLbl.Size = new System.Drawing.Size(284, 47);
            this.investFishLbl.TabIndex = 40;
            this.investFishLbl.Text = "Invest the fish";
            this.investFishLbl.Visible = false;
            // 
            // investBtn
            // 
            this.investBtn.Location = new System.Drawing.Point(518, 1078);
            this.investBtn.Margin = new System.Windows.Forms.Padding(6);
            this.investBtn.Name = "investBtn";
            this.investBtn.Size = new System.Drawing.Size(200, 38);
            this.investBtn.TabIndex = 39;
            this.investBtn.Text = "Invest";
            this.investBtn.UseVisualStyleBackColor = true;
            this.investBtn.Visible = false;
            // 
            // investBox
            // 
            this.investBox.Location = new System.Drawing.Point(362, 1078);
            this.investBox.Margin = new System.Windows.Forms.Padding(6);
            this.investBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.investBox.Name = "investBox";
            this.investBox.Size = new System.Drawing.Size(144, 31);
            this.investBox.TabIndex = 38;
            this.investBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.investBox.Visible = false;
            // 
            // noBtn
            // 
            this.noBtn.Location = new System.Drawing.Point(626, 928);
            this.noBtn.Margin = new System.Windows.Forms.Padding(6);
            this.noBtn.Name = "noBtn";
            this.noBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noBtn.Size = new System.Drawing.Size(200, 83);
            this.noBtn.TabIndex = 37;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Visible = false;
            // 
            // yesBtn
            // 
            this.yesBtn.Location = new System.Drawing.Point(300, 928);
            this.yesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(200, 83);
            this.yesBtn.TabIndex = 36;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Visible = false;
            // 
            // fishCaughtLbl
            // 
            this.fishCaughtLbl.AutoSize = true;
            this.fishCaughtLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fishCaughtLbl.Location = new System.Drawing.Point(216, 470);
            this.fishCaughtLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fishCaughtLbl.Name = "fishCaughtLbl";
            this.fishCaughtLbl.Size = new System.Drawing.Size(278, 47);
            this.fishCaughtLbl.TabIndex = 35;
            this.fishCaughtLbl.Text = "Catch the fish";
            this.fishCaughtLbl.Visible = false;
            // 
            // catchfishBtn
            // 
            this.catchfishBtn.Location = new System.Drawing.Point(518, 386);
            this.catchfishBtn.Margin = new System.Windows.Forms.Padding(6);
            this.catchfishBtn.Name = "catchfishBtn";
            this.catchfishBtn.Size = new System.Drawing.Size(200, 38);
            this.catchfishBtn.TabIndex = 34;
            this.catchfishBtn.Text = "Catch";
            this.catchfishBtn.UseVisualStyleBackColor = true;
            this.catchfishBtn.Click += new System.EventHandler(this.catchfishBtn_Click);
            // 
            // catchFishBox
            // 
            this.catchFishBox.Location = new System.Drawing.Point(362, 386);
            this.catchFishBox.Margin = new System.Windows.Forms.Padding(6);
            this.catchFishBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.catchFishBox.Name = "catchFishBox";
            this.catchFishBox.Size = new System.Drawing.Size(144, 31);
            this.catchFishBox.TabIndex = 33;
            this.catchFishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // catchPromptLbl
            // 
            this.catchPromptLbl.AutoSize = true;
            this.catchPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchPromptLbl.Location = new System.Drawing.Point(114, 288);
            this.catchPromptLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.catchPromptLbl.Name = "catchPromptLbl";
            this.catchPromptLbl.Size = new System.Drawing.Size(910, 47);
            this.catchPromptLbl.TabIndex = 32;
            this.catchPromptLbl.Text = "How many fish do you want to catch this round?";
            // 
            // investPromptLbl
            // 
            this.investPromptLbl.AutoSize = true;
            this.investPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investPromptLbl.Location = new System.Drawing.Point(84, 826);
            this.investPromptLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.investPromptLbl.Name = "investPromptLbl";
            this.investPromptLbl.Size = new System.Drawing.Size(959, 47);
            this.investPromptLbl.TabIndex = 31;
            this.investPromptLbl.Text = "Do you want to invest any fish into a private pond?";
            this.investPromptLbl.Visible = false;
            // 
            // round1EndBtn
            // 
            this.round1EndBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.round1EndBtn.Location = new System.Drawing.Point(432, 1290);
            this.round1EndBtn.Margin = new System.Windows.Forms.Padding(6);
            this.round1EndBtn.Name = "round1EndBtn";
            this.round1EndBtn.Size = new System.Drawing.Size(342, 133);
            this.round1EndBtn.TabIndex = 30;
            this.round1EndBtn.Text = "End Round";
            this.round1EndBtn.UseVisualStyleBackColor = true;
            // 
            // eatFishLbl
            // 
            this.eatFishLbl.AutoSize = true;
            this.eatFishLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatFishLbl.Location = new System.Drawing.Point(216, 724);
            this.eatFishLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eatFishLbl.Name = "eatFishLbl";
            this.eatFishLbl.Size = new System.Drawing.Size(228, 47);
            this.eatFishLbl.TabIndex = 29;
            this.eatFishLbl.Text = "Eat the fish";
            this.eatFishLbl.Visible = false;
            // 
            // eatFishBtn
            // 
            this.eatFishBtn.Location = new System.Drawing.Point(518, 634);
            this.eatFishBtn.Margin = new System.Windows.Forms.Padding(6);
            this.eatFishBtn.Name = "eatFishBtn";
            this.eatFishBtn.Size = new System.Drawing.Size(200, 38);
            this.eatFishBtn.TabIndex = 28;
            this.eatFishBtn.Text = "Eat";
            this.eatFishBtn.UseVisualStyleBackColor = true;
            this.eatFishBtn.Visible = false;
            // 
            // eatFishBox
            // 
            this.eatFishBox.Location = new System.Drawing.Point(362, 638);
            this.eatFishBox.Margin = new System.Windows.Forms.Padding(6);
            this.eatFishBox.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.eatFishBox.Name = "eatFishBox";
            this.eatFishBox.Size = new System.Drawing.Size(144, 31);
            this.eatFishBox.TabIndex = 27;
            this.eatFishBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eatFishBox.Visible = false;
            // 
            // eatPromptLbl
            // 
            this.eatPromptLbl.AutoSize = true;
            this.eatPromptLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eatPromptLbl.Location = new System.Drawing.Point(134, 555);
            this.eatPromptLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eatPromptLbl.Name = "eatPromptLbl";
            this.eatPromptLbl.Size = new System.Drawing.Size(866, 47);
            this.eatPromptLbl.TabIndex = 26;
            this.eatPromptLbl.Text = "How many fish do you want to eat this round?";
            this.eatPromptLbl.Visible = false;
            // 
            // showZodiacLbl
            // 
            this.showZodiacLbl.AutoSize = true;
            this.showZodiacLbl.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showZodiacLbl.Location = new System.Drawing.Point(310, 169);
            this.showZodiacLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.showZodiacLbl.Name = "showZodiacLbl";
            this.showZodiacLbl.Size = new System.Drawing.Size(463, 59);
            this.showZodiacLbl.TabIndex = 25;
            this.showZodiacLbl.Text = "Here be the zodiac";
            this.showZodiacLbl.Visible = false;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(286, -1);
            this.HeaderLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(539, 113);
            this.HeaderLbl.TabIndex = 24;
            this.HeaderLbl.Text = "ROUND 6";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Round6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1151, 1472);
            this.Controls.Add(this.investFishLbl);
            this.Controls.Add(this.investBtn);
            this.Controls.Add(this.investBox);
            this.Controls.Add(this.noBtn);
            this.Controls.Add(this.yesBtn);
            this.Controls.Add(this.fishCaughtLbl);
            this.Controls.Add(this.catchfishBtn);
            this.Controls.Add(this.catchFishBox);
            this.Controls.Add(this.catchPromptLbl);
            this.Controls.Add(this.investPromptLbl);
            this.Controls.Add(this.round1EndBtn);
            this.Controls.Add(this.eatFishLbl);
            this.Controls.Add(this.eatFishBtn);
            this.Controls.Add(this.eatFishBox);
            this.Controls.Add(this.eatPromptLbl);
            this.Controls.Add(this.showZodiacLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Round6";
            this.Text = "Round6";
            ((System.ComponentModel.ISupportInitialize)(this.investBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catchFishBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eatFishBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label investFishLbl;
        private System.Windows.Forms.Button investBtn;
        private System.Windows.Forms.NumericUpDown investBox;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label fishCaughtLbl;
        private System.Windows.Forms.Button catchfishBtn;
        private System.Windows.Forms.NumericUpDown catchFishBox;
        private System.Windows.Forms.Label catchPromptLbl;
        private System.Windows.Forms.Label investPromptLbl;
        private System.Windows.Forms.Button round1EndBtn;
        private System.Windows.Forms.Label eatFishLbl;
        private System.Windows.Forms.Button eatFishBtn;
        private System.Windows.Forms.NumericUpDown eatFishBox;
        private System.Windows.Forms.Label eatPromptLbl;
        private System.Windows.Forms.Label showZodiacLbl;
        private System.Windows.Forms.Label HeaderLbl;
    }
}