using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Interview
{
    public partial class OnlineInterviewFormBackground : Form
    {
        public OnlineInterviewFormBackground()
        {
            InitializeComponent();
        }

        //User sending response button
        private void answerButton_Click(object sender, EventArgs e)
        {
            //If nothing has been entered into the box, pop up error message
            if (responseBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please enter a response");
            }
            else
            {
                conversationBox.Text += responseBox.Text + "\n";
                responseBox.Text = "";
            }

            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            string interviewerName = "Kathrin";
            Label_OnlineStatus.Text = interviewerName + " is writing...";
            Label_OnlineStatus.Refresh();
            System.Threading.Thread.Sleep(2000);
            Label_OnlineStatus.Text = "Online";
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
            //Temporary solution to "Kathin is writing.. " message
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void conversationBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
