using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Tetris
{
    public partial class TetrisForm : Form
    {
        Grid grid;
        Shape shape; //current shape that is moving
        ShapeQueue shapeQueue;
        HighScoresForm highScoreForm;
        Stopwatch stopwatch;
        public TetrisForm()
        {
            InitializeComponent();
            highScoreForm = new HighScoresForm();
            InitializeGame();
            GameTimer.Stop();
            SubscribeForNewHighscore();
        }

        private void InitializeGame()
        {
            
            grid = new Grid(30, 15);
            GridManager.GetGrid(grid);
            shapeQueue = new ShapeQueue();
            shape = shapeQueue.NextShape();
            shape = shapeQueue.NextShape();

            Score.LoadScores();
            Score.CurrentScore = 0;//50;
            Score.Level = 1;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            GameTimer.Interval = 180;

            lblScoreAmount.Text = "0";
            lblLevel.Text = "1 Level";
            btnRestart.Visible = false;
            btnHighScores.Visible = false;
            GameTimer.Start();
            this.Focus();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!shape.MoveDown())
            {
                grid.PlaceShapeBlocksInGrid(shape.GetBlocks);
                shape = shapeQueue.NextShape();
                if (!shape.IsShapePossible())
                {
                    GameTimer.Stop();
                    Score.CheckIfHighscore();
                    btnRestart.Visible = true;
                    btnHighScores.Visible = true;
                }
                if (stopwatch.Elapsed.Seconds > 30)
                    RiseLevel();
                Score.Update(lblScoreAmount);
                QueuePanel.Refresh();
            }

            this.Refresh(); //forces repaint
        }

        private void RiseLevel()
        {
            if (GameTimer.Interval > 60)
            {
                GameTimer.Interval -= 20;
                Score.Level++;
            }
            stopwatch.Restart();
            lblLevel.Text = Score.Level + " Level";
        }

        private void TetrisForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down && GameTimer.Enabled)
            {
                shape.MoveAtBottom();
            }
            else if (e.KeyData == Keys.Right && GameTimer.Enabled)
            {
                shape.MoveRight();
            }
            else if (e.KeyData == Keys.Left && GameTimer.Enabled)
            {
                shape.MoveLeft();
            }
            else if (e.KeyData == Keys.Space && GameTimer.Enabled)
            {
                shape.Rotate();
            }
            else if (e.KeyData == Keys.P || e.KeyData == Keys.Escape)
            {
                GameTimer.Enabled = !GameTimer.Enabled;
            }

            this.Refresh();
        }

        private void TetrisForm_Paint(object sender, PaintEventArgs e)
        {
            shape.Draw(e.Graphics);
            grid.Draw(e.Graphics);
        }

        private void QueuePanel_Paint(object sender, PaintEventArgs e)
        {
            shapeQueue.Draw(e.Graphics);
        }

        
        public void SubscribeForNewHighscore()
        {
            Score.newHighscore += new Score.NewHighscore(SubmitHighscore);
        }

        private void SubmitHighscore(ScoreEntry entry)
        {
            SubmitHighscoreForm newSubmit = new SubmitHighscoreForm(entry);
            newSubmit.Show();
            newSubmit.Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            if (!highScoreForm.IsDisposed)
            {
                highScoreForm.LoadScores();
                highScoreForm.Show();
                highScoreForm.Focus();
            }
            else
            {
                highScoreForm = new HighScoresForm();
                highScoreForm.LoadScores();
                highScoreForm.Show();
                highScoreForm.Focus();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            btnStart.Visible = false;
            this.Focus();
        }
    }
}
