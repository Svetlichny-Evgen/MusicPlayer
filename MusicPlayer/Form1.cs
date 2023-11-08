using MusicPlayer.Components;
using NAudio.Wave;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        string folderPath = Path.Combine("D:", "Music");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath))
            {
                OpenFileOnFormLoad();
            }
            string[] dirs = Directory.GetDirectories(folderPath);
            foreach (string dir in dirs)
            {
                var playlist = new PlayList(dir);
                playlist.OpenPlayList += Playlist_OpenPlayList;
                PlayListArea.Controls.Add(playlist);
            }
        }

        private void Playlist_OpenPlayList(object? sender, EventArgs e)
        {
            PlayList? playlist = sender as PlayList;
            if (playlist != null)
            {
                OpenPlayList(playlist);
            }
        }

        private void OpenPlayList(PlayList playlist)
        {
            musicCardsArea.Controls.Clear();
            string[] tracks = Directory.GetFiles(playlist.Source, "*.mp3");
            foreach (var track in tracks)
            {
                var card = new MusicCard(track);
                card.PlayTrack += Card_PlayTrack;
                musicCardsArea.Controls.Add(card);
            }
        }

        
        private void Card_PlayTrack(object? sender, EventArgs e)
        {
            if (sender is MusicCard card)
            {
                audioPlayerControl1.Play(card);
            }
            
           
        }

        private void OpenFileOnFormLoad()
        {
            MessageBox.Show("Похоже, мы не смогли найти вашу папку с музыкой😞.\nВыберите дерикторию где находится ваша музыка.");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
            else
            {
                this.Close();
            }
        }
    }
}