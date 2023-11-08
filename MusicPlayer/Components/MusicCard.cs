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
        private EventHandler? playTrack;
        private MusicCard()
        {
            InitializeComponent();
            HoverRecursive(musicCardArea);
            ClickRecursive(musicCardArea);
        }

        public MusicCard(string file) : this()
        {
            Source = file;
            var fileInfo = new FileInfo(file);
            Title = fileInfo.Name;
            DirectoryInfo directoryInfo = fileInfo.Directory;
            Singer = directoryInfo.Name;

            int indexLastPoint = Title.LastIndexOf(".");
            string filePath = Title.Substring(0, indexLastPoint);
            string pathImage = Path.Combine(fileInfo.DirectoryName!, "Images", filePath + ".jpg");

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
        #region Hover
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
        #endregion
        #region Click
        private void ClickRecursive(Control panel)
        {
            panel.MouseClick += Panel_MouseClick;


            for (int i = 0; i < panel.Controls.Count; i++)
            {
                var child = panel.Controls[i];
                ClickRecursive(child);
            }

        }

        private void Panel_MouseClick(object? sender, MouseEventArgs e)
        {
            playTrack?.Invoke(this, e);
        }

        public event EventHandler PlayTrack
        {
            add { playTrack += value; }
            remove { playTrack -= value; }
        }
        #endregion
    }
}
