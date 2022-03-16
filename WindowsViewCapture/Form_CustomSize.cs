using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsViewCapture
{
    public partial class Form_CustomSize : Form
    {
        private int offsetX;
        private int offsetY;

        private bool customRange;

        public Form_CustomSize()
        {
            InitializeComponent();
        }

        public new void Show ()
        {
            base.Show();
            customRange = true;
        }

        public void ToggleView ()
        {
            if (!customRange)
            {
                Form_Main.customRange = true;
                Show();
            }
            else
            {
                Form_Main.customRange = false;
                Hide();
            }

            customRange = Form_Main.customRange;
        }

        private void Form_CustomSize_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Form_Main.customRange = false;
            e.Cancel = true;
        }

        private void timer_move_Tick(object sender, EventArgs e)
        {
            Location = new Point(Cursor.Position.X - offsetX, Cursor.Position.Y - offsetY);
        }

        private void Form_CustomSize_MouseDown(object sender, MouseEventArgs e)
        {
            offsetX = Cursor.Position.X - Location.X;
            offsetY = Cursor.Position.Y - Location.Y;

            timer_move.Start();
        }

        private void Form_CustomSize_MouseUp(object sender, MouseEventArgs e)
        {
            timer_move.Stop();
        }
    }
}
