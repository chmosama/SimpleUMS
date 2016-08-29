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
    public partial class Fees_Add : Form
    {
        public Fees_Add()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string fid = txtFid.Text;
            string fsid = txtFsid.Text;
            string famount = txtFamount.Text;
            string fdate = date.Value.ToShortDateString();
            string freceived = txtFreceived.Text;
            string data = fid + ":" + fsid + ":" + famount + ":" + fdate + ":" + freceived;
            string fileLoc = AppDomain.CurrentDomain.BaseDirectory + @"\Fees.txt";
            if (fid == "" || fsid == "" || famount == "" || fdate == "" || freceived == "")
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
