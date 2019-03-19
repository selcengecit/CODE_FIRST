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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
        }
        StudentClass ctx = new StudentClass();

        private void FormClass_Load(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            dataGridView1.DataSource = ctx.Classes.Select(x => new
            {
                x.ClassId,
                x.Description
            }).ToList();
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            Class_ cls = new Class_();
            cls.Description = textBox1.Text;
            ctx.Classes.Add(cls);
            ctx.SaveChanges();
            Doldur();
        }
    }
}

