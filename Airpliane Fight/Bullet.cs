using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace YYPaplane
{
    public class Bullet
    {
        public Rectangle bulletBox;
        public Texture2D bulletTexture;
        private Vector2 point;
        public Vector2 bulletPosition;
        public bool isVisible; //false when hit player's airplane
        public float bulletSpeed;

        public Bullet(Texture2D _texture)
        {
            bulletSpeed = 10;
            bulletTexture = _texture;
            isVisible = false;
        }
          
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bulletTexture, bulletPosition, Color.White);
        }
    }
}
