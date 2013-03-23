namespace Tetris
{
    partial class TetrisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetrisForm));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreAmount = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.QueuePanel = new System.Windows.Forms.Panel();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(358, 210);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: ";
            // 
            // lblScoreAmount
            // 
            this.lblScoreAmount.AutoSize = true;
            this.lblScoreAmount.Location = new System.Drawing.Point(358, 233);
            this.lblScoreAmount.Name = "lblScoreAmount";
            this.lblScoreAmount.Size = new System.Drawing.Size(13, 13);
            this.lblScoreAmount.TabIndex = 2;
            this.lblScoreAmount.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 180;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(346, 287);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "&Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // QueuePanel
            // 
            this.QueuePanel.Location = new System.Drawing.Point(344, 12);
            this.QueuePanel.Name = "QueuePanel";
            this.QueuePanel.Size = new System.Drawing.Size(91, 195);
            this.QueuePanel.TabIndex = 101;
            this.QueuePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.QueuePanel_Paint);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Location = new System.Drawing.Point(346, 317);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(75, 23);
            this.btnHighScores.TabIndex = 10;
            this.btnHighScores.Text = "High &Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(346, 287);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 102;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(358, 260);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(42, 13);
            this.lblLevel.TabIndex = 103;
            this.lblLevel.Text = "1 Level";
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 636);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.QueuePanel);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblScoreAmount);
            this.Controls.Add(this.lblScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TetrisForm";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TetrisForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreAmount;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel QueuePanel;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLevel;
    }
}

