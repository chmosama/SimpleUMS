using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class Library_View : Form
    {
        public Library_View()
        {
            InitializeComponent();
        }

        private void Library_View_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataGridView.DataTableFromTextFile(AppDomain.CurrentDomain.BaseDirectory + @"\Library.txt");
        }
    }
}
