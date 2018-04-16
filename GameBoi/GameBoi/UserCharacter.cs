using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace GameBoi
{
    public class UserCharacter : AnimatedSprite
    {

        public UserCharacter(Texture2D texture, int rows, int columns, Vector2 Location, int TotalFrames, int slowDownRate)
            : base(texture, rows, columns, Location, TotalFrames, slowDownRate)
        {

        }

        public void Update(KeyboardState keyState,AnimatedSprite animatedSprite)
        {
            for (int i = 0; i < 2; i++)
            {
                int prevY = hitbox.Y;
                int prevX = hitbox.X;
                if (keyState.IsKeyDown(Keys.W))
                {
                    hitbox.Y--;
                }
                if (keyState.IsKeyDown(Keys.S))
                {
                    hitbox.Y++;
                }
                if (keyState.IsKeyDown(Keys.A))
                {
                    hitbox.X--;
                }
                if (keyState.IsKeyDown(Keys.D))
                {
                    hitbox.X++;
                }
                //collision
                if (hitbox.Intersects(animatedSprite.hitbox))
                {
                    hitbox.Y = prevY;
                    hitbox.X = prevX;
                }
            }
            base.Update();
        }
    }
}
