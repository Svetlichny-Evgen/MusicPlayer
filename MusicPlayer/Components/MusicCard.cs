using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Components
{
    public partial class MusicCard : UserControl
    {
        private MusicCard()
        {
            InitializeComponent();
            HoverRecursive(musicCardArea);
        }

        public MusicCard(string file) : this() 
        { 
            var fileInfo = new FileInfo(file);
            Title = fileInfo.Name;
            DirectoryInfo directoryInfo = fileInfo.Directory;
            Singer = directoryInfo.Name;

            int indexLastPoint = Title.LastIndexOf(".");
            string filePath = Title.Substring(0, indexLastPoint);
            string pathImage = Path.Combine(fileInfo.DirectoryName!,"Images", filePath + ".jpg");

            if (File.Exists(pathImage))
            {
                Image = new Bitmap(pathImage);
            }
            else 
            {
                Image = Properties.Resources.audio;
            }
        }

        #region Properties
        public Image Image
        {
            get
            {
                return pbMusicImage.Image;
            }
            set
            {
                pbMusicImage.Image = value;
            }
        }
        public string Title
        {
            get
            {
                return lbMusicTitle.Text;
            }
            set
            {
                lbMusicTitle.Text = value;
            }
        }
        public string Singer
        {
            get
            {
                return lbSinger.Text;
            }
            set
            {
                lbSinger.Text = value;
            }
        }

        public string Source { get; set; }
        #endregion

        private void MusicCard_Enter(object? sender, EventArgs e)
        {
            musicCardArea.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void MusicCard_Leave(object? sender, EventArgs e)
        {
            musicCardArea.BackColor = Color.White;
        }

        private void HoverRecursive(Control panel)
        {
            panel.MouseEnter += MusicCard_Enter;
            panel.MouseLeave += MusicCard_Leave;
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var child = panel.Controls[i];
                HoverRecursive(child);
            }
        }
    }
}
