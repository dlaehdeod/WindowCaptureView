using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsViewCapture
{
    public partial class Form_ScreenEffect : Form
    {
        private double time;

        public Form_ScreenEffect()
        {
            InitializeComponent();
        }

        private void timer_fadeOut_Tick(object sender, EventArgs e)
        {
            time -= 0.1;
            this.Opacity = Math.Max(0, time);

            if (time <= 0)
            {
                timer_fadeOut.Stop();
                Hide();
            }
        }

        public void Initialize (int width, int height, int x, int y, bool showSaveEffect)
        {
            this.Size = new Size(width, height);
            this.Location = new Point(x, y);

            if (showSaveEffect)
            {
                this.Opacity = 0.5;
            }
            else
            {
                this.Opacity = 0;
            }

            time = this.Opacity;
            timer_fadeOut.Start();
        }
    }
}
