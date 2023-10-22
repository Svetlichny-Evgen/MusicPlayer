using MusicPlayer.Components;
using System.ComponentModel.DataAnnotations;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 4; i < 14; i++)
            {
                PlayList list = new PlayList();
                list.Image = Properties.Resources.imageplaylist;
                list.Title = "Car MIX";
                list.Description = i + " Track";
                PlayListArea.Controls.Add(list);

            }
            
        }
    }
}