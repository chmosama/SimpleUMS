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
    public partial class Student_New : Form
    {
        public Student_New()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string sid = txtSid.Text;
            string sname = txtSname.Text;
            string sphone = txtSphone.Text;
            string saddress = txtSaddress.Text;
            string scampus = txtScampus.Text;
            string data = sid + ":" + sname + ":" + sphone + ":" + saddress + ":" + scampus;
            string fileLoc = AppDomain.CurrentDomain.BaseDirectory + @"\Student.txt";
            if (sid == "" || sname == "" || sphone == "" || saddress == "" || scampus == "")
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
