﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
namespace GameBoi
{
    public class AnimatedSprite
    {
        private int frameSlowDown;
        private int frameSlowRate;
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        public Vector2 location;
        public AnimatedSprite(Texture2D texture, int rows, int columns,Vector2 Location, int TotalFrames, int slowDownRate)
        {
            frameSlowDown = slowDownRate;
            Texture = texture;
            frameSlowRate = slowDownRate;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = TotalFrames;
            location = Location;
        }
        public void Update()
        {
            frameSlowDown--;
            if (frameSlowDown == 0)
            {
                frameSlowDown = frameSlowRate;
                currentFrame++;
                if (currentFrame == totalFrames)
                    currentFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch) {  
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}

