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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_New teacher_new = new Teacher_New();
            teacher_new.MdiParent = this;
            teacher_new.Show();
        }

        private void showAllRecordToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Teacher_View teacher_view = new Teacher_View();
            teacher_view.MdiParent = this;
            teacher_view.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_New student_new = new Student_New();
            student_new.MdiParent = this;
            student_new.Show();
        }

        private void showAllRecordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Student_View student_view = new Student_View();
            student_view.MdiParent = this;
            student_view.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Library_New library_new = new Library_New();
            library_new.MdiParent = this;
            library_new.Show();
        }

        private void showAllRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Library_View library_view = new Library_View();
            library_view.MdiParent = this;
            library_view.Show();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fees_Add fees_add = new Fees_Add();
            fees_add.MdiParent = this;
            fees_add.Show();
        }

        private void showAllRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees_View fees_view = new Fees_View();
            fees_view.MdiParent = this;
            fees_view.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
