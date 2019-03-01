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
     
    public partial class frmBegin : Form
    {
        Form frmBeg;

        public frmBegin()
        {
            InitializeComponent();           //Initialize All the Component of this form
        }
        public void ShowBegin(Form form1)
        {
            frmBeg = form1;                       //Make current form as the Default Form
            this.Show();                          //Show the current form at the top of screen
        }
        private void button2_Click(object sender, EventArgs e)  //Choose Chinese
        {
            Form1.whichone = 4;                    //Return value 4 to Main Program Form1 as the Chinese language code
            frmBeg.Show();                         //Show the current form at the top of screen
            frmBeg.Activate();                     //Let the user contorl activate the current form
            this.Close();                          //Close current form
        }

        private void button1_Click(object sender, EventArgs e)  //Choose English
        {
            Form1.whichone = 5;                    //Return value 5 to Main Program Form1 as the English language code
            frmBeg.Show();                         //Show the current form at the top of screen
            frmBeg.Activate();                     //Let the user contorl activate the current form
            this.Close();                          //Close current form
        }

        private void frmBegin_Load(object sender, EventArgs e)
        {

        }
    }
}
