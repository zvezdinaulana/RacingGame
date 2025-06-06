using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace RacingGame
{
    public partial class Form1 : Form
    {
        private Point pos;
        private bool draggin, lose = false;
        private int countCoins = 0;

        private EnemyCar enemyCar1;
        private EnemyCar enemyCar2;
        private Coin coinObj;

        public Form1()
        {


            InitializeComponent();

            // Инициализация игровых объектов с правильными именами
            enemyCar1 = new EnemyCar(enemy1, -130, 150, 300);
            enemyCar2 = new EnemyCar(enemy2, -400, 300, 560);
            coinObj = new Coin(coin);
            coinObj.ResetPosition(); ;

            bg1.MouseDown += MouseClickDown;
            bg1.MouseUp += MouseClickUp;
            bg1.MouseMove += MouseClickMove;
            bg2.MouseDown += MouseClickDown;
            bg2.MouseUp += MouseClickUp;
            bg2.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            btnRestart.Visible = false;
            KeyPreview = true;

            // Установка начальной позиции игрока
            player.Top = 500;
            player.Left = 300;

            timer.Enabled = true;
            timer.Start();
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (lose) // Если игра проиграна - блокируем управление
                return false;

            int moveStep = 10;

            if (keyData == Keys.Left && player.Left > 150)
            {
                player.Left -= moveStep;
                return true;
            }
            else if (keyData == Keys.Right && player.Right < 700)
            {
                player.Left += moveStep;
                return true;
            }
            else if (keyData == Keys.Up && player.Top > 150)
            {
                player.Top -= moveStep;
                return true;
            }
            else if (keyData == Keys.Down && player.Bottom < 650)
            {
                player.Top += moveStep;
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            draggin = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            draggin = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (draggin)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + bg1.Top);
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            // Дополнительная инициализация при загрузке формы
        }

        private void btnRestart_Click_1(object sender, EventArgs e)
        {
            enemyCar1.ResetPosition();
            enemyCar2.ResetPosition();
            coinObj.ResetPosition();

            labelLose.Visible = false;
            btnRestart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countCoins = 0;
            labelCoin.Text = "Монеты: 0";

            player.Top = 500;
            player.Left = 300;

        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            int speed = 5;
            bg1.Top += speed;
            bg2.Top += speed;


            // Движение объектов через классы
            enemyCar1.Move(7);
            enemyCar2.Move(7);
            coinObj.Move(speed);


            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random rand = new Random();
                coin.Left = rand.Next(150, 560);
            }

            if (bg1.Top >= 650)
            {
                bg1.Top = 0;
                bg2.Top = -650;
            }

            if (player.Bounds.IntersectsWith(enemyCar1.Bounds) ||
                player.Bounds.IntersectsWith(enemyCar2.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                btnRestart.Visible = true;
                lose = true;
            }

            if (player.Bounds.IntersectsWith(coinObj.Bounds))
            {
                countCoins++;
                labelCoin.Text = $"Монеты: {countCoins}";
                coinObj.ResetPosition();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                this.Close();
        }
    }
}
