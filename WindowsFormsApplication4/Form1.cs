using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GymScreenShow
{
    public partial class Form1 : Form
    {
        public static string f, drivetype;
        public static List<string> fliterlist=new List<string>();
        static string[] fp; //array of files path
        static string[] folder;
        public static List<string> allpath= new List<string>();
        static int i=new int();
        static int orgH, orgW;
        static bool click,clickscreen,remove = false,error;
        public static bool spb;
        public static int whichone=0;
        static Point OldL = new Point();
        public static bool jpg=true, png=false, gif=false, ico=false;
        public Form1()
        {
            InitializeComponent();                                    //Initialize All the Component of this form
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (whichone == 0)
            {
                frmBegin begin = new frmBegin();
                begin.ShowBegin(this);
            }
           DriveInfo[] allDrives = DriveInfo.GetDrives();
           foreach (DriveInfo di in allDrives)
           {
               drivetype = Convert.ToString(di.DriveType);
               drivetype = drivetype.ToLower();
               if (drivetype == "removable")
               {
                   remove = true;
                   f = di.Name;
                   try
                   {
                       GetFilesName();
                   }
                   catch (Exception)
                   {
                       error = true;
                   }
                   if (error == true)
                   {
                   }
                   else
                   {
                   toolStripButtonS.Enabled = true;
                   toolStripButtonP.Enabled = true;
                   toolStripButtonPP.Enabled = true;
                   toolStripButtonN.Enabled = true;
                   }
               }
           }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (whichone == 0)
            {
                this.Hide();
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (whichone == 4)
            {
                this.Text = "屏幕幻灯片";
                toolStrip1.Font = new Font("楷体", 10, FontStyle.Regular);
                toolStripButtonS.Text = "搜索";
                toolStripButtonF.Text = "全屏（ESC退出）";
                toolStripButtonP.Text = "上一个";
                toolStripButtonPP.Text = "播放/暂停";
                toolStripButtonN.Text = "下一个";
                toolStripButtonST.Text = "设置";
                toolStripButtonA.Text = "关于";
            }
            if (whichone==2)
            {
                allpath = new List<string>();
                pictureBox1.Image = null;
                if (f!= "")
                {
                    toolStripButtonS.Enabled = true;
                    toolStripButtonP.Enabled = true;
                    toolStripButtonPP.Enabled = true;
                    toolStripButtonN.Enabled = true;
                }
                else
                {
                    toolStripButtonS.Enabled = false;
                    toolStripButtonP.Enabled = false;
                    toolStripButtonPP.Enabled = false;
                    toolStripButtonN.Enabled = false;
                }
                whichone = 0;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        static void Run()
        {
            string drivetype;
            if (spb != true)
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo di in allDrives)
                {
                    drivetype=Convert.ToString(di.DriveType) ;
                    drivetype = drivetype.ToLower();
                    if (drivetype== "removable")
                    {
                        remove = true;
                        f = di.Name;
                        GetFilesName();
                    }

                }
            }
            else
            {
                GetFilesName();
            }
        }
        static void GetFilesName()
        {
            fliterlist.Add("*.jpg");
            foreach (string fliter in fliterlist)
            {
                fp = Directory.GetFiles(f, fliter);
                foreach (string filesname in fp)
                {
                    allpath.Add(filesname);
                }
            }
            folder = Directory.GetDirectories(f);
            foreach (string foldername in folder)
            {
                try
                {
                    f = foldername;
                    GetFilesName();
                }
                catch (Exception)
                {

                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i+1 < allpath.Count)
            {
                i++;
                pictureBox1.ImageLocation = allpath[i];
            }
            else
            {
                i = 0;
                pictureBox1.ImageLocation = allpath[i];
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if(click==false)
            {
                click = true;
            }
            else
            {
                click = false;
            }
            if (click == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Run();
            i = 0;
            if (remove==false & spb==false)
            {
                MessageBox.Show("No removeable drive");
            }
            else
            {
                try
                {
                    pictureBox1.ImageLocation = allpath[i];
                }
                catch (Exception)
                {
 
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                pictureBox1.ImageLocation = allpath[i];
            }
            else
            {
                i = allpath.Count-1;
                pictureBox1.ImageLocation = allpath[i];
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (i+1 < allpath.Count)
            {
                i++;
                pictureBox1.ImageLocation = allpath[i];
            }
            else
            {
                i = 0;
                pictureBox1.ImageLocation = allpath[i];
            }
        }  

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();
            frmSetting.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (clickscreen == false)
                {

                }
                else
                {
                    clickscreen = false;
                    this.TopMost = false;
                    this.Width = orgW;
                    this.Height = orgH;
                    this.Location = OldL;
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    toolStripButtonST.Enabled = true;
                    toolStripButtonA.Enabled = true;
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (clickscreen==false)
            {
                Screen screen=Screen.PrimaryScreen;
                clickscreen = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.TopMost = true;
                orgH = this.Height;
                orgW = this.Width;
                OldL = this.Location;
                this.Location=new Point(0,0);
                this.Width = screen.Bounds.Width;
                this.Height = screen.Bounds.Height;
                toolStripButtonST.Enabled = false;
                toolStripButtonA.Enabled = false;
            }
            else
            {
                clickscreen = false;
                this.TopMost = false;
                this.Width = orgW;
                this.Height = orgH;
                this.Location = OldL;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                toolStripButtonST.Enabled = true;
                toolStripButtonA.Enabled = true;
            }
        }

    }
}
