using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Book
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Registration from
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registration_From registration_From = new Registration_From();
            registration_From.MdiParent = this;
            registration_From.Show();
        }

        //Search
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_From search_From = new Search_From();

            search_From.MdiParent = this;
            search_From.Show();
        }

        //About Us
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About_us about_Us = new About_us();

            about_Us.MdiParent = this;
            about_Us.Show();
        }

        
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculator
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc";
            this.process1.Start();
        }
    }
}
