using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class EnemyCar : GameEntity

    {
        private static readonly Random rand = new Random(); 
        private readonly int _resetPositionY;
        private readonly int _minX;
        private readonly int _maxX;

        public EnemyCar(PictureBox sprite, int resetPositionY, int minX, int maxX)
            : base(sprite)
        {
            _resetPositionY = resetPositionY;
            _minX = minX;
            _maxX = maxX;
        }

        public void ResetPosition()
        {
            var rand = new Random();
            Sprite.Top = _resetPositionY;
            Sprite.Left = rand.Next(_minX, _maxX);
        }

        public override void Move(int speed)
        {
            base.Move(speed);
            if (Sprite.Top >= 650)
            {
                ResetPosition();
            }
        }
    }
}
