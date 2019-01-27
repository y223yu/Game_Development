using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace YYPaplane
{
    public class Enemy1
    {
        private Texture2D enemy1Texture;
        private Texture2D bulletTexture;

        public Rectangle enemy1Box;
        public Vector2 enemy1Position;

        private int enemy1Speed;
        public int enemy1Health;
        private int enemyBulletDelay;

        public bool isVisible; //determine if an enemy is hit by bullet
        public List<Bullet> enemyBullets;

        public Enemy1(Texture2D _texture, Vector2 _position, Texture2D _bulletTexture)
        {
            enemyBullets = new List<Bullet>();
            enemy1Texture = _texture;
            enemy1Position = _position;
            bulletTexture = _bulletTexture;
            enemy1Health = 100;
            enemyBulletDelay = 7;
            enemy1Speed = 5;
            isVisible = true;
        }

        public void Update(GameTime gameTime)
        {
            enemy1Box = new Rectangle((int)enemy1Position.X, (int)enemy1Position.Y, enemy1Texture.Width, enemy1Texture.Height);
            enemy1Position.Y += enemy1Speed;
            if(enemy1Position.Y >= 960)
            {
                isVisible = false;
            }
            Enemy1Shoot();
            RenewEnemy1Bullet();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(Bullet b in enemyBullets)
            {
                b.Draw(spriteBatch);
            }
            spriteBatch.Draw(enemy1Texture, enemy1Position, Color.White);
        }

        public void RenewEnemy1Bullet()
        {
            foreach(Bullet b in enemyBullets)
            {
                b.bulletBox = new Rectangle((int)b.bulletPosition.X, (int)b.bulletPosition.Y, b.bulletTexture.Width, b.bulletTexture.Height);
                b.bulletPosition.Y += 7; //speed of enemy's bullet
                if(b.bulletPosition.Y >= 960)
                {
                    b.isVisible = false;
                }
            }
            for(int i = 0; i < enemyBullets.Count; i++)
            {
                if(!enemyBullets[i].isVisible)
                {
                    enemyBullets.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Enemy1Shoot()
        {
            if(enemyBulletDelay >= 0)
            {
                enemyBulletDelay--;
            }
            if(enemyBulletDelay == 0)
            {
                Bullet shootingBullet = new Bullet(bulletTexture);
                shootingBullet.bulletPosition = new Vector2(enemy1Position.X + enemy1Texture.Width / 2 - shootingBullet.bulletTexture.Width / 2, enemy1Position.Y + 3 * enemy1Texture.Height / 4);
                shootingBullet.isVisible = true;
                if(enemyBullets.Count < 20)
                {
                    enemyBullets.Add(shootingBullet);
                }
                if(enemyBulletDelay < 0)
                {
                    enemyBulletDelay = 7; //70
                }
            }
        }
    }
}
