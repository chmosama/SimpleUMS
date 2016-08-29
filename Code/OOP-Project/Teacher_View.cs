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
    public partial class Teacher_View : Form
    {
        public Teacher_View()
        {
            InitializeComponent();
        }
        private void Teacher_View_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataGridView.DataTableFromTextFile(AppDomain.CurrentDomain.BaseDirectory + @"\Teacher.txt");
        }
    }
}
