using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donation2
{
    public partial class DonationList : Form
    {
        public DonationList()
        {
            InitializeComponent();
            //radioButton1.Checked = true;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{txtFirstName.Text}{txtLastName.Text}Did you select the correct type of  donation? Please Verrify correct donation");
            

            if (radioButton1.Checked)
            {
                Personal p1 = new Personal();
                p1.FirstName = txtFirstName.Text;
                p1.LastName = txtLastName.Text;
                p1.PhoneNumber = int.Parse(txtPhoneNumber.Text);
                p1.Age = int.Parse(txtAge.Text);
                p1.Amount = Decimal.Parse(txtAmont.Text);
                MessageBox.Show($"Thankyou {txtFirstName.Text}{txtLastName.Text}for your donation of {txtAmont.Text}!");

                AddDonation(p1);
                AddDonation2(b1);

            }

            else
            {
                Business b1 = new Business();
                b1.FirstName = txtFirstName.Text;
                b1.LastName = txtLastName.Text;
                b1.PhoneNumber = int.Parse(txtPhoneNumber.Text);
                b1.Age = int.Parse(txtAge.Text);
                b1.Amount = Decimal.Parse(txtAmont.Text);
                MessageBox.Show($"Thankyou {txtFirstName.Text}{txtLastName.Text}for your donation of {txtAmont.Text}!");
            }
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
            txtAge.Text = "";
            txtAmont.Text = "";
             radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void AddDonation(Donation personal)
        {
            listBox1.Items.Add(personal.FirstName + "" + personal.LastName + "  " + personal.PhoneNumber + "      " + personal.Age + "      " + personal.Amount + " " + personal.GetType().Name);
            

            //listBox1.Items.Clear();
        }

        private void AddDonation2(Donation buisness) 
        {
            listBox1.Items.Add(buisness.FirstName + "" + buisness.LastName + "  " + buisness.PhoneNumber + "      " + buisness.Age + "      " + buisness.Amount + " " + buisness.GetType().Name);
        }

        private void txtAmont_TextChanged(object sender, EventArgs e)
        {

        }
        public static void ShowDonation(Donation donation)
        {

        }
       
    }
}
