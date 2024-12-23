namespace Flappy_Bird
{
    partial class FlappyBird
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Bird = new PictureBox();
            PipeUp = new PictureBox();
            PipeDown = new PictureBox();
            Ground = new PictureBox();
            Scorelbl = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            MaxScorelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)Bird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            SuspendLayout();
            // 
            // Bird
            // 
            Bird.Image = Properties.Resources.bird_1_;
            Bird.Location = new Point(74, 341);
            Bird.Name = "Bird";
            Bird.Size = new Size(58, 58);
            Bird.SizeMode = PictureBoxSizeMode.StretchImage;
            Bird.TabIndex = 0;
            Bird.TabStop = false;
            // 
            // PipeUp
            // 
            PipeUp.Image = Properties.Resources.pipe_1_;
            PipeUp.Location = new Point(405, 443);
            PipeUp.Name = "PipeUp";
            PipeUp.Size = new Size(79, 169);
            PipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeUp.TabIndex = 1;
            PipeUp.TabStop = false;
            // 
            // PipeDown
            // 
            PipeDown.Image = Properties.Resources.pipedown_1_;
            PipeDown.Location = new Point(465, 3);
            PipeDown.Name = "PipeDown";
            PipeDown.Size = new Size(79, 238);
            PipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            PipeDown.TabIndex = 2;
            PipeDown.TabStop = false;
            // 
            // Ground
            // 
            Ground.Image = Properties.Resources.ground_1_;
            Ground.Location = new Point(1, 608);
            Ground.Name = "Ground";
            Ground.Size = new Size(1472, 93);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 3;
            Ground.TabStop = false;
            // 
            // Scorelbl
            // 
            Scorelbl.AutoSize = true;
            Scorelbl.Font = new Font("Khmer OS Battambang", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Scorelbl.Location = new Point(1, 3);
            Scorelbl.Name = "Scorelbl";
            Scorelbl.Size = new Size(111, 41);
            Scorelbl.TabIndex = 4;
            Scorelbl.Text = "Score : 0";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // MaxScorelbl
            // 
            MaxScorelbl.AutoSize = true;
            MaxScorelbl.Font = new Font("Khmer OS Battambang", 13.8F);
            MaxScorelbl.Location = new Point(152, 3);
            MaxScorelbl.Name = "MaxScorelbl";
            MaxScorelbl.Size = new Size(161, 41);
            MaxScorelbl.TabIndex = 5;
            MaxScorelbl.Text = "Max Scores : ";
            // 
            // FlappyBird
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(620, 699);
            Controls.Add(MaxScorelbl);
            Controls.Add(Scorelbl);
            Controls.Add(Ground);
            Controls.Add(PipeDown);
            Controls.Add(PipeUp);
            Controls.Add(Bird);
            Name = "FlappyBird";
            Text = " ";
            KeyDown += gameKeyisDown;
            KeyUp += gameKeyisUp;
            ((System.ComponentModel.ISupportInitialize)Bird).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)PipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Bird;
        private PictureBox PipeUp;
        private PictureBox PipeDown;
        private PictureBox Ground;
        private Label Scorelbl;
        private System.Windows.Forms.Timer gameTimer;
        private Button StartGame;
        private Label MaxScorelbl;
        //private Button StartGame;
    }
}
