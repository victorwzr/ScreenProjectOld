using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymScreenShow
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();                  //Initialize All the Component of this form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();                           //Click Button to click the About form
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            if (Form1.whichone==4)                  //If language code from Form1 is 4, change the language to Chiinese.
            {
                Font FontS = new Font("楷体", 10, FontStyle.Regular);        //Define the Chinese Font
                lblDB.Font = FontS;                                          //Change font
                lblDB.Text = "制作和设计：";                                 //Change Text
                lblDB.Location = new Point(89,96);                          //Change the Position                        
                lblSS.Text = "屏幕幻灯片";                                   //Change Text
                lblSS.Font = new Font("楷体", 20, FontStyle.Regular);        //Change font
                lblSS.Location = new Point(55, 45);                         //Change the Position 
                lblV.Text = "版本：测试版0.9.0";                             //Change Text
                lblV.Font = FontS;                                          //Change font
                lblVT.Text = "免费版";                                      //Change Text
                lblVT.Font = FontS;                                         //Change font
                lblVT.Location = new Point(110, 210);                      //Change the Position 
                btnC.Text = "关闭";                                        //Change Text
                btnC.Font = FontS;                                          //Change font
                this.Text = "关于";                                        //Change Text
            }
        }
    }
}
