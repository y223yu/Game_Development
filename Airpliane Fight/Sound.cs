using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

namespace YYPaplane
{
    public class Sound
    {
        public SoundEffect playerShootSound;
        public SoundEffect explosionSound;
        public Song backgroundMusic;
        
        public Sound()
        {
            playerShootSound = null;
            explosionSound = null;
            backgroundMusic = null;
        }

        public void LoadSound(ContentManager content)
        {
            playerShootSound = content.Load<SoundEffect>("soundplayershoot");
            explosionSound = content.Load<SoundEffect>("soundexplosion");
            backgroundMusic = content.Load<Song>("soundbackgroundmusic");
        }
    }
}
