using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace YYPaplane
{
    public class Background
    {
        private Texture2D backgroundTexture;
        private Vector2 backgroundPosition1;
        private Vector2 backgroundPosition2;
        public int backgroundSpeed;

        public Background()
        {
            backgroundTexture = null;
            backgroundPosition1 = new Vector2(0, -1);
            backgroundPosition2 = new Vector2(0, -960); //(0, -640)
            backgroundSpeed = 5;
        }

        public void LoadBackground(ContentManager content)
        {
            backgroundTexture = content.Load<Texture2D>("background");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(backgroundTexture, backgroundPosition1, Color.White);
            spriteBatch.Draw(backgroundTexture, backgroundPosition2, Color.White);
        }

        public void Update(GameTime gameTime)
        {
            backgroundPosition1.Y = backgroundPosition1.Y + backgroundSpeed;
            backgroundPosition2.Y = backgroundPosition2.Y + backgroundSpeed;
            if(backgroundPosition1.Y >= 640)
            {
                backgroundPosition1.Y = -1;
                backgroundPosition2.Y = -640;
            }
        }
    }
}
