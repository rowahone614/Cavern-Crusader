namespace Cavern
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.crusaderImage = new System.Windows.Forms.PictureBox();
            this.stalag1 = new System.Windows.Forms.PictureBox();
            this.stalac2 = new System.Windows.Forms.PictureBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crusaderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalag1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalac2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // crusaderImage
            // 
            this.crusaderImage.BackColor = System.Drawing.Color.Transparent;
            this.crusaderImage.Image = ((System.Drawing.Image)(resources.GetObject("crusaderImage.Image")));
            this.crusaderImage.Location = new System.Drawing.Point(71, 184);
            this.crusaderImage.Name = "crusaderImage";
            this.crusaderImage.Size = new System.Drawing.Size(79, 41);
            this.crusaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crusaderImage.TabIndex = 30;
            this.crusaderImage.TabStop = false;
            // 
            // stalag1
            // 
            this.stalag1.BackColor = System.Drawing.Color.Transparent;
            this.stalag1.Image = ((System.Drawing.Image)(resources.GetObject("stalag1.Image")));
            this.stalag1.Location = new System.Drawing.Point(600, 221);
            this.stalag1.Name = "stalag1";
            this.stalag1.Size = new System.Drawing.Size(100, 179);
            this.stalag1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stalag1.TabIndex = 32;
            this.stalag1.TabStop = false;
            // 
            // stalac2
            // 
            this.stalac2.BackColor = System.Drawing.Color.Transparent;
            this.stalac2.Image = ((System.Drawing.Image)(resources.GetObject("stalac2.Image")));
            this.stalac2.Location = new System.Drawing.Point(600, 0);
            this.stalac2.Name = "stalac2";
            this.stalac2.Size = new System.Drawing.Size(100, 138);
            this.stalac2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stalac2.TabIndex = 33;
            this.stalac2.TabStop = false;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.speedLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.speedLabel.Location = new System.Drawing.Point(25, 359);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(125, 27);
            this.speedLabel.TabIndex = 34;
            this.speedLabel.Text = "Speed = 1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Pioneer BT", 15F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreLabel.Location = new System.Drawing.Point(25, 332);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(126, 27);
            this.scoreLabel.TabIndex = 35;
            this.scoreLabel.Text = "Score = 0";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Pioneer BT", 20F);
            this.gameOverLabel.ForeColor = System.Drawing.Color.OldLace;
            this.gameOverLabel.Location = new System.Drawing.Point(197, 175);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(0, 37);
            this.gameOverLabel.TabIndex = 36;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(123)))), ((int)(((byte)(106)))));
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.crusaderImage);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.stalac2);
            this.Controls.Add(this.stalag1);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 400);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.crusaderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalag1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stalac2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox crusaderImage;
        private System.Windows.Forms.PictureBox stalag1;
        private System.Windows.Forms.PictureBox stalac2;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label gameOverLabel;
    }
}
