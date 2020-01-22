namespace Cavern
{
    partial class ScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreScreen));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Pioneer BT", 25F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Location = new System.Drawing.Point(152, 34);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(277, 47);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Leaderboard";
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.BackColor = System.Drawing.Color.Transparent;
            this.firstLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.firstLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.firstLabel.Location = new System.Drawing.Point(155, 158);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(33, 27);
            this.firstLabel.TabIndex = 1;
            this.firstLabel.Text = "1.";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.BackColor = System.Drawing.Color.Transparent;
            this.secondLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.secondLabel.Location = new System.Drawing.Point(155, 198);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(33, 27);
            this.secondLabel.TabIndex = 2;
            this.secondLabel.Text = "2.";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.BackColor = System.Drawing.Color.Transparent;
            this.thirdLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.thirdLabel.Location = new System.Drawing.Point(155, 238);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(33, 27);
            this.thirdLabel.TabIndex = 3;
            this.thirdLabel.Text = "3.";
            // 
            // fourthLabel
            // 
            this.fourthLabel.AutoSize = true;
            this.fourthLabel.BackColor = System.Drawing.Color.Transparent;
            this.fourthLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.fourthLabel.Location = new System.Drawing.Point(155, 278);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(33, 27);
            this.fourthLabel.TabIndex = 4;
            this.fourthLabel.Text = "4.";
            // 
            // fifthLabel
            // 
            this.fifthLabel.AutoSize = true;
            this.fifthLabel.BackColor = System.Drawing.Color.Transparent;
            this.fifthLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.fifthLabel.Location = new System.Drawing.Point(155, 316);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(33, 27);
            this.fifthLabel.TabIndex = 5;
            this.fifthLabel.Text = "5.";
            // 
            // ScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(41)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.scoreLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ScoreScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
    }
}
