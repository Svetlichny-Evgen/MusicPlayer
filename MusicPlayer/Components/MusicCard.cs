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
        public MusicCard()
        {
            InitializeComponent();
            HoverRecursive(musicCardArea);
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
