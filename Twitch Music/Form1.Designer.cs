namespace Twitch_Music
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("asdf");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("d");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("asdf");
            this.Text_Channel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listMusicLink = new System.Windows.Forms.ListView();
            this.listMusicTitle = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.Text_Command = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_Channel
            // 
            this.Text_Channel.Location = new System.Drawing.Point(47, 14);
            this.Text_Channel.Name = "Text_Channel";
            this.Text_Channel.Size = new System.Drawing.Size(277, 21);
            this.Text_Channel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listMusicLink
            // 
            this.listMusicLink.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listMusicLink.Location = new System.Drawing.Point(14, 91);
            this.listMusicLink.Name = "listMusicLink";
            this.listMusicLink.Size = new System.Drawing.Size(429, 207);
            this.listMusicLink.TabIndex = 4;
            this.listMusicLink.UseCompatibleStateImageBehavior = false;
            this.listMusicLink.View = System.Windows.Forms.View.List;
            // 
            // listMusicTitle
            // 
            this.listMusicTitle.Location = new System.Drawing.Point(466, 91);
            this.listMusicTitle.Name = "listMusicTitle";
            this.listMusicTitle.Size = new System.Drawing.Size(438, 207);
            this.listMusicTitle.TabIndex = 5;
            this.listMusicTitle.UseCompatibleStateImageBehavior = false;
            this.listMusicTitle.View = System.Windows.Forms.View.List;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(823, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Del";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Text_Command
            // 
            this.Text_Command.Location = new System.Drawing.Point(87, 47);
            this.Text_Command.Name = "Text_Command";
            this.Text_Command.Size = new System.Drawing.Size(238, 21);
            this.Text_Command.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "채널";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "노래 큐";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 316);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(890, 372);
            this.webBrowser1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "테스트 명령";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(729, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Text_Command);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listMusicTitle);
            this.Controls.Add(this.listMusicLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_Channel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_Channel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listMusicLink;
        private System.Windows.Forms.ListView listMusicTitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Text_Command;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

