namespace Flappy_Bird_Windows_Form
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pipeText = new System.Windows.Forms.Label();
            this.flappyBirdTop = new System.Windows.Forms.Label();
            this.pipeGap = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.spaceBar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(47, 296);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(51, 35);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(291, -311);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(125, 400);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-14, 623);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(518, 120);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(291, 543);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(125, 400);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Wheat;
            this.scoreText.Font = new System.Drawing.Font("Limelight", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(47, 655);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(134, 33);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeText
            // 
            this.pipeText.AutoSize = true;
            this.pipeText.BackColor = System.Drawing.Color.Transparent;
            this.pipeText.Location = new System.Drawing.Point(29, 578);
            this.pipeText.Name = "pipeText";
            this.pipeText.Size = new System.Drawing.Size(51, 15);
            this.pipeText.TabIndex = 5;
            this.pipeText.Text = "pipeText";
            // 
            // flappyBirdTop
            // 
            this.flappyBirdTop.AutoSize = true;
            this.flappyBirdTop.BackColor = System.Drawing.Color.Transparent;
            this.flappyBirdTop.Location = new System.Drawing.Point(29, 593);
            this.flappyBirdTop.Name = "flappyBirdTop";
            this.flappyBirdTop.Size = new System.Drawing.Size(80, 15);
            this.flappyBirdTop.TabIndex = 6;
            this.flappyBirdTop.Text = "flappyBirdTop";
            // 
            // pipeGap
            // 
            this.pipeGap.AutoSize = true;
            this.pipeGap.BackColor = System.Drawing.Color.Transparent;
            this.pipeGap.Location = new System.Drawing.Point(29, 563);
            this.pipeGap.Name = "pipeGap";
            this.pipeGap.Size = new System.Drawing.Size(51, 15);
            this.pipeGap.TabIndex = 7;
            this.pipeGap.Text = "pipeGap";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(158, 353);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(164, 59);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "Click here to start over";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickHere);
            // 
            // spaceBar
            // 
            this.spaceBar.AutoSize = true;
            this.spaceBar.BackColor = System.Drawing.Color.Transparent;
            this.spaceBar.Location = new System.Drawing.Point(29, 548);
            this.spaceBar.Name = "spaceBar";
            this.spaceBar.Size = new System.Drawing.Size(54, 15);
            this.spaceBar.TabIndex = 9;
            this.spaceBar.Text = "spacebar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(484, 696);
            this.Controls.Add(this.spaceBar);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pipeGap);
            this.Controls.Add(this.flappyBirdTop);
            this.Controls.Add(this.pipeText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird Remake - By Tim Smith";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox flappyBird;
        private PictureBox pipeTop;
        private PictureBox ground;
        private PictureBox pipeBottom;
        private Label scoreText;
        private System.Windows.Forms.Timer timer;
        private Label pipeText;
        private Label flappyBirdTop;
        private Label pipeGap;
        private Button restartButton;
        private Label spaceBar;
    }
}