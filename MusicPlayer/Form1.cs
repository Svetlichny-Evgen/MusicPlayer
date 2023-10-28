using MusicPlayer.Components;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SerchMusic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //for (int i = 4; i < 14; i++)
            //{
            //    PlayList list = new PlayList();
            //    list.Image = Properties.Resources.imageplaylist;
            //    list.Title = "Car MIX";
            //    list.Description = i + " Track";
            //    PlayListArea.Controls.Add(list);

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    MusicCard card = new MusicCard();
            //    card.Image = Properties.Resources.imageplaylist;
            //    card.Title = "Song #" + i;
            //    card.Singer = "Singer " + i;
            //    musicCardsArea.Controls.Add(card);
            //}
        }

        private void SerchMusic() 
        {
            string folderPath = Path.Combine("D:", "Music");

            if (Directory.Exists(folderPath))
            {
                //Здесь будет выгрузка плейлистов если папка существует
            }
            else
            {
                OpenFileOnFormLoad();
            }
        }
        private void OpenFileOnFormLoad()
        {
            MessageBox.Show("Похоже, мы не смогли найти вашу папку с музыкой😞.\nВыберите дерикторию где находится ваша музыка.");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
            }
            else 
            {
                this.Close();
            }
        }
    }
}