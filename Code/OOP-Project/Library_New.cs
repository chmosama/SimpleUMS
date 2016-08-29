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
    public partial class Library_New : Form
    {
        public Library_New()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string lid = txtLid.Text;
            string lname = txtLname.Text;
            string lpublisher = txtLpublisher.Text;
            string lclass = txtLclass.Text;
            string llastid = txtLlastid.Text;
            string data = lid + ":" + lname + ":" + lpublisher + ":" + lclass + ":" + llastid;
            string fileLoc = AppDomain.CurrentDomain.BaseDirectory + @"\Library.txt";
            if (lid == "" || lname == "" || lpublisher == "" || lclass == "" || llastid == "")
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
