namespace GymScreenShow
{
    partial class frmAbout
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
            this.btnC = new System.Windows.Forms.Button();
            this.lblV = new System.Windows.Forms.Label();
            this.lblCDS = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.lblWZR = new System.Windows.Forms.Label();
            this.lblVT = new System.Windows.Forms.Label();
            this.lblSS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(147, 272);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(92, 31);
            this.btnC.TabIndex = 0;
            this.btnC.Text = "Close";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblV
            // 
            this.lblV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblV.AutoSize = true;
            this.lblV.Location = new System.Drawing.Point(68, 190);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(120, 20);
            this.lblV.TabIndex = 1;
            this.lblV.Text = "Version Beta 0.9.0";
            // 
            // lblCDS
            // 
            this.lblCDS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCDS.AutoSize = true;
            this.lblCDS.Location = new System.Drawing.Point(60, 122);
            this.lblCDS.Name = "lblCDS";
            this.lblCDS.Size = new System.Drawing.Size(132, 20);
            this.lblCDS.TabIndex = 2;
            this.lblCDS.Text = "Crystal Dream Studio";
            // 
            // lblDB
            // 
            this.lblDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(94, 96);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(68, 20);
            this.lblDB.TabIndex = 3;
            this.lblDB.Text = "Design By";
            // 
            // lblWZR
            // 
            this.lblWZR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWZR.AutoSize = true;
            this.lblWZR.Location = new System.Drawing.Point(107, 148);
            this.lblWZR.Name = "lblWZR";
            this.lblWZR.Size = new System.Drawing.Size(37, 20);
            this.lblWZR.TabIndex = 4;
            this.lblWZR.Text = "WZR";
            // 
            // lblVT
            // 
            this.lblVT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVT.AutoSize = true;
            this.lblVT.Location = new System.Drawing.Point(90, 210);
            this.lblVT.Name = "lblVT";
            this.lblVT.Size = new System.Drawing.Size(80, 20);
            this.lblVT.TabIndex = 5;
            this.lblVT.Text = "Free Version";
            // 
            // lblSS
            // 
            this.lblSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSS.AutoSize = true;
            this.lblSS.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSS.Location = new System.Drawing.Point(30, 36);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(198, 36);
            this.lblSS.TabIndex = 6;
            this.lblSS.Text = "Screen Slideshow";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 317);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.lblVT);
            this.Controls.Add(this.lblWZR);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblCDS);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.btnC);
            this.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblV;
        private System.Windows.Forms.Label lblCDS;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblWZR;
        private System.Windows.Forms.Label lblVT;
        private System.Windows.Forms.Label lblSS;
    }
}