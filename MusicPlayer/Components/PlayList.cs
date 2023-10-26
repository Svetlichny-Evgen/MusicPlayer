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
            HoverRecursive(PanelHaupt);
        }
        #region        
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
        #endregion





        private void PanelHaupt_MouseEnter(object sender, EventArgs e)
        {
            PanelHaupt.BackColor = Color.FromArgb(217, 217, 217);
        }

        private void PanelHaupt_MouseLeave(object sender, EventArgs e)
        {
            PanelHaupt.BackColor = Color.White;
        }
        private void HoverRecursive(Control panel)
        {
            panel.MouseEnter += PanelHaupt_MouseEnter;
            panel.MouseLeave += PanelHaupt_MouseLeave;
            for(int i = 0; i < panel.Controls.Count; i++) 
            {
                var child = panel.Controls[i];  
                HoverRecursive(child);
            }
            
        }
    }
}
