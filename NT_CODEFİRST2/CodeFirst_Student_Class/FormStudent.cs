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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        StudentClass db = new StudentClass();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.AdSoyad = textBox1.Text;
            std.SınıfID = (int)comboBox1.SelectedValue;
            db.Students.Add(std);
            db.SaveChanges();
            Doldur();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            cmbDoldur();
            Doldur();
        }
        private void cmbDoldur()
        {
            var clist = db.Classes.Select(x => new
            {
                x.ClassId,
                x.Description
            }).ToList();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "ClassId";
            comboBox1.DataSource = clist;       
        
        }
        private void Doldur()
        {
            dataGridView1.DataSource = db.Students.Select(x => new
            {
                x.TcKimlikID,
                x.AdSoyad,
                x.SınıfID
            }).ToList();
        }
    }
}
