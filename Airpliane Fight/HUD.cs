using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;

namespace YYPaplane
{
    public class HUD
    {
        public int playerScore;
        public int highScoreEasy;
        public int highScoreMedium;
        public int highScoreHard;

        private SpriteFont scoreSpriteFont;
        private Vector2 scorePosition;
        public Levels difficulty = new Levels();

        public HUD()
        {
            playerScore = 0;
            scoreSpriteFont = null;
            scorePosition = new Vector2(10, 50);
        }

        public void LoadHUD(ContentManager content)
        {
            scoreSpriteFont = content.Load<SpriteFont>("smallFont");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(scoreSpriteFont, "Score: " + playerScore, scorePosition, Color.White);
        }

        //create new file with 0 score
        public void InitializeHighScoreFile()
        {
            if (!File.Exists("highscoreEasy.txt"))
            {
                File.WriteAllText("highscoreEasy.txt", "0");
            }
            if (!File.Exists("highscoreMedium.txt"))
            {
                File.WriteAllText("highscoreMedium.txt", "0");
            }
            if (!File.Exists("highscoreHard.txt"))
            {
                File.WriteAllText("highscoreHard.txt", "0");
            }
        }

        public void LoadHighScoreEasy()
        {
            if (File.Exists("highscoreEasy.txt"))
            {
                if(String.IsNullOrEmpty(File.ReadAllText("highscoreEasy.txt")))
                {
                    highScoreEasy = 0;
                }
                else
                {
                    highScoreEasy = int.Parse(File.ReadAllText("highscoreEasy.txt"));
                }
            }
        }
        public void LoadHighScoreMedium()
        {
            if (File.Exists("highscoreMedium.txt"))
            {
                if(String.IsNullOrEmpty(File.ReadAllText("highscoreMedium.txt")))
                {
                    highScoreMedium = 0;
                }
                else
                {
                    highScoreMedium = int.Parse(File.ReadAllText("highscoreMedium.txt"));
                }
            }
        }
        public void LoadHighScoreHard()
        {
            if (File.Exists("highscoreHard.txt"))
            {
                if(String.IsNullOrEmpty(File.ReadAllText("highscoreHard.txt")))
                {
                    highScoreHard = 0;
                }
                else
                {
                    highScoreHard = int.Parse(File.ReadAllText("highscoreHard.txt"));
                }
            }
        }
    }
}
