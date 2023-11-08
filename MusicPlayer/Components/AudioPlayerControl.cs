using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MusicPlayer.Components
{
    public partial class AudioPlayerControl : UserControl
    {

        WaveOut wave;
        AudioFileReader? audio;
        public AudioPlayerControl()
        {
            InitializeComponent();
            trackBar.ChangeValue += TrackBar_ChangeValue;
            trackBar.Value = 0.0f;
        }

        private void TrackBar_ChangeValue(object? sender, float e)
        {
            if (audio != null)
            {
                audio.CurrentTime = TimeSpan.FromSeconds(e);
            }
        }
        public void Play(MusicCard card)
        {

            if (wave != null)
            {
                wave.Dispose();
                audio?.Dispose();
            }

            wave = new WaveOut();
            audio = new AudioFileReader(card.Source);
            trackBar.Max = (float)audio.TotalTime.TotalSeconds;
            TimeSpan end = audio.TotalTime;
            endTime.Text = $"{end:mm}:{end:ss}";

            audio.Volume = 0.5f;
            wave.Init(audio);
            wave.Play();


        }
        private void audioTimer_Tick(object sender, EventArgs e)
        {
            if (audio != null)
            {
                TimeSpan current = audio.CurrentTime;
                currentTime.Text = $"{current:mm}:{current:ss}";
                trackBar.Value = (float)audio.CurrentTime.TotalSeconds;
            }
        }
    }
}
