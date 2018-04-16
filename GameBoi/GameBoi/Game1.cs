using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameBoi
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private UserCharacter animatedSprite;
        private AnimatedSprite animatedSprite2;
        private AnimatedSprite animatedSprite3;
        bool falseTitle;
        Texture2D titleScreen;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            falseTitle = true;
        }


        protected override void Initialize()
        {

            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Texture2D texure = Content.Load<Texture2D>("Kevin hart moving");
            animatedSprite = new UserCharacter(texure, 5, 4, new Vector2(200, 200), 17,2);
            Texture2D texure2 = Content.Load<Texture2D>("SmileyWalk");
            animatedSprite2 = new AnimatedSprite(texure2, 4, 4, new Vector2(400, 200), 16, 1);
            Texture2D texture3 = Content.Load<Texture2D>("gold bar");
            animatedSprite3 = new AnimatedSprite(texture3, 2, 1, new Vector2(300, 200), 2, 10);
            titleScreen = Content.Load<Texture2D>("Title");
        }

       
       

        
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState(); 
            if (keyState.IsKeyDown(Keys.Escape))
                Exit();
     
            animatedSprite.Update(keyState, animatedSprite2);
            animatedSprite2.Update();
            animatedSprite3.Update();

         

             // screens
             if (falseTitle == true)
            {
                if (keyState.IsKeyDown(Keys.Space))
                {
                    falseTitle = false;
                }
            }
            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Aquamarine);
            animatedSprite.Draw(spriteBatch);
            animatedSprite2.Draw(spriteBatch);
            animatedSprite3.Draw(spriteBatch);
            spriteBatch.Begin();
           
            //titlescreen
           if (falseTitle == true)
            {
                spriteBatch.Draw(titleScreen, new Rectangle(0, 0, 800, 480), Color.White);
            }
            spriteBatch.End();

                base.Draw(gameTime);
        }
    }
}
