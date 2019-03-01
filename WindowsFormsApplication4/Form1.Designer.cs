namespace GymScreenShow
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonF = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonP = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPP = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonN = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonST = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonA = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonS,
            this.toolStripButtonF,
            this.toolStripButtonP,
            this.toolStripButtonPP,
            this.toolStripButtonN,
            this.toolStripButtonST,
            this.toolStripButtonA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(566, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonS
            // 
            this.toolStripButtonS.Enabled = false;
            this.toolStripButtonS.Image = global::GymScreenShow.Properties.Resources.Search;
            this.toolStripButtonS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonS.Name = "toolStripButtonS";
            this.toolStripButtonS.Size = new System.Drawing.Size(72, 24);
            this.toolStripButtonS.Text = "Search";
            this.toolStripButtonS.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonF
            // 
            this.toolStripButtonF.Image = global::GymScreenShow.Properties.Resources.Desktop_alt;
            this.toolStripButtonF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonF.Name = "toolStripButtonF";
            this.toolStripButtonF.Size = new System.Drawing.Size(96, 24);
            this.toolStripButtonF.Text = "Full Screen";
            this.toolStripButtonF.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButtonP
            // 
            this.toolStripButtonP.Enabled = false;
            this.toolStripButtonP.Image = global::GymScreenShow.Properties.Resources.MB_0006_back;
            this.toolStripButtonP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonP.Name = "toolStripButtonP";
            this.toolStripButtonP.Size = new System.Drawing.Size(82, 24);
            this.toolStripButtonP.Text = "Previous";
            this.toolStripButtonP.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButtonPP
            // 
            this.toolStripButtonPP.Enabled = false;
            this.toolStripButtonPP.Image = global::GymScreenShow.Properties.Resources.MB_0000_WMP;
            this.toolStripButtonPP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPP.Name = "toolStripButtonPP";
            this.toolStripButtonPP.Size = new System.Drawing.Size(95, 24);
            this.toolStripButtonPP.Text = "Play/Pause";
            this.toolStripButtonPP.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButtonN
            // 
            this.toolStripButtonN.Enabled = false;
            this.toolStripButtonN.Image = global::GymScreenShow.Properties.Resources.MB_0006_to;
            this.toolStripButtonN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonN.Name = "toolStripButtonN";
            this.toolStripButtonN.Size = new System.Drawing.Size(58, 24);
            this.toolStripButtonN.Text = "Next";
            this.toolStripButtonN.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButtonST
            // 
            this.toolStripButtonST.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripButtonST.Image = global::GymScreenShow.Properties.Resources.Configure;
            this.toolStripButtonST.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonST.Name = "toolStripButtonST";
            this.toolStripButtonST.Size = new System.Drawing.Size(76, 24);
            this.toolStripButtonST.Text = "Setting";
            this.toolStripButtonST.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButtonA
            // 
            this.toolStripButtonA.Image = global::GymScreenShow.Properties.Resources.Info;
            this.toolStripButtonA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonA.Name = "toolStripButtonA";
            this.toolStripButtonA.Size = new System.Drawing.Size(67, 24);
            this.toolStripButtonA.Text = "About";
            this.toolStripButtonA.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 368);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Screen Slideshow";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonS;
        private System.Windows.Forms.ToolStripButton toolStripButtonP;
        private System.Windows.Forms.ToolStripButton toolStripButtonPP;
        private System.Windows.Forms.ToolStripButton toolStripButtonN;
        private System.Windows.Forms.ToolStripButton toolStripButtonST;
        private System.Windows.Forms.ToolStripButton toolStripButtonA;
        private System.Windows.Forms.ToolStripButton toolStripButtonF;

    }
}

