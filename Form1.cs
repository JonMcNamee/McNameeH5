using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
/* 
Jon McNamee
06 October 2022
This lab is to create a program that functions as a basic multiplication calculator, and to display information about a chosen topic.
The topic I've chosen is my cat Adolin, mostly because I like to show pictures of him whenever I can.
*/
namespace McNameeLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
            //Close the form.
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            picturebox.Show();
            //Reveals my picture
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            picturebox.Visible = false;
            //hides picture
            lbldata.Visible = false;
            //hides data text
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            answertxt.Text = "";
            //clears text from calculator textboxes
        }

        private void btndata_Click(object sender, EventArgs e)
        {
            picturebox.Visible = false;
            //hides picture box 
            String lbltopic= "my cat Adolin.";
            //to display topic as string
            lbldata.Text = "My topic is " + lbltopic + "\nHis nickname is Addy and he is 4 years old. He is very attention hungry." +
                "He's been on a bit of a diet lately as the vet was calling him 'generous', so he's been a bit grumpy lately.";
            //Text that appears when data is clicked
            lbldata.Visible= true;
            //Makes data text visible
            
        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My little guy Addy.", "Jon McNamee");
            //When image is clicked, a message box will appear.
        }

        private void btncalc_Click(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(textbox1.Text);
            int y = Convert.ToInt32(textbox2.Text);
            //sets textboxes as integers and init
         int z = x * y;
            answertxt.Text = z.ToString();
            //generate sum of number x multiplier
        }
    }
}
