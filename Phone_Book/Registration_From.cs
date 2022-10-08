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
    public partial class Registration_From : Form
    {
        public Registration_From()
        {
            InitializeComponent();
        }

        private void Registration_From_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NewResigtrationToolStripButton_Click(object sender, EventArgs e)
        {
            this.NewResigtrationToolStripButton.Enabled = false;
            this.SaveRegistrationToolStripButton.Enabled = true;

            //--------------------------------------------------

            this.InformationOfRegisterGroupBox.Enabled = true;

            //----------Clear TextBoxes-------------------------

            this.IdRegistrationTextBox.ResetText();
            this.FirstNameTextBox.ResetText();
            this.LastNameTextBox.ResetText();
            this.Tel_TextBox.ResetText();
            this.MobileTextBox.ResetText();
            this.AddressTextBox3.ResetText();
            this.EmailTextBox2.ResetText();
            this.CoomentTextBox4.ResetText();
        }

        private void SaveRegistrationToolStripButton_Click(object sender, EventArgs e)
        {
            this.SaveRegistrationToolStripButton.Enabled = false;
            this.NewResigtrationToolStripButton.Enabled = true;

            //--------------------------------------------------

            this.InformationOfRegisterGroupBox.Enabled = false;

            //---------------Save Info----------------------

            if (IdRegistrationTextBox.Text == "")
            {
                MessageBox.Show("Give ID.");
            }
            else
            {
                string saveInfo;

                saveInfo = "D:\\C# Programming\\C# Code\\AAA Windows From C#\\Phone_Book\\SaveInfo\\";

                string p;

                p = saveInfo + this.IdRegistrationTextBox.Text + "IDName.txt";

                System.IO.File.WriteAllText(p, this.FirstNameTextBox.Text, Encoding.UTF8);

                p = saveInfo + this.FirstNameTextBox.Text + "FirstName.txt";

                System.IO.File.WriteAllText(p, this.FirstNameTextBox.Text, Encoding.UTF8);

                p = saveInfo + this.LastNameTextBox.Text + "LastName.txt";

                System.IO.File.WriteAllText(p, this.LastNameTextBox.Text, Encoding.UTF8);

                MessageBox.Show("Saved....");
            }
            

        }

        private void Registration_From_Load(object sender, EventArgs e)
        {
            this.InformationOfRegisterGroupBox.Enabled = false;
        }
    }
}
