using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_Student_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void defineClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClass frm = new FormClass();
            frm.Show();
        }

        private void defineStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent frm2 = new FormStudent();
            frm2.Show();
        }
    }
}
