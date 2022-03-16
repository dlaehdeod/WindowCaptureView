
namespace WindowsViewCapture
{
    partial class Form_Option
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_savePath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_setPath = new System.Windows.Forms.Button();
            this.textBox_savePath = new System.Windows.Forms.TextBox();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.label_fileName = new System.Windows.Forms.Label();
            this.groupBox_saveOption = new System.Windows.Forms.GroupBox();
            this.textBox_simpleEx = new System.Windows.Forms.TextBox();
            this.textBox_smartEx = new System.Windows.Forms.TextBox();
            this.radioButton_back = new System.Windows.Forms.RadioButton();
            this.radioButton_front = new System.Windows.Forms.RadioButton();
            this.button_done = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_saveEffect = new System.Windows.Forms.CheckBox();
            this.checkBox_taskbar = new System.Windows.Forms.CheckBox();
            this.groupBox_saveOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_savePath
            // 
            this.label_savePath.AutoSize = true;
            this.label_savePath.Location = new System.Drawing.Point(7, 17);
            this.label_savePath.Name = "label_savePath";
            this.label_savePath.Size = new System.Drawing.Size(57, 12);
            this.label_savePath.TabIndex = 1;
            this.label_savePath.Text = "저장 위치";
            // 
            // button_setPath
            // 
            this.button_setPath.Location = new System.Drawing.Point(335, 7);
            this.button_setPath.Name = "button_setPath";
            this.button_setPath.Size = new System.Drawing.Size(99, 34);
            this.button_setPath.TabIndex = 0;
            this.button_setPath.Text = "저장 위치 설정";
            this.button_setPath.UseVisualStyleBackColor = true;
            this.button_setPath.Click += new System.EventHandler(this.button_setPath_Click);
            // 
            // textBox_savePath
            // 
            this.textBox_savePath.Enabled = false;
            this.textBox_savePath.Location = new System.Drawing.Point(70, 14);
            this.textBox_savePath.Name = "textBox_savePath";
            this.textBox_savePath.Size = new System.Drawing.Size(259, 21);
            this.textBox_savePath.TabIndex = 3;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(70, 53);
            this.textBox_fileName.MaxLength = 200;
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(161, 21);
            this.textBox_fileName.TabIndex = 1;
            this.textBox_fileName.Text = "Image_";
            this.textBox_fileName.TextChanged += new System.EventHandler(this.textBox_fileName_TextChanged);
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.Location = new System.Drawing.Point(14, 57);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(41, 12);
            this.label_fileName.TabIndex = 4;
            this.label_fileName.Text = "파일명";
            // 
            // groupBox_saveOption
            // 
            this.groupBox_saveOption.Controls.Add(this.textBox_simpleEx);
            this.groupBox_saveOption.Controls.Add(this.textBox_smartEx);
            this.groupBox_saveOption.Controls.Add(this.radioButton_back);
            this.groupBox_saveOption.Controls.Add(this.radioButton_front);
            this.groupBox_saveOption.Location = new System.Drawing.Point(17, 84);
            this.groupBox_saveOption.Name = "groupBox_saveOption";
            this.groupBox_saveOption.Size = new System.Drawing.Size(417, 112);
            this.groupBox_saveOption.TabIndex = 4;
            this.groupBox_saveOption.TabStop = false;
            this.groupBox_saveOption.Text = "저장 옵션";
            // 
            // textBox_simpleEx
            // 
            this.textBox_simpleEx.BackColor = System.Drawing.Color.White;
            this.textBox_simpleEx.Enabled = false;
            this.textBox_simpleEx.Location = new System.Drawing.Point(248, 40);
            this.textBox_simpleEx.Multiline = true;
            this.textBox_simpleEx.Name = "textBox_simpleEx";
            this.textBox_simpleEx.Size = new System.Drawing.Size(143, 58);
            this.textBox_simpleEx.TabIndex = 1;
            this.textBox_simpleEx.Text = "Image_1\r\nImage_2\r\n ...\r\nImage_10";
            // 
            // textBox_smartEx
            // 
            this.textBox_smartEx.BackColor = System.Drawing.Color.White;
            this.textBox_smartEx.Enabled = false;
            this.textBox_smartEx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_smartEx.Location = new System.Drawing.Point(22, 40);
            this.textBox_smartEx.Multiline = true;
            this.textBox_smartEx.Name = "textBox_smartEx";
            this.textBox_smartEx.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_smartEx.Size = new System.Drawing.Size(143, 58);
            this.textBox_smartEx.TabIndex = 0;
            this.textBox_smartEx.Text = "Image_01\r\nImage_02\r\n ...\r\nImage_10";
            // 
            // radioButton_back
            // 
            this.radioButton_back.AutoSize = true;
            this.radioButton_back.Location = new System.Drawing.Point(248, 18);
            this.radioButton_back.Name = "radioButton_back";
            this.radioButton_back.Size = new System.Drawing.Size(35, 16);
            this.radioButton_back.TabIndex = 1;
            this.radioButton_back.Text = "뒤";
            this.radioButton_back.UseVisualStyleBackColor = true;
            // 
            // radioButton_front
            // 
            this.radioButton_front.AutoSize = true;
            this.radioButton_front.Checked = true;
            this.radioButton_front.Location = new System.Drawing.Point(22, 19);
            this.radioButton_front.Name = "radioButton_front";
            this.radioButton_front.Size = new System.Drawing.Size(35, 16);
            this.radioButton_front.TabIndex = 0;
            this.radioButton_front.TabStop = true;
            this.radioButton_front.Text = "앞";
            this.radioButton_front.UseVisualStyleBackColor = true;
            // 
            // button_done
            // 
            this.button_done.Location = new System.Drawing.Point(254, 202);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(87, 33);
            this.button_done.TabIndex = 5;
            this.button_done.Text = "저장";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(347, 202);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 33);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "취소";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_saveEffect
            // 
            this.checkBox_saveEffect.AutoSize = true;
            this.checkBox_saveEffect.Checked = true;
            this.checkBox_saveEffect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_saveEffect.Location = new System.Drawing.Point(279, 48);
            this.checkBox_saveEffect.Name = "checkBox_saveEffect";
            this.checkBox_saveEffect.Size = new System.Drawing.Size(132, 16);
            this.checkBox_saveEffect.TabIndex = 2;
            this.checkBox_saveEffect.Text = "캡쳐 시 화면 깜빡임";
            this.checkBox_saveEffect.UseVisualStyleBackColor = true;
            // 
            // checkBox_taskbar
            // 
            this.checkBox_taskbar.AutoSize = true;
            this.checkBox_taskbar.Location = new System.Drawing.Point(279, 69);
            this.checkBox_taskbar.Name = "checkBox_taskbar";
            this.checkBox_taskbar.Size = new System.Drawing.Size(160, 16);
            this.checkBox_taskbar.TabIndex = 3;
            this.checkBox_taskbar.Text = "캡쳐 시 작업 표시줄 포함";
            this.checkBox_taskbar.UseVisualStyleBackColor = true;
            // 
            // Form_Option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 240);
            this.Controls.Add(this.checkBox_taskbar);
            this.Controls.Add(this.checkBox_saveEffect);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.groupBox_saveOption);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.label_fileName);
            this.Controls.Add(this.textBox_savePath);
            this.Controls.Add(this.button_setPath);
            this.Controls.Add(this.label_savePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form_Option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "옵션";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Option_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Option_KeyDown);
            this.groupBox_saveOption.ResumeLayout(false);
            this.groupBox_saveOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_savePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_setPath;
        private System.Windows.Forms.TextBox textBox_savePath;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.GroupBox groupBox_saveOption;
        private System.Windows.Forms.RadioButton radioButton_back;
        private System.Windows.Forms.RadioButton radioButton_front;
        private System.Windows.Forms.TextBox textBox_simpleEx;
        private System.Windows.Forms.TextBox textBox_smartEx;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_saveEffect;
        private System.Windows.Forms.CheckBox checkBox_taskbar;
    }
}

