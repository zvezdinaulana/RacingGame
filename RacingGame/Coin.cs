using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Coin : GameEntity
    {
        private static readonly Random rand = new Random();

        public Coin(PictureBox sprite) : base(sprite)
        {
            ResetPosition();
        }

        public void ResetPosition()
        {
            Sprite.Top = -100; // Ставим выше экрана
            Sprite.Left = rand.Next(150, 560); // Случайная позиция по X
        }
    }
    
}
