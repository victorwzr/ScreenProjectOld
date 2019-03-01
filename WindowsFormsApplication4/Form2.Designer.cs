namespace GymScreenShow
{
    partial class frmSetting
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
            this.tabCSet = new System.Windows.Forms.TabControl();
            this.tabPFiles = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFF = new System.Windows.Forms.Button();
            this.txtFF = new System.Windows.Forms.TextBox();
            this.chkBico = new System.Windows.Forms.CheckBox();
            this.chkBgif = new System.Windows.Forms.CheckBox();
            this.chkBpng = new System.Windows.Forms.CheckBox();
            this.chkBjpg = new System.Windows.Forms.CheckBox();
            this.lblFF = new System.Windows.Forms.Label();
            this.btnSFP = new System.Windows.Forms.Button();
            this.txtSFP = new System.Windows.Forms.TextBox();
            this.lblSFP = new System.Windows.Forms.Label();
            this.tabPDesign = new System.Windows.Forms.TabPage();
            this.fBDSFP = new System.Windows.Forms.FolderBrowserDialog();
            this.tabCSet.SuspendLayout();
            this.tabPFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCSet
            // 
            this.tabCSet.Controls.Add(this.tabPFiles);
            this.tabCSet.Controls.Add(this.tabPDesign);
            this.tabCSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCSet.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCSet.Location = new System.Drawing.Point(0, 0);
            this.tabCSet.Name = "tabCSet";
            this.tabCSet.SelectedIndex = 0;
            this.tabCSet.Size = new System.Drawing.Size(700, 392);
            this.tabCSet.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCSet.TabIndex = 0;
            // 
            // tabPFiles
            // 
            this.tabPFiles.AutoScroll = true;
            this.tabPFiles.Controls.Add(this.btnOK);
            this.tabPFiles.Controls.Add(this.btnFF);
            this.tabPFiles.Controls.Add(this.txtFF);
            this.tabPFiles.Controls.Add(this.chkBico);
            this.tabPFiles.Controls.Add(this.chkBgif);
            this.tabPFiles.Controls.Add(this.chkBpng);
            this.tabPFiles.Controls.Add(this.chkBjpg);
            this.tabPFiles.Controls.Add(this.lblFF);
            this.tabPFiles.Controls.Add(this.btnSFP);
            this.tabPFiles.Controls.Add(this.txtSFP);
            this.tabPFiles.Controls.Add(this.lblSFP);
            this.tabPFiles.Font = new System.Drawing.Font("Buxton Sketch", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPFiles.Location = new System.Drawing.Point(4, 29);
            this.tabPFiles.Name = "tabPFiles";
            this.tabPFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPFiles.Size = new System.Drawing.Size(692, 359);
            this.tabPFiles.TabIndex = 0;
            this.tabPFiles.Text = "Files";
            this.tabPFiles.UseVisualStyleBackColor = true;
            this.tabPFiles.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(550, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 30);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFF
            // 
            this.btnFF.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFF.Location = new System.Drawing.Point(586, 144);
            this.btnFF.Name = "btnFF";
            this.btnFF.Size = new System.Drawing.Size(53, 29);
            this.btnFF.TabIndex = 9;
            this.btnFF.Text = "Set";
            this.btnFF.UseVisualStyleBackColor = true;
            this.btnFF.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFF
            // 
            this.txtFF.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFF.Location = new System.Drawing.Point(197, 144);
            this.txtFF.Name = "txtFF";
            this.txtFF.Size = new System.Drawing.Size(389, 27);
            this.txtFF.TabIndex = 8;
            this.txtFF.Text = "(Custom, For example enter: *.jpg(space)*.png)";
            this.txtFF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkBico
            // 
            this.chkBico.AutoSize = true;
            this.chkBico.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBico.Location = new System.Drawing.Point(475, 95);
            this.chkBico.Name = "chkBico";
            this.chkBico.Size = new System.Drawing.Size(56, 24);
            this.chkBico.TabIndex = 7;
            this.chkBico.Text = "*.ico";
            this.chkBico.UseVisualStyleBackColor = true;
            this.chkBico.CheckedChanged += new System.EventHandler(this.chkBico_CheckedChanged);
            // 
            // chkBgif
            // 
            this.chkBgif.AutoSize = true;
            this.chkBgif.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBgif.Location = new System.Drawing.Point(386, 95);
            this.chkBgif.Name = "chkBgif";
            this.chkBgif.Size = new System.Drawing.Size(54, 24);
            this.chkBgif.TabIndex = 6;
            this.chkBgif.Text = "*.gif";
            this.chkBgif.UseVisualStyleBackColor = true;
            this.chkBgif.CheckedChanged += new System.EventHandler(this.chkBgif_CheckedChanged);
            // 
            // chkBpng
            // 
            this.chkBpng.AutoSize = true;
            this.chkBpng.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBpng.Location = new System.Drawing.Point(293, 95);
            this.chkBpng.Name = "chkBpng";
            this.chkBpng.Size = new System.Drawing.Size(60, 24);
            this.chkBpng.TabIndex = 5;
            this.chkBpng.Text = "*.png";
            this.chkBpng.UseVisualStyleBackColor = true;
            this.chkBpng.CheckedChanged += new System.EventHandler(this.chkBpng_CheckedChanged);
            // 
            // chkBjpg
            // 
            this.chkBjpg.AutoSize = true;
            this.chkBjpg.Checked = true;
            this.chkBjpg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBjpg.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBjpg.Location = new System.Drawing.Point(197, 95);
            this.chkBjpg.Name = "chkBjpg";
            this.chkBjpg.Size = new System.Drawing.Size(56, 24);
            this.chkBjpg.TabIndex = 4;
            this.chkBjpg.Text = "*.jpg";
            this.chkBjpg.UseVisualStyleBackColor = true;
            this.chkBjpg.CheckedChanged += new System.EventHandler(this.chkBjpg_CheckedChanged);
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(44, 96);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(82, 23);
            this.lblFF.TabIndex = 3;
            this.lblFF.Text = "Files Fliter";
            this.lblFF.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSFP
            // 
            this.btnSFP.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSFP.Location = new System.Drawing.Point(586, 44);
            this.btnSFP.Name = "btnSFP";
            this.btnSFP.Size = new System.Drawing.Size(53, 29);
            this.btnSFP.TabIndex = 2;
            this.btnSFP.Text = "...";
            this.btnSFP.UseVisualStyleBackColor = true;
            this.btnSFP.Click += new System.EventHandler(this.btnSFP_Click);
            // 
            // txtSFP
            // 
            this.txtSFP.Font = new System.Drawing.Font("Buxton Sketch", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSFP.Location = new System.Drawing.Point(197, 44);
            this.txtSFP.Name = "txtSFP";
            this.txtSFP.Size = new System.Drawing.Size(389, 27);
            this.txtSFP.TabIndex = 1;
            this.txtSFP.TextChanged += new System.EventHandler(this.txtSFP_TextChanged);
            // 
            // lblSFP
            // 
            this.lblSFP.AutoSize = true;
            this.lblSFP.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSFP.Location = new System.Drawing.Point(44, 44);
            this.lblSFP.Name = "lblSFP";
            this.lblSFP.Size = new System.Drawing.Size(139, 23);
            this.lblSFP.TabIndex = 0;
            this.lblSFP.Text = "Search Folder Path";
            this.lblSFP.Click += new System.EventHandler(this.lblFP_Click);
            // 
            // tabPDesign
            // 
            this.tabPDesign.Location = new System.Drawing.Point(4, 29);
            this.tabPDesign.Name = "tabPDesign";
            this.tabPDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabPDesign.Size = new System.Drawing.Size(692, 359);
            this.tabPDesign.TabIndex = 1;
            this.tabPDesign.Text = "Design";
            this.tabPDesign.UseVisualStyleBackColor = true;
            // 
            // fBDSFP
            // 
            this.fBDSFP.Description = "Selected Folder Path Of Search";
            this.fBDSFP.HelpRequest += new System.EventHandler(this.fBDSFP_HelpRequest);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 392);
            this.Controls.Add(this.tabCSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetting";
            this.Text = "Settings";
            this.tabCSet.ResumeLayout(false);
            this.tabPFiles.ResumeLayout(false);
            this.tabPFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCSet;
        private System.Windows.Forms.TabPage tabPFiles;
        private System.Windows.Forms.TabPage tabPDesign;
        private System.Windows.Forms.Label lblSFP;
        private System.Windows.Forms.TextBox txtSFP;
        private System.Windows.Forms.FolderBrowserDialog fBDSFP;
        private System.Windows.Forms.Button btnSFP;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.TextBox txtFF;
        private System.Windows.Forms.CheckBox chkBico;
        private System.Windows.Forms.CheckBox chkBgif;
        private System.Windows.Forms.CheckBox chkBpng;
        private System.Windows.Forms.CheckBox chkBjpg;
        private System.Windows.Forms.Button btnFF;
        private System.Windows.Forms.Button btnOK;


    }
}