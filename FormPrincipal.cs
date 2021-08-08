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

        private readonly SoundPlayer player = new SoundPlayer
        {
            Stream = Properties.Resources.Basshunter_Dota
        };

        private void Principal_Load(object sender, EventArgs e)
        {
            Location = new System.Drawing.Point(0, 0);
            Width = Screen.PrimaryScreen.Bounds.Width;
            Height = Screen.PrimaryScreen.Bounds.Height;

            pb_Principal.Width = Screen.PrimaryScreen.Bounds.Width;
            pb_Principal.Height = Screen.PrimaryScreen.Bounds.Height;
        }

        private void NIPrincipal_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            NIPrincipal.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            player.PlayLooping();
        }
    }
}