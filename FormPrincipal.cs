using System;
using System.Media;
using System.Windows.Forms;

namespace RicardoMilosTrap
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer
            {
                Stream = Properties.Resources.Basshunter___Dota
            };
            player.PlayLooping();

            Location = new System.Drawing.Point(0, 0);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            pb_Principal.Width = Width;
            pb_Principal.Height = Height;
        }
    }
}