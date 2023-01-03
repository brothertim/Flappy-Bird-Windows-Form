namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {
        int score = 0;
        int pipeSpeed = 10;
        int gravity = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        //what happens when a key is pressed
        private void gamekeyisdown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space) { gravity = -7; }
            spaceBar.Text = "Spacebar pressed";
        }
        //what happens when a key is not pressed
        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) { gravity = 10; }
            spaceBar.Text = "Spacebar not pressed";
        }



        //main game
        private void gameTimerEvent(object sender, EventArgs e)
        {
            pipeSpeed = 10 + (score / 10);  //speeds up pipe relative to current score
            flappyBird.Top += gravity; //keeps adding 'gravity' causing continual motion
            pipeBottom.Left -= pipeSpeed; //moves pipe at pipeSpeed, but doesn't continue to add like gravity
            pipeTop.Left -= pipeSpeed; 
            scoreText.Text = "Score: " + score; //display current score
            restartButton.Visible = false;
            int gap = 250 + (250 - (score*5)); //minimum gap of 250, max 500


            //pipe generation 
            Random pipeRandom = new Random();
            if (pipeBottom.Left < -150)  //executes when pipe moves off screen
            {
                //horizontal spacing
                int pipePlacementHorizontal = pipeRandom.Next(600, 1200);
                pipeBottom.Left = pipePlacementHorizontal;
                pipeTop.Left = pipePlacementHorizontal;
                score++;
                //vertical spacing
                int pipePlacementVertical = pipeRandom.Next(-350, -50);
                int pipeHeight = 400;
                pipeTop.Top = pipePlacementVertical;
                pipeBottom.Top = (pipePlacementVertical + pipeHeight + gap);
            }

            //testdata to monitor behaviors
            pipeText.Text = "Pipe Speed: " + pipeSpeed;
            flappyBirdTop.Text = "Position: " + flappyBird.Top;
            pipeGap.Text = "Pipe Gap: " + gap;


            //object intersection rules
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }

            //outofbounds rule, locks inside frame to prevent flying over pipes
            while(flappyBird.Top < 1) 
            {
                flappyBird.Top = 1;
            }
        }
        private void clickHere(object sender, MouseEventArgs e)
        {
            Application.Restart();
        }


        //end game function
        private void endGame()
        {
            timer.Stop();
            scoreText.Text += " - Game Over!!!";
            restartButton.Visible = true;
        }


    }
}