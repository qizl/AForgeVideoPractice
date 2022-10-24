namespace AForgeVideoPractice
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plLeft = new System.Windows.Forms.Panel();
            this.plRight = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.plBottom = new System.Windows.Forms.Panel();
            this.plBody = new System.Windows.Forms.Panel();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTakeAPhoto = new System.Windows.Forms.Button();
            this.plBottom.SuspendLayout();
            this.plBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLeft
            // 
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 0);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(50, 615);
            this.plLeft.TabIndex = 0;
            // 
            // plRight
            // 
            this.plRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plRight.Location = new System.Drawing.Point(959, 0);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(50, 615);
            this.plRight.TabIndex = 1;
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(50, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(909, 20);
            this.plTop.TabIndex = 2;
            // 
            // plBottom
            // 
            this.plBottom.Controls.Add(this.btnTakeAPhoto);
            this.plBottom.Controls.Add(this.btnClose);
            this.plBottom.Controls.Add(this.btnOpen);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(50, 519);
            this.plBottom.Name = "plBottom";
            this.plBottom.Size = new System.Drawing.Size(909, 96);
            this.plBottom.TabIndex = 3;
            // 
            // plBody
            // 
            this.plBody.Controls.Add(this.videoSourcePlayer1);
            this.plBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBody.Location = new System.Drawing.Point(50, 20);
            this.plBody.Name = "plBody";
            this.plBody.Size = new System.Drawing.Size(909, 499);
            this.plBody.TabIndex = 4;
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(0, 0);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(909, 499);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(68, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 45);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "打开摄像头";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(236, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭摄像头";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTakeAPhoto
            // 
            this.btnTakeAPhoto.Location = new System.Drawing.Point(404, 20);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(114, 45);
            this.btnTakeAPhoto.TabIndex = 2;
            this.btnTakeAPhoto.Text = "拍照";
            this.btnTakeAPhoto.UseVisualStyleBackColor = true;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 615);
            this.Controls.Add(this.plBody);
            this.Controls.Add(this.plBottom);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plRight);
            this.Controls.Add(this.plLeft);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plBottom.ResumeLayout(false);
            this.plBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plBottom;
        private System.Windows.Forms.Button btnTakeAPhoto;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel plBody;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}

