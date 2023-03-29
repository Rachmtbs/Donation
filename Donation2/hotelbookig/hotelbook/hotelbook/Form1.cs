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

namespace hotelbook
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var path = "output.txt";
                var record = txtFirst.Text + "," + txtLast.Text + "," + txtNumber;
                if (File.Exists(path))
                {
                    StreamWriter sw = File.AppendText(path);
                    sw.WriteLine(record);
                    sw.Close();
                }
                else 
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(record);
                    }
                }

            }   
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
