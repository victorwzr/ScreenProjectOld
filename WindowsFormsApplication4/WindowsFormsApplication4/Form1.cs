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
        public static string f, drivetype;                                            //Create variable
        public static List<string> fliterlist = new List<string                       //Create variable
        static string[] fp; //array of files path                                     //Create variable
        static string[] folder;                                                       //Create variable
        public static List<string> allpath = new List<string>();                           //Create variable
        static int i = new int();                                                    //Create variable
        static int orgH, orgW;                                                         //Create variable
        static bool click, clickscreen, remove = false, error;                           //Create variable
        public static bool spb;                                                     //Create variable
        public static int whichone = 0;                                                  //Create variable
        static Point OldL = new Point();                                                         //Create variable
        public static bool jpg = true, png = false, gif = false, ico = false;              //Create variable
        public Form1()
        {
            InitializeComponent();                                    //Initialize All the Component of this form
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (whichone == 0)                                       //Check the program first time running
            {
                frmBegin begin = new frmBegin();                     //Initialize the Begin Form
                begin.ShowBegin(this);                               //Show Begin Form
            }
           DriveInfo[] allDrives = DriveInfo.GetDrives();            //Read all Drive info into array which current plug in computer
           foreach (DriveInfo di in allDrives)                       //Loop use drive name 
           {
               drivetype = Convert.ToString(di.DriveType);           //Change the drive name type into string
               drivetype = drivetype.ToLower();                      //Change all string to lower
               if (drivetype == "removable")                         //Search if any drive is removeable type
               {
                   remove = true;                                    //Check type
                   f = di.Name;                                      //Get path
                   try
                   {
                       GetFilesName();                               //Run procedure to get search path
                   }
                   catch (Exception)                                 //Check unaccess drives error
                   {
                       error = true;                                  //Found unaccess drives
                   }
                   if (error == true)                                    //skip drives
                   {
                   }
                   else
                   {
                   toolStripButtonS.Enabled = true;                       //Make button enable
                   toolStripButtonP.Enabled = true;                       //Make button enable
                   toolStripButtonPP.Enabled = true;                       //Make button enable
                   toolStripButtonN.Enabled = true;                       //Make button enable
                   }
               }
           }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (whichone == 0)                                             //Check the program first time run
            {
                this.Hide();                                                    //Hide main window
            }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (whichone == 4)                                           //Change language code
            {
                this.Text = "屏幕幻灯片";                                                 //Change Text
                toolStrip1.Font = new Font("楷体", 10, FontStyle.Regular);                //Change font
                toolStripButtonS.Text = "搜索";                                            //Change Text
                toolStripButtonF.Text = "全屏（ESC退出）";                                  //Change Text
                toolStripButtonP.Text = "上一个";                                            //Change Text
                toolStripButtonPP.Text = "播放/暂停";                                         //Change Text
                toolStripButtonN.Text = "下一个";                                           //Change Text
                toolStripButtonST.Text = "设置";                                           //Change Text
                toolStripButtonA.Text = "关于";                                           //Change Text
            }
            if (whichone==2)                                         //Change button state code
            {
                allpath = new List<string>();                         //Create new empty path list
                pictureBox1.Image = null;                              //Empty the image box
                if (f!= "")                                            //if now search path at begin
                {
                    toolStripButtonS.Enabled = true;                       //Make button enable
                    toolStripButtonP.Enabled = true;                       //Make button enable
                    toolStripButtonPP.Enabled = true;                       //Make button enable
                    toolStripButtonN.Enabled = true;                       //Make button enable
                }
                else
                {
                    toolStripButtonS.Enabled = false;                       //Make button disable
                    toolStripButtonP.Enabled = false;                       //Make button disable
                    toolStripButtonPP.Enabled = false;                       //Make button disable
                    toolStripButtonN.Enabled = false;                       //Make button disable
                }
                whichone = 0;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        static void Run()
        {
            string drivetype;                                     //Create variable
            if (spb != true)                                        //Check if first time run
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();    //Read all Drive info into array which current plug in computer
                foreach (DriveInfo di in allDrives)               //Loop use drive name 
                {
                    drivetype = Convert.ToString(di.DriveType);        //Change the drive name type into string
                    drivetype = drivetype.ToLower();             //Change all string to lower
                    if (drivetype == "removable")                   //Search if any drive is removeable type
                    {
                        remove = true;                                //Check type
                        f = di.Name;                              //Get path
                        GetFilesName();                            //Run the Procedure
                    }

                }
            }
            else
            {
                GetFilesName();                                          //Run the Procedure
            }
        }
        static void GetFilesName()
        {
            fliterlist.Add("*.jpg");                                     //Default search files type jpg
            foreach (string fliter in fliterlist)                        //Use different fliter to search files
            {
                fp = Directory.GetFiles(f, fliter);                      //Get the files path
                foreach (string filesname in fp)                         //Rewrite the path in order
                {
                    allpath.Add(filesname);                             //Add the files path to display list
                }
            }
            folder = Directory.GetDirectories(f);
            foreach (string foldername in folder)                        //Get the folder name and path which 
            {
                try
                {
                    f = foldername;                                      //Return the new folder search path to the procedure
                    GetFilesName();                                      //Recursion the procedure
                }
                catch (Exception)
                {
                                                                         //Skip any unaccess path
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i+1 < allpath.Count)                                 //Check if is last one
            {
                i++;                                                 //next image
                pictureBox1.ImageLocation = allpath[i];              //show image
            }
            else
            {
                i = 0;                                               //return the beginning
                pictureBox1.ImageLocation = allpath[i];             //Show image
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            if(click==false)                          //Check play stuation
            {
                click = true;                           //Button Clicked
            }
            else
            {
                click = false;                            //Button reture to default
            }
            if (click == true)                            //Check if image start display
            {
                timer1.Enabled = true;                  //Start timer
            }
            else
            {
                timer1.Enabled = false;                //Stop timer
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Run();                                           //Start main search procedure
            i = 0;                                             //Make image index to 0
            if (remove==false & spb==false)                    //Check remobeable drives situation and path array
            {
                MessageBox.Show("No removeable drive");           //Show message
            }
            else
            {
                try
                {
                    pictureBox1.ImageLocation = allpath[i];           //Display image
                }
                catch (Exception)
                {
                                                                      //Skip files can not access
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (i > 0)                                             //Last image
            {
                i--;                               //Change array position
                pictureBox1.ImageLocation = allpath[i];                   //Show image
            }
            else
            {
                i = allpath.Count-1;                            //return end
                pictureBox1.ImageLocation = allpath[i];                //Show picture
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (i+1 < allpath.Count)                           //Next image
            {
                i++;                                            //Change array position
                pictureBox1.ImageLocation = allpath[i];             //Show image
            }
            else
            {
                i = 0;                                   //return beginning
                pictureBox1.ImageLocation = allpath[i];           //Show picture
            }
        }  

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmSetting frmSetting = new frmSetting();              //Create setting form
            frmSetting.Show();                                   //Show setting form
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();                 //Create about form
            frmAbout.Show();                                   //Show about form
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)                //Check key
            {
                if (clickscreen == false)                    //Check screen size code
                {

                }
                else
                {
                    clickscreen = false;                //Return to origin code
                    this.TopMost = false;              //Not always in front of all windows
                    this.Width = orgW;                //Origin width
                    this.Height = orgH;                //Origin height
                    this.Location = OldL;                 //Origin location
                    this.FormBorderStyle = FormBorderStyle.Sizable;             //Adjustble form size
                    toolStripButtonST.Enabled = true;                 //Enable use setting button
                    toolStripButtonA.Enabled = true;                      //Enable use about button
                }
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (clickscreen==false)
            {
                Screen screen=Screen.PrimaryScreen;                          //Get primary screen info
                clickscreen = true;                                      //Full screen button code
                this.FormBorderStyle = FormBorderStyle.None;                //Form none border
                this.TopMost = true;                                 //Form always top
                orgH = this.Height;                                 //Full screen height
                orgW = this.Width;                                 //Full screen width
                OldL = this.Location;                                 //Full screen location
                this.Location=new Point(0,0);                       //0 location
                this.Width = screen.Bounds.Width;                   //Get full screen width
                this.Height = screen.Bounds.Height;                  //Get full screen height
                toolStripButtonST.Enabled = false;                     //Disable setting button
                toolStripButtonA.Enabled = false;                     //Disable about button
            }
            else
            {
                clickscreen = false;                      //Return to origin code
                this.TopMost = false;                         //Not always in front of all windows
                this.Width = orgW;                //Origin width
                this.Height = orgH;                //Origin height
                this.Location = OldL;                 //Origin location
                this.FormBorderStyle = FormBorderStyle.Sizable;             //Resizeble form size
                toolStripButtonST.Enabled = true;                //Enable use setting button
                toolStripButtonA.Enabled = true;                      //Enable use about button
            }
        }

    }
}
