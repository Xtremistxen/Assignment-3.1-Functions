using System.Media;

namespace Characterstatgui
{
    public static class MusicManager
    {
        private static SoundPlayer player;

        // Play main game music
        public static void PlayMainTheme()
        {
            Stop();

            player = new SoundPlayer(Properties.Resources.MainTheme);
            player.PlayLooping();
        }

        // Play puzzle music
        public static void PlayPuzzleTheme()
        {
            Stop();

            player = new SoundPlayer(Properties.Resources.PuzzleTheme);
            player.PlayLooping();
        }

        // Stop current music
        public static void Stop()
        {
            if (player != null)
                player.Stop();
        }
    }
}


