using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    // Базовый класс для игровых объектов
    public class GameEntity
    {
        public PictureBox Sprite { get; set; }

        public GameEntity(PictureBox sprite)
        {
            Sprite = sprite;
        }

        public virtual void Move(int speed)
        {
            Sprite.Top += speed;
        }

        public Rectangle Bounds => Sprite.Bounds;
    }
}

