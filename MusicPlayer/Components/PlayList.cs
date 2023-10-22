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
    public partial class PlayList : UserControl
    {
        public PlayList()
        {
            InitializeComponent();
        }
        public Image Image
        {
            get
            {
                return pictureList.Image;
            }
            set
            {
                pictureList.Image = value;
            }

        }
        public string Title
        {
            get
            {
                return TextPlaylistName.Text;
            }
            set
            {
                TextPlaylistName.Text = value;
            }

        }
        public string Description
        {
            get
            {
                return TextDiscription.Text;
            }
            set
            {
                TextDiscription.Text = value;
            }

        }


    }
}
