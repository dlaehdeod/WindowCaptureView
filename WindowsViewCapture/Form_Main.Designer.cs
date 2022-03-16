
namespace WindowsViewCapture
{
    partial class Form_Main
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
            this.button_option = new System.Windows.Forms.Button();
            this.button_minimum = new System.Windows.Forms.Button();
            this.label_prtsc = new System.Windows.Forms.Label();
            this.button_customSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_option
            // 
            this.button_option.Location = new System.Drawing.Point(2, 67);
            this.button_option.Name = "button_option";
            this.button_option.Size = new System.Drawing.Size(80, 30);
            this.button_option.TabIndex = 1;
            this.button_option.Text = "옵션";
            this.button_option.UseVisualStyleBackColor = true;
            this.button_option.Click += new System.EventHandler(this.button_option_Click);
            // 
            // button_minimum
            // 
            this.button_minimum.Location = new System.Drawing.Point(2, 98);
            this.button_minimum.Name = "button_minimum";
            this.button_minimum.Size = new System.Drawing.Size(80, 30);
            this.button_minimum.TabIndex = 2;
            this.button_minimum.Text = "최소화";
            this.button_minimum.UseVisualStyleBackColor = true;
            this.button_minimum.Click += new System.EventHandler(this.button_minimum_Click);
            // 
            // label_prtsc
            // 
            this.label_prtsc.AutoSize = true;
            this.label_prtsc.Location = new System.Drawing.Point(3, 8);
            this.label_prtsc.Name = "label_prtsc";
            this.label_prtsc.Size = new System.Drawing.Size(63, 24);
            this.label_prtsc.TabIndex = 2;
            this.label_prtsc.Text = "PrtSc\r\nAlt + PrtSc";
            // 
            // button_customSize
            // 
            this.button_customSize.Location = new System.Drawing.Point(2, 37);
            this.button_customSize.Name = "button_customSize";
            this.button_customSize.Size = new System.Drawing.Size(80, 30);
            this.button_customSize.TabIndex = 0;
            this.button_customSize.Text = "화면 지정";
            this.button_customSize.UseVisualStyleBackColor = true;
            this.button_customSize.Click += new System.EventHandler(this.button_customSize_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(84, 130);
            this.Controls.Add(this.button_customSize);
            this.Controls.Add(this.label_prtsc);
            this.Controls.Add(this.button_minimum);
            this.Controls.Add(this.button_option);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "캡쳐 저장";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_option;
        private System.Windows.Forms.Button button_minimum;
        private System.Windows.Forms.Label label_prtsc;
        private System.Windows.Forms.Button button_customSize;
    }
}