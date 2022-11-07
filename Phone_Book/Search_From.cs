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
    public partial class Search_From : Form
    {
        public Search_From()
        {
            InitializeComponent();
        }

        private void Search_From_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (this.SearchTextBox.Text == "")
            {
                MessageBox.Show("You Must Enter The ID.");
                return;
            }

            string saveInfo;

            saveInfo = "D:\\C# Programming\\C# Code\\AAA Windows From C#\\Phone_Book\\SaveInfo\\";

            string p;

            p = saveInfo + this.SearchTextBox.Text + "IDName.txt";

            string reading = System.IO.File.ReadAllText(p, Encoding.UTF8);

            this.FirstNameTextBox.Text = reading;
        }
    }
}

