using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegisterScreen.Model;

namespace StudentRegisterScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormFill();
        }
        private ArrayList studentList = new ArrayList();

        private ArrayList gradeList = new ArrayList()
            { "1.sınıf", "2.Sınıf", "3.Sınıf", "4.sınıf", "5.Sınıf", "6.Sınıf", "7.sınıf", "8.Sınıf" };

        private int id = 0;
        private Student selectedStudent;
        
        private void FormFill()
        {
            FillClass();
        }
        private void FillClass()
        {
            cmbGrade.Items.Clear();
            foreach (var item in gradeList)
            {
                cmbGrade.Items.Add(item.ToString());
            }
            cmbGrade.SelectedIndex = 0;

        }
        private string GetName()
        {
            string name = "";
            if (txtName.Text != "")
            {
                name = txtName.Text.Trim().TrimEnd().ToUpper();
            }

            return name;
        }
        private string GetPhone()
        {
            string phone = "";
            if (txtPhone.Text != "")
            {
                phone = txtPhone.Text.Trim().TrimEnd().ToUpper();
            }

            return phone;
        }
        private string GetIdendityNumber()
        {
            string idendity = "";
            if (txtPhone.Text != "")
            {
                idendity = txtIdendityNumber.Text.Trim().TrimEnd().ToUpper();
            }
            else
            {
                throw new Exception("TC kimlik numarası alanı boş olamaz");
            }

            return idendity;
        }
        private string GetEmail()
        {
            string email = "";
            if (txtPhone.Text != "")
            {
                email = txtEmail.Text.Trim().TrimEnd().ToUpper();
            }

            return email;
        }
        private string GetAdress()
        {
            string adress = "";
            if (txtPhone.Text != "")
            {
                adress = txtAdress.Text.Trim().TrimEnd().ToUpper();
            }

            return adress;
        }
        void FormClear()
        {
            txtPhone.Clear();
            txtEmail.Clear();
            txtAdress.Clear();
            txtIdendityNumber.Clear();
            dateBirth.Value = DateTime.Now;
            txtName.Clear();
            cmbGrade.SelectedIndex = 0;

            //Ekran temizlendiğinde seçili student varsa temizle
            selectedStudent = null;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
        }
        private void FormSave()
        {

            Student student = null;
            if (selectedStudent != null)
            {
                student = selectedStudent;
            }
            else
            {
                student = new Student();
                student.Id = GetId();
                studentList.Add(student);
            }


            student.IdNumber = GetIdendityNumber();
            student.Fullname = GetName();
            student.Phone = GetPhone();
            student.Email = GetEmail();
            student.Adress = GetAdress();
            student.BirthDate = dateBirth.Value;
            student.Grade = cmbGrade.SelectedItem.ToString();

            if (radioMan.Checked)
            {
                student.Gender = true;
            }
            else
            {
                student.Gender = false;
            }

            //studentList.Add(student);
            RefreshListBox();
            FormClear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                FormSave();
                FormClear();
            }
            
        }

        private int GetId()
        {
            return ++id;
        }

        void RefreshListBox()
        {
            lstStudents.Items.Clear();
            foreach (Student student in studentList)
            {
                lstStudents.Items.Add(student);
            }
        }

        private void lstStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstStudents.SelectedIndex == -1) return;

            //Unboxing yapıldı
            selectedStudent = lstStudents.SelectedItem as Student;
            //Seçilen student bilgilerini ekrana bas
            FillRecordForm();
        }

        private void FillRecordForm()
        {
            txtIdendityNumber.Text = selectedStudent.IdNumber;
            txtName.Text = selectedStudent.Fullname;
            txtPhone.Text = selectedStudent.Phone;
            txtEmail.Text = selectedStudent.Email;
            txtAdress.Text = selectedStudent.Adress;
            dateBirth.Value = selectedStudent.BirthDate;

            if (selectedStudent.Gender == true)
            {
                radioMan.Checked = true;
            }
            else
            {
                radioWoman.Checked = true;
            }
        }

        bool FormValid()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(txtIdendityNumber.Text))
            {
                MessageBox.Show("TC numarası alanı boş olamaz", "Öğrenci otomasyon", MessageBoxButtons.OK);
                txtIdendityNumber.Focus();
                result = false;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("İsim Soy isim alanı boş olamaz", "Öğrenci otomasyon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                result = false;
            }
            return result;
        }
    }
}
