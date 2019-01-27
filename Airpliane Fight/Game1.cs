using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.IO;

namespace YYPaplane
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public string[] menuOptions = new string[] { "Start", "How to Play", "Help", "About", "High Score", "Exit" };
        public string[] levels = new string[] { "Easy", "Normal", "Difficult" };

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player = new Player();

        Background background = new Background();

        //public SoundEffect explosionSound;
        //SoundEffectInstance sfx;
        Sound sound = new Sound();

        List<Enemy1> enemy1List = new List<Enemy1>(); //used to generate enemies

        HUD hud = new HUD();

        List<Explosion> explosionList = new List<Explosion>(); //used to generate explosion animation

        Random random = new Random(); //used to give random position for enemies

        GameScene gameScene = new GameScene();

        Texture2D howToPlayScene;
        Texture2D helpScene;
        Texture2D aboutScene;
        
        SpriteFont scoreFont;
        SpriteFont menuRegularFont;
        SpriteFont menuHilightFont;

        public KeyboardState oldKeyStateMenu;
        public KeyboardState oldKeyStateLevel;
        int optionIndex = 0; //use to indicate an option in menu
        int levelIndex = 0; //use to indicate a level

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 960;
            graphics.PreferredBackBufferWidth = 720; 
            this.Window.Title = "YYPaplane";
            gameScene = GameScene.Menu; //display the menu when load the game
            this.IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {

            // TODO: Add your initialization logic here
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player.LoadPlayer(Content);
            background.LoadBackground(Content);
            hud.LoadHUD(Content);
            sound.LoadSound(Content);
            howToPlayScene = Content.Load<Texture2D>("howtoplay");
            helpScene = Content.Load<Texture2D>("help");
            aboutScene = Content.Load<Texture2D>("about");
            scoreFont = Content.Load<SpriteFont>("smallFont");
            menuRegularFont = Content.Load<SpriteFont>("regularFont");
            menuHilightFont = Content.Load<SpriteFont>("hilightFont");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //    Exit();

            // TODO: Add your update logic here
            switch (gameScene)
            {
                case GameScene.Menu:
                    {                        
                        KeyboardState kMenu = Keyboard.GetState();
                        ////two if: determine which option has been selected
                        if (kMenu.IsKeyDown(Keys.Down) && oldKeyStateMenu.IsKeyUp(Keys.Down))
                        {
                            optionIndex++;
                            if (optionIndex >= menuOptions.Length)
                            {
                                optionIndex = 0;
                            }
                        }
                        if (kMenu.IsKeyDown(Keys.Up) && oldKeyStateMenu.IsKeyUp(Keys.Up))
                        {
                            optionIndex--;
                            if (optionIndex == -1)
                            {
                                optionIndex = menuOptions.Length - 1;
                            }
                        }
                        oldKeyStateMenu = kMenu;

                        //choose an option
                        if (optionIndex == 0 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            gameScene = GameScene.Level;
                        }
                        else if (optionIndex == 1 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            gameScene = GameScene.HowtoPlay;
                        }
                        else if (optionIndex == 2 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            gameScene = GameScene.Help;
                        }
                        else if (optionIndex == 3 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            gameScene = GameScene.About;
                        }
                        else if (optionIndex == 4 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            gameScene = GameScene.HighScore;
                        }
                        else if (optionIndex == 5 && kMenu.IsKeyDown(Keys.Enter))
                        {
                            this.Exit();
                        }
                        background.backgroundSpeed = 1; //let the background move slowly
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.Level:
                    {
                        hud.InitializeHighScoreFile();
                        KeyboardState kLevel = Keyboard.GetState();
                        if (kLevel.IsKeyDown(Keys.Down) && oldKeyStateLevel.IsKeyUp(Keys.Down))
                        {
                            levelIndex++;
                            if (levelIndex >= levels.Length)
                            {
                                levelIndex = 0;
                            }
                        }
                        if (kLevel.IsKeyDown(Keys.Up) && oldKeyStateLevel.IsKeyUp(Keys.Up))
                        {
                            levelIndex--;
                            if (levelIndex == -1)
                            {
                                levelIndex = levels.Length - 1;
                            }
                        }
                        oldKeyStateLevel = kLevel;

                        
                        if (levelIndex == 0 && kLevel.IsKeyDown(Keys.Space))
                        {
                            hud.difficulty = Levels.Easy;
                            hud.LoadHighScoreEasy();
                            gameScene = GameScene.Play;
                            MediaPlayer.Play(sound.backgroundMusic);
                            MediaPlayer.IsRepeating = true;
                        }
                        else if (levelIndex == 1 && kLevel.IsKeyDown(Keys.Space))
                        {
                            hud.difficulty = Levels.Normal;
                            hud.LoadHighScoreMedium();
                            gameScene = GameScene.Play;
                            MediaPlayer.Play(sound.backgroundMusic);
                            MediaPlayer.IsRepeating = true;
                        }
                        else if (levelIndex == 2 && kLevel.IsKeyDown(Keys.Space))
                        {
                            hud.difficulty = Levels.Difficult;
                            hud.LoadHighScoreHard();
                            gameScene = GameScene.Play;
                            MediaPlayer.Play(sound.backgroundMusic);
                            MediaPlayer.IsRepeating = true;
                        }

                        if (kLevel.IsKeyDown(Keys.R))
                        {
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.Play:
                    {
                        background.backgroundSpeed = 5;
                        foreach(Enemy1 e in enemy1List)
                        {
                            for(int i = 0; i < e.enemyBullets.Count; i++)
                            {
                                //detect player's airplane is hit by enemy's bullet
                                if(player.playerBox.Intersects(e.enemyBullets[i].bulletBox))
                                {
                                    e.enemyBullets[i].isVisible = false;
                                    if(hud.difficulty == Levels.Normal || hud.difficulty == Levels.Easy)
                                    {
                                        player.health -= 10;
                                    }
                                    if(hud.difficulty == Levels.Difficult)
                                    {
                                        player.health -= 20;
                                    }
                                }
                            }
                            //detect player's airplane is hit by enemy's ship
                            if (player.playerBox.Intersects(e.enemy1Box))
                            {
                                e.isVisible = false;
                                if (hud.difficulty == Levels.Normal || hud.difficulty == Levels.Easy)
                                {
                                    player.health -= 10;
                                }
                                if (hud.difficulty == Levels.Difficult)
                                {
                                    player.health -= 20;
                                }
                            }

                            //enemy explosion effect
                            for(int j = 0; j < player.playerBullets.Count; j++)
                            {
                                if(e.enemy1Box.Intersects(player.playerBullets[j].bulletBox))
                                {
                                    explosionList.Add(new Explosion(Content.Load<Texture2D>("explosion"), new Vector2(e.enemy1Position.X, e.enemy1Position.Y)));
                                    player.playerBullets[j].isVisible = false;
                                    if(hud.difficulty == Levels.Easy)
                                    {
                                        e.enemy1Health -= 100;
                                    }
                                    if(hud.difficulty == Levels.Normal || hud.difficulty == Levels.Difficult)
                                    {
                                        e.enemy1Health -= 50;
                                    }
                                }
                            }
                            if(e.enemy1Health <= 0) //enemy is destroyed
                            {
                                sound.explosionSound.Play();
                                e.isVisible = false;
                                hud.playerScore += 10;
                            }
                            e.Update(gameTime);
                        }
                        foreach(Explosion exps in explosionList)
                        {
                            exps.Update(gameTime);
                        }
                        player.Update(gameTime);
                        background.Update(gameTime);
                        LoadEnemies();
                        RunExplosions();

                        //record high-score into txt file
                        if(player.health <= 0)
                        {
                            if(hud.difficulty == Levels.Easy)
                            {
                                StreamWriter sw = new StreamWriter("highscoreEasy.txt");
                                if(hud.highScoreEasy < hud.playerScore)
                                {
                                    hud.highScoreEasy = hud.playerScore;
                                    sw.WriteLine(hud.playerScore);
                                }
                                sw.Close();
                            }
                            if (hud.difficulty == Levels.Normal)
                            {
                                StreamWriter sw = new StreamWriter("highscoreMedium.txt");
                                if (hud.highScoreMedium < hud.playerScore)
                                {
                                    hud.highScoreMedium = hud.playerScore;
                                    sw.WriteLine(hud.playerScore);
                                }
                                sw.Close();
                            }
                            if (hud.difficulty == Levels.Difficult)
                            {
                                StreamWriter sw = new StreamWriter("highscoreHard.txt");
                                if (hud.highScoreHard < hud.playerScore)
                                {
                                    hud.highScoreHard = hud.playerScore;
                                    sw.WriteLine(hud.playerScore);
                                }
                                sw.Close();
                            }
                            gameScene = GameScene.GameOver;
                        }
                        break;
                    }
                case GameScene.HowtoPlay:
                    {
                        KeyboardState kHowToPlay = Keyboard.GetState();
                        if(kHowToPlay.IsKeyDown(Keys.R))
                        {
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.Help:
                    {
                        KeyboardState kHelp = Keyboard.GetState();
                        if (kHelp.IsKeyDown(Keys.R))
                        {
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.About:
                    {
                        KeyboardState kAbout = Keyboard.GetState();
                        if (kAbout.IsKeyDown(Keys.R))
                        {
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.HighScore:
                    {
                        KeyboardState kHighScore = Keyboard.GetState();
                        if(kHighScore.IsKeyDown(Keys.R))
                        {
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        break;
                    }
                case GameScene.GameOver: //press R to main menu (re-set game properties)
                    {
                        KeyboardState kGameOver = Keyboard.GetState();
                        if(kGameOver.IsKeyDown(Keys.R))
                        {
                            player.playerPosition = new Vector2(315, 750);
                            enemy1List.Clear();
                            player.health = 100;
                            hud.playerScore = 0;
                            gameScene = GameScene.Menu;
                        }
                        background.backgroundSpeed = 1;
                        background.Update(gameTime);
                        MediaPlayer.Stop();
                        break;
                    }
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            switch(gameScene)
            {
                case GameScene.Menu:
                    {
                        background.Draw(spriteBatch);
                        //the Options change color when been selected
                        for (int i = 0; i < 6; i++)
                        {
                            if (i == optionIndex)
                            {
                                spriteBatch.DrawString(menuHilightFont, menuOptions[i], new Vector2(10, 270 + (70 * i)), Color.Black);
                            }
                            else
                            {
                                spriteBatch.DrawString(menuRegularFont, menuOptions[i], new Vector2(10, 270 + (70 * i)), Color.Gray);
                            }
                        }
                        spriteBatch.DrawString(Content.Load<SpriteFont>("smallFont"), "Press Enter to choose", new Vector2(10, 800), Color.Black);
                        break;
                    }
                case GameScene.Level:
                    {
                        background.Draw(spriteBatch);
                        for(int i = 0; i < 3; i++)
                        {
                            if(i == levelIndex)
                            {
                                spriteBatch.DrawString(menuHilightFont, levels[i], new Vector2(10, 270 + (100 * i)), Color.Black);
                            }
                            else
                            {
                                spriteBatch.DrawString(menuRegularFont, levels[i], new Vector2(10, 270 + (100 * i)), Color.Gray);
                            }
                        }
                        spriteBatch.DrawString(Content.Load<SpriteFont>("smallFont"), "Press Space to choose", new Vector2(10, 800), Color.Black);
                        spriteBatch.DrawString(Content.Load<SpriteFont>("smallFont"), "Press R to Main Menu", new Vector2(10, 870), Color.Black);
                        break;
                    }
                case GameScene.Play:
                    {
                        background.Draw(spriteBatch); //generate background
                        player.Draw(spriteBatch); //generate player's airplane
                        foreach(Enemy1 e in enemy1List) 
                        {
                            e.Draw(spriteBatch);
                        }
                        foreach(Explosion exps in explosionList)
                        {
                            exps.Draw(spriteBatch);
                        }
                        hud.Draw(spriteBatch);
                        break;
                    }
                case GameScene.HowtoPlay:
                    {
                        background.Draw(spriteBatch);
                        spriteBatch.Draw(howToPlayScene, new Vector2(0, 5), Color.White);
                        spriteBatch.DrawString(scoreFont, "Press R to Main Menu", new Vector2(200, 770), Color.Black);
                        break;
                    }
                case GameScene.Help:
                    {
                        background.Draw(spriteBatch);
                        spriteBatch.Draw(helpScene, new Vector2(0, 70), Color.White);
                        spriteBatch.DrawString(scoreFont, "Press R to Main Menu", new Vector2(200, 770), Color.Black);
                        break;
                    }
                case GameScene.About:
                    {
                        background.Draw(spriteBatch);
                        spriteBatch.Draw(aboutScene, new Vector2(0, 70), Color.White);
                        spriteBatch.DrawString(scoreFont, "Press R to Main Menu", new Vector2(200, 770), Color.Black);
                        break;
                    }
                case GameScene.HighScore:
                    {
                        background.Draw(spriteBatch);

                        hud.LoadHighScoreEasy();
                        spriteBatch.DrawString(scoreFont, "Level: Easy", new Vector2(230, 210), Color.DarkGreen);
                        spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreEasy, new Vector2(230, 280), Color.DarkGreen);

                        hud.LoadHighScoreMedium();
                        spriteBatch.DrawString(scoreFont, "Level: Normal", new Vector2(230, 350), Color.DarkBlue);
                        spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreMedium, new Vector2(230, 420), Color.DarkBlue);

                        hud.LoadHighScoreHard();
                        spriteBatch.DrawString(scoreFont, "Level: Difficult", new Vector2(230, 490), Color.DarkRed);
                        spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreHard, new Vector2(230, 560), Color.DarkRed);

                        spriteBatch.DrawString(scoreFont, "Press R to Main Menu", new Vector2(200, 770), Color.Black);
                        break;
                    }
                case GameScene.GameOver:
                    {
                        background.Draw(spriteBatch);
                        spriteBatch.DrawString(menuRegularFont, "Game Over", new Vector2(150, 70), Color.Gray);
                        spriteBatch.DrawString(scoreFont, "Your score: " + hud.playerScore, new Vector2(230, 350), Color.White);
                        if(hud.difficulty == Levels.Easy)
                        {
                            spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreEasy, new Vector2(230, 420), Color.White);
                        }
                        if (hud.difficulty == Levels.Normal)
                        {
                            spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreMedium, new Vector2(230, 420), Color.White);
                        }
                        if (hud.difficulty == Levels.Difficult)
                        {
                            spriteBatch.DrawString(scoreFont, "High score: " + hud.highScoreHard, new Vector2(230, 420), Color.White);
                        }
                        spriteBatch.DrawString(scoreFont, "Level: " + hud.difficulty.ToString(), new Vector2(260, 490), Color.White);
                        spriteBatch.DrawString(scoreFont, "Press R to Main Menu", new Vector2(200, 770), Color.Black);
                        break;
                    }
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void LoadEnemies()
        {
            int n;
            int randomX = random.Next(0, 620); //horizontal range of position
            int randomY = random.Next(-1000, -150); //vertical range that enemies appear of every wave
            if (hud.difficulty == Levels.Easy || hud.difficulty == Levels.Normal)
            {
                n = 15; //number of enemies every wave
            }
            else
            {
                n = 25; //number of enemies every wave
            }
            if(enemy1List.Count < n)
            {
                enemy1List.Add(new Enemy1(Content.Load<Texture2D>("enemy1"), 
                    new Vector2(randomX, randomY), 
                    Content.Load<Texture2D>("enemybullet")));
            }
            for(int i = 0; i < enemy1List.Count; i++)
            {
                if(!enemy1List[i].isVisible)
                {
                    enemy1List.RemoveAt(i);
                    i--;
                }
            }
        }

        public void RunExplosions()
        {
            for(int i = 0; i < explosionList.Count; i++)
            {
                if(!explosionList[i].isVisible)
                {
                    explosionList.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
