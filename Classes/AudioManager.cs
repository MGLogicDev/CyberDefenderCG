using System;
using System.IO;
using System.Windows.Media;

namespace Cyber_DefenderTCG.Classes
{
    public static class AudioManager
    {
        private static MediaPlayer bgmPlayer = new MediaPlayer();
        private static MediaPlayer sfxPlayer = new MediaPlayer(); 

        private static double _masterVolume = 1.0;
        private static double _bgmVolume = 0.5;
        private static bool isLoaded = false;

        public static double MasterVolume
        {
            get => _masterVolume;
            set
            {
                _masterVolume = value;
                UpdateVolumes();
            }
        }

        public static double BGMVolume
        {
            get => _bgmVolume;
            set
            {
                _bgmVolume = value;
                UpdateVolumes();
            }
        }
        private static void UpdateVolumes()
        {
            bgmPlayer.Volume = _bgmVolume * _masterVolume;
            sfxPlayer.Volume = _masterVolume;
        }

        public static void LoadAllSounds()
        {
            if(isLoaded) return;
            try
            {
                string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
                string bgmFile = Path.Combine(assetsPath, "cyberpunk-street.wav");

                if (File.Exists(bgmFile))
                {
                    bgmPlayer.Open(new Uri(bgmFile));
                    // Loop logic
                    bgmPlayer.MediaEnded += (s, e) => {
                        bgmPlayer.Position = TimeSpan.Zero;
                        bgmPlayer.Play();
                    };

                    UpdateVolumes();
                    isLoaded = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio Init Error: " + ex.Message);
            }

        }
        public static void PlayBGMusic()
        {
            UpdateVolumes();
            bgmPlayer.Play();
        }
        public static void StopBGMusic() => bgmPlayer.Stop();


        private static void PlaySFX(string fileName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", fileName);
            if (File.Exists(filePath))
            {
                sfxPlayer.Open(new Uri(filePath));
                sfxPlayer.Volume = _masterVolume;
                sfxPlayer.Play();
            }
        }

        public static void PlayClick() => PlaySFX("pop_1.wav");
        public static void PlayCancel() => PlaySFX("cancel.wav");
        public static void PlayCorrect() => PlaySFX("Correct.wav");
        public static void PlayIncorrect() => PlaySFX("Incorrect.wav");
        public static void PlayGameOver() => PlaySFX("lose.wav");
        public static void PlayVictory() => PlaySFX("win.wav");

    }
}