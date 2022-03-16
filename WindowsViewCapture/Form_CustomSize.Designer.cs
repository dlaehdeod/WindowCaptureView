
namespace WindowsViewCapture
{
    partial class Form_CustomSize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_move
            // 
            this.timer_move.Interval = 10;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // Form_CustomSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.MinimizeBox = false;
            this.Name = "Form_CustomSize";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "화면 캡쳐 (Pause 키로 껏다 켰다 가능합니다)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CustomSize_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_CustomSize_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_CustomSize_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_move;
    }
}