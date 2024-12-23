namespace Flappy_Bird
{
    public partial class FlappyBird : Form
    {
        const int InitialPipeSpeed = 8;
        const int InitialGravity = 10;
        const int PipeDownResetPosition = 950;
        const int PipeUpResetPosition = 800;
        const int BirdUpperLimit = -25;
        const int PipeWidth = 50;

        int pipeSpeed = InitialPipeSpeed;
        int gravity = InitialGravity;
        int score = 0;
        int max_score = 0;
        bool gameStarted = false;


        public FlappyBird()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                MoveBird();
                MovePipes();
                UpdateScore();
                CheckCollisions();
            }

        }

        private void MoveBird()
        {
            Bird.Top += gravity;
        }

        private void MovePipes()
        {
            PipeDown.Left -= pipeSpeed;
            PipeUp.Left -= pipeSpeed;

            if (PipeDown.Left < -PipeWidth)
            {
                ResetPipe(PipeDown, PipeDownResetPosition);
            }
            if (PipeUp.Left < -PipeWidth)
            {
                ResetPipe(PipeUp, PipeUpResetPosition);
            }
        }

        private void UpdateScore()
        {
            Scorelbl.Text = "Score: " + score.ToString();

            if (score > max_score )
            {
                max_score = score;
            }
         
        }
        private void ResetPipe(PictureBox pipe, int position)
        {
            pipe.Left = position;
            score++;
        }

        private void CheckCollisions()
        {
            if (Bird.Bounds.IntersectsWith(PipeUp.Bounds) ||
                Bird.Bounds.IntersectsWith(PipeDown.Bounds) ||
                Bird.Bounds.IntersectsWith(Ground.Bounds) ||
                Bird.Top < BirdUpperLimit)
            {
                Endgame();
            }
        }

        private void gameKeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                if (!gameStarted)
                {
                    gameStarted = true;
                }

                gravity = -InitialGravity;
            }
        }

        private void gameKeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = InitialGravity;
            }
        }

        private void Endgame()
        {
            gameTimer.Stop();
            gameStarted = false;
            MaxScorelbl.Text = "Max Scores : " + max_score.ToString();
            DialogResult result = MessageBox.Show("Game Over! Do you want to play again?", "Flappy Bird", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RestartGame();

            }
            else
            {
                this.Close();
            }
        }
        private void RestartGame()
        {

            Bird.Top = this.ClientSize.Height / 2;
            PipeDown.Left = PipeDownResetPosition;
            PipeUp.Left = PipeUpResetPosition;

            score = 0;
            gravity = InitialGravity;

            gameTimer.Start();
            gameStarted = true;
        }

     
    }

}
