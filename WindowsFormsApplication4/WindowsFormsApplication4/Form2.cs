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
    public partial class frmSetting : Form
    {

        public frmSetting()
        {
            InitializeComponent();                                     //Initialize All the Component of this form
            this.Load += new System.EventHandler(frmSetting_Load);    //Add event handler when the form load
        }


        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblFP_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSFP_Click(object sender, EventArgs e)
        {
            if (fBDSFP.ShowDialog()==DialogResult.OK)
            {
                txtSFP.Text = fBDSFP.SelectedPath;                               //When press OK, write selected search path into the text box
            }
        }

        private void fBDSFP_HelpRequest(object sender, EventArgs e)
        {
            txtSFP.Text = fBDSFP.SelectedPath;                                     //Put the path current uesd into the text box
        }

        private void txtSFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkBjpg_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBjpg.Checked == true)                                    //Check the check box
            {
                Form1.fliterlist.Add("*.jpg");                              //Add jpg type to form1 search list
                Form1.jpg=true;                                             //Check box selected
            }
            else
            {
                Form1.fliterlist.Remove("*.jpg");                           //Remove jpg type to form1 search list
                Form1.jpg = false;                                          //Cancel the check box
            }
        }

        private void chkBpng_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBpng.Checked == true)                                    //Check the check box
            {
                Form1.fliterlist.Add("*.png");                              //Add png type to form1 search list
                Form1.png = true;                                             //Check box selected
            }
            else
            {
                Form1.fliterlist.Remove("*.png");                           //Remove png type to form1 search list
                Form1.png = false;                                          //Cancel the check box
            }
        }

        private void chkBgif_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBgif.Checked == true)                                    //Check the check box
            {
                Form1.fliterlist.Add("*.gif");                              //Add gif type to form1 search list
                Form1.gif = true;                                             //Check box selected
            }
            else
            {
                Form1.fliterlist.Remove("*.gif");                           //Remove gif type to form1 search list
                Form1.gif = false;                                          //Cancel the check box
            }
        }

        private void chkBico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBico.Checked == true)                                    //Check the check box
            {
                Form1.fliterlist.Add("*.ico");                              //Add ico type to form1 search list
                Form1.ico = true;                                             //Check box selected

            }
            else
            {
                Form1.fliterlist.Remove("*.ico");                           //Remove ico type to form1 search list
                Form1.ico = false;                                          //Cancel the check box
            }
        }

        private void button1_Click(object sender, EventArgs e)   //Button "..." Click Event
        {
            string[] temfliter;                               //Define new string array used to save user enter files types
            temfliter = txtFF.Text.Split();                   //Split one or more types by space and write in the array
            foreach(string fliter in temfliter)               //Get every files types from array to a temple variable
            {
                Form1.fliterlist.Add(fliter);                  //Return every flies types one by one to Form1 files types array
            }
        }

        private void btnOK_Click(object sender, EventArgs e)     //Button OK Click Event
        {
            Form1.spb = true;                                        //Return value to Form1 to show user added the search path
            Form1.f = txtSFP.Text;                                   //Return the path user added to the Form1 Searching Path
            Form1.whichone = 2;                                      //Return identification code to Form1, Form1 will reset picture box and search path string
            this.Close();                                            //Close Setting Window
        }

        private void frmSetting_Load(object sender, EventArgs e)      //When the window is loding, program doing follow things
        {
            if(Form1.whichone==4)                                     //Check language code.
            {
                Font FontS = new Font("楷体", 10, FontStyle.Regular);  //Define the Chinese Font
                this.Text = "设置";                                  //Change Text
                tabPFiles.Text = "文件";                             //Change Text
                tabCSet.Font = FontS;                                //Change font
                btnOK.Text = "确定";                                 //Change Text
                btnOK.Font = FontS;                                  //Change font
                fBDSFP.Description = "选择要搜索的文件夹路径";        //Change Text
                lblSFP.Text = "搜索路径";                            //Change Text
                lblSFP.Font = FontS;                                 //Change font
                lblFF.Text = "文件类型";                             //Change Text
                lblFF.Font = FontS;                                   //Change font
                btnFF.Text = "确定";                                 //Change Text
                btnFF.Font = FontS;                                  //Change font
                txtFF.Text = "(自定义类型, 例如: *.jpg(空格)*.png)";  //Change Text
                txtFF.Font = FontS; 
            }
            txtSFP.Text = Form1.f;                                  //Make the path which is using show in the path text box
            chkBgif.Checked = Form1.gif;                              //Return the files type gif user added to the Form1 Search Type
            chkBico.Checked = Form1.ico;                             //Return the files type ico user added to the Form1 Search Type
            chkBjpg.Checked = Form1.jpg;                             //Return the files type jpg user added to the Form1 Search Type
            chkBpng.Checked = Form1.png;                             //Return the files type png user added to the Form1 Search Type
        }

    }
}
