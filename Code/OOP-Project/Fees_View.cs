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
    public partial class Fees_View : Form
    {
        public Fees_View()
        {
            InitializeComponent();
        }

        private void Fees_View_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataGridView.DataTableFromTextFile(AppDomain.CurrentDomain.BaseDirectory + @"\Fees.txt");
        }
    }
}
