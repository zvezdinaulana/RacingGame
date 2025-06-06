namespace RacingGame
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bg1 = new PictureBox();
            bg2 = new PictureBox();
            player = new PictureBox();
            enemy1 = new PictureBox();
            enemy2 = new PictureBox();
            coin = new PictureBox();
            btnRestart = new Button();
            labelLose = new Label();
            labelCoin = new Label();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            SuspendLayout();
            // 
            // bg1
            // 
            bg1.Image = (Image)resources.GetObject("bg1.Image");
            bg1.Location = new Point(0, 0);
            bg1.Name = "bg1";
            bg1.Size = new Size(840, 650);
            bg1.TabIndex = 0;
            bg1.TabStop = false;
            // 
            // bg2
            // 
            bg2.Image = (Image)resources.GetObject("bg2.Image");
            bg2.Location = new Point(0, -650);
            bg2.Name = "bg2";
            bg2.Size = new Size(840, 650);
            bg2.TabIndex = 1;
            bg2.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(64, 64, 64);
            player.Image = (Image)resources.GetObject("player.Image");
            player.Location = new Point(517, 481);
            player.Name = "player";
            player.Size = new Size(90, 93);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.FromArgb(64, 64, 64);
            enemy1.Image = (Image)resources.GetObject("enemy1.Image");
            enemy1.Location = new Point(192, -150);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(102, 113);
            enemy1.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy1.TabIndex = 3;
            enemy1.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.FromArgb(64, 64, 64);
            enemy2.Image = (Image)resources.GetObject("enemy2.Image");
            enemy2.Location = new Point(517, -400);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(102, 113);
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy2.TabIndex = 4;
            enemy2.TabStop = false;
            // 
            // coin
            // 
            coin.BackColor = Color.FromArgb(64, 64, 64);
            coin.Image = (Image)resources.GetObject("coin.Image");
            coin.Location = new Point(502, -600);
            coin.Name = "coin";
            coin.Size = new Size(49, 42);
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.TabIndex = 5;
            coin.TabStop = false;
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Maroon;
            btnRestart.FlatStyle = FlatStyle.Popup;
            btnRestart.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestart.ForeColor = SystemColors.Control;
            btnRestart.Location = new Point(290, 279);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(264, 54);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Перезапустить";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click_1;
            // 
            // labelLose
            // 
            labelLose.AutoSize = true;
            labelLose.BackColor = Color.Maroon;
            labelLose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLose.ForeColor = SystemColors.Control;
            labelLose.Location = new Point(290, 204);
            labelLose.Name = "labelLose";
            labelLose.Size = new Size(272, 43);
            labelLose.TabIndex = 7;
            labelLose.Text = "Вы проиграли";
            // 
            // labelCoin
            // 
            labelCoin.AutoSize = true;
            labelCoin.BackColor = Color.Brown;
            labelCoin.Font = new Font("SimSun-ExtB", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoin.ForeColor = SystemColors.Control;
            labelCoin.Location = new Point(0, 0);
            labelCoin.Name = "labelCoin";
            labelCoin.Size = new Size(152, 28);
            labelCoin.TabIndex = 8;
            labelCoin.Text = "Монеты: 0";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20;
            timer.Tick += timer_Tick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(822, 603);
            Controls.Add(labelCoin);
            Controls.Add(labelLose);
            Controls.Add(btnRestart);
            Controls.Add(coin);
            Controls.Add(enemy2);
            Controls.Add(enemy1);
            Controls.Add(player);
            Controls.Add(bg1);
            Controls.Add(bg2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)bg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox bg1;
        private PictureBox bg2;
        private PictureBox player;
        private PictureBox enemy1;
        private PictureBox enemy2;
        private PictureBox coin;
        private Button btnRestart;
        private Label labelLose;
        private Label labelCoin;
        private System.Windows.Forms.Timer timer;
    }
}
