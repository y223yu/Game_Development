using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace YYPaplane
{
    public class Explosion
    {
        private Texture2D explosionTexture;
        private Vector2 explosionPosition;
        private Vector2 origin;

        private float explosionTimer;
        private float explosionInterval;

        private int currentFrame;
        private int spriteWidth;
        private int spriteHeight;

        private Rectangle explosionBox;
        public bool isVisible;

        public Explosion(Texture2D _texture, Vector2 _position)
        {
            explosionPosition = _position;
            explosionTexture = _texture;
            explosionTimer = 0f;
            explosionInterval = 0f;
            currentFrame = 1;
            spriteWidth = 128;
            spriteHeight = 128;
            isVisible = true;
        }

        public void LoadExplosion(ContentManager content)
        {
        }

        public void Update(GameTime gameTime)
        {
            explosionTimer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            if(explosionTimer > explosionInterval)
            {
                currentFrame++;
                explosionTimer = 0f;
            }
            if(currentFrame == 17)
            {
                isVisible = false;
                currentFrame = 0;
            }
            explosionBox = new Rectangle(currentFrame * spriteWidth, 0, spriteWidth, spriteHeight);
            origin = new Vector2(explosionBox.Width / 2, explosionBox.Height / 2);
            
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(isVisible)
            {
                spriteBatch.Draw(explosionTexture, explosionPosition, explosionBox, Color.White, 0f, origin, 0.6f, SpriteEffects.None, 0);
            }
        }
    }
}
