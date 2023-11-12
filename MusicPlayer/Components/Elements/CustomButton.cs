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
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        private void buttonImage_MouseHover(object sender, EventArgs e)
        {
            Padding = new Padding(0);
        }

        private void buttonImage_MouseLeave(object sender, EventArgs e)
        {
            Padding = new Padding(2);
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        public Image Image
        {
            get
            {
                return buttonImage.Image;
            }
            set
            {
                buttonImage.Image = value;
            }
        }
    }
}
