using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegisterScreen.Model
{
    public class Student
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        private string _idNumber;
        public string IdNumber
        {
            get => _idNumber;
            set => _idNumber = value;
        }

        private string _fullName;
        public string Fullname
        {
            get => _fullName;
            set => _fullName = value;
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        private string _phone;
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        private bool _gender;

        //true erkek, false kadın
        public bool Gender
        {
            get => _gender;
            set => _gender = value;
        }

        private string _adress;
        public string Adress
        {
            get => _adress;
            set => _adress = value;
        }

        private string _grade;
        public string Grade
        {
            get => _grade;
            set => _grade = value;
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        public override string ToString()
        {
            return $"{this.Id}-{this.Fullname}";
        }
    }
}
