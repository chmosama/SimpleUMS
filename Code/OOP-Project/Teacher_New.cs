using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OOP_Project
{
    public partial class Teacher_New : Form
    {
        public Teacher_New()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string tname = txtTname.Text;
            string taddress = txtTaddress.Text;
            string tphone = txtTphone.Text;
            string tdepart = txtTdepart.Text;
            string tsalary = txtTsalary.Text;
            string data = tname + ":" + taddress + ":" + tphone + ":" + tdepart + ":" + tsalary;
            string fileLoc = AppDomain.CurrentDomain.BaseDirectory + @"\Teacher.txt";
            if (tname == "" || taddress == "" || tphone == "" || tdepart == "" || tsalary == "")
            {
                MessageBox.Show("Please fill required fields", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (File.Exists(fileLoc))
                {
                    StreamWriter sw = new StreamWriter(fileLoc, true);
                    sw.WriteLine(data);
                    sw.Close();
                    MessageBox.Show("Record Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data File does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
