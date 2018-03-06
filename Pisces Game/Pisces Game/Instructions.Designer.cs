namespace Pisces_Game
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.ContinueBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ZodiacLbl = new System.Windows.Forms.Label();
            this.ZodiacBox = new System.Windows.Forms.ComboBox();
            this.InstuctionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.BackColor = System.Drawing.Color.Transparent;
            this.HeaderLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(219, 9);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(544, 76);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "HOW TO PLAY";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ContinueBtn
            // 
            this.ContinueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueBtn.Location = new System.Drawing.Point(414, 689);
            this.ContinueBtn.Name = "ContinueBtn";
            this.ContinueBtn.Size = new System.Drawing.Size(150, 60);
            this.ContinueBtn.TabIndex = 1;
            this.ContinueBtn.Text = "Continue";
            this.ContinueBtn.UseVisualStyleBackColor = true;
            this.ContinueBtn.Click += new System.EventHandler(this.ContinueBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(570, 625);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "What is your zodiac sign?";
            // 
            // ZodiacLbl
            // 
            this.ZodiacLbl.AutoSize = true;
            this.ZodiacLbl.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZodiacLbl.Location = new System.Drawing.Point(371, 651);
            this.ZodiacLbl.Name = "ZodiacLbl";
            this.ZodiacLbl.Size = new System.Drawing.Size(58, 19);
            this.ZodiacLbl.TabIndex = 5;
            this.ZodiacLbl.Text = "label2";
            this.ZodiacLbl.Visible = false;
            // 
            // ZodiacBox
            // 
            this.ZodiacBox.FormattingEnabled = true;
            this.ZodiacBox.Items.AddRange(new object[] {
            "Aries",
            "Taurus",
            "Gemini ",
            "Cancer",
            "Leo",
            "Virgo",
            "Libra",
            "Scorpio",
            "Sagittarius",
            "Capricorn",
            "Aquarius",
            "Pisces"});
            this.ZodiacBox.Location = new System.Drawing.Point(319, 627);
            this.ZodiacBox.Name = "ZodiacBox";
            this.ZodiacBox.Size = new System.Drawing.Size(245, 21);
            this.ZodiacBox.TabIndex = 2;
            // 
            // InstuctionLbl
            // 
            this.InstuctionLbl.BackColor = System.Drawing.Color.Transparent;
            this.InstuctionLbl.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstuctionLbl.Location = new System.Drawing.Point(38, 85);
            this.InstuctionLbl.Name = "InstuctionLbl";
            this.InstuctionLbl.Size = new System.Drawing.Size(917, 495);
            this.InstuctionLbl.TabIndex = 6;
            this.InstuctionLbl.Text = resources.GetString("InstuctionLbl.Text");
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.InstuctionLbl);
            this.Controls.Add(this.ZodiacLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.ZodiacBox);
            this.Controls.Add(this.ContinueBtn);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "Instructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pisces Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button ContinueBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ZodiacLbl;
        private System.Windows.Forms.ComboBox ZodiacBox;
        private System.Windows.Forms.Label InstuctionLbl;
    }
}