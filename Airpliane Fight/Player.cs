using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace YYPaplane
{
    public class Player
    {
        public Rectangle playerBox;

        private Texture2D playerTexture;
        private Texture2D _bulletTexture;

        public Vector2 playerPosition;
        private Vector2 healthPosition;

        private int playerSpeed;
        private int bulletDelay;
        public int health;

        public List<Bullet> playerBullets;

        private Sound sound;

        private SpriteFont spriteFont;

        public Player()
        {
            playerBullets = new List<Bullet>();
            playerTexture = null;
            playerPosition = new Vector2(315, 750);
            playerSpeed = 10;
            bulletDelay = 1;
            health = 100;
            healthPosition = new Vector2(10, 10);

            sound = new Sound();
        }
        
        public void LoadPlayer(ContentManager content)
        {
            playerTexture = content.Load<Texture2D>("ship");
            _bulletTexture = content.Load<Texture2D>("playerbullet");
            sound.LoadSound(content);
            spriteFont = content.Load<SpriteFont>("smallFont");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(Bullet b in playerBullets)
            {
                b.Draw(spriteBatch);
            }
            spriteBatch.Draw(playerTexture, playerPosition, Color.White);
            spriteBatch.DrawString(spriteFont, "HP: " + health, healthPosition, Color.White);
            //low health alarm
            if(health <= 20)
            {
                spriteBatch.DrawString(spriteFont, "HP: " + health, healthPosition, Color.Red);
            }
            else if (health <= 60)
            {
                spriteBatch.DrawString(spriteFont, "HP: " + health, healthPosition, Color.Orange);
            }
        }

        public void Update(GameTime gameTime)
        {
            playerBox = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, playerTexture.Width, playerTexture.Height);

            KeyboardState keyState = Keyboard.GetState();

            if(keyState.IsKeyDown(Keys.Space))
            {
                PlayerShoot();
            }
            RenewBullet();

            if(keyState.IsKeyDown(Keys.W))
            {
                playerPosition.Y -= playerSpeed;
            }
            if (keyState.IsKeyDown(Keys.S))
            {
                playerPosition.Y += playerSpeed;
            }
            if (keyState.IsKeyDown(Keys.A))
            {
                playerPosition.X -= playerSpeed;
            }
            if (keyState.IsKeyDown(Keys.D))
            {
                playerPosition.X += playerSpeed;
            }

            if(playerPosition.Y < 0)
            {
                playerPosition.Y = 0;
            }
            if(playerPosition.Y > 960 - playerTexture.Height)
            {
                playerPosition.Y = 960 - playerTexture.Height;
            }
            if(playerPosition.X < 0)
            {
                playerPosition.X = 0;
            }
            if(playerPosition.X > 720 - playerTexture.Width)
            {
                playerPosition.X = 720 - playerTexture.Width;
            }
        }

        public void PlayerShoot()
        {
            if(bulletDelay >= 0)
            {
                bulletDelay--;
            }
            if(bulletDelay == 0)
            {
                sound.playerShootSound.Play();
                Bullet shootingBullet = new Bullet(_bulletTexture);
                shootingBullet.bulletPosition = new Vector2(playerPosition.X + playerTexture.Width / 2 - shootingBullet.bulletTexture.Width / 2, playerPosition.Y + playerTexture.Height / 4);
                shootingBullet.isVisible = true;
                if(playerBullets.Count < 50)
                {
                    playerBullets.Add(shootingBullet);
                }
            }
            if(bulletDelay < 0)
            {
                bulletDelay = 7;
            }
        }

        public void RenewBullet()
        {
            foreach(Bullet b in playerBullets)
            {
                b.bulletBox = new Rectangle((int)b.bulletPosition.X, (int)b.bulletPosition.Y, b.bulletTexture.Width, b.bulletTexture.Height);
                b.bulletPosition.Y -= b.bulletSpeed;
                if(b.bulletPosition.Y <= 0)
                {
                    b.isVisible = false;
                }
            }
            for(int i = 0; i < playerBullets.Count; i++)
            {
                if(!playerBullets[i].isVisible)
                {
                    playerBullets.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
