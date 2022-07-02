using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp.Model
{
    internal class Student
    {
        private int _rollno = 0;
        private string _name = null;
        private double _cgpa = 0;

        public void SetName(string name)
        {
            if (name.Length <= 5)
            {
                this._name = name;
            }
            else
            {
                this._name = "Empty ";
            }
        }
        public void SetCgpa(double cgpa)
        {
            if (cgpa < 1)
            {
                _cgpa = 1;
            }
            else if (cgpa > 10)
            {
                _cgpa = 10;
            }
            else
            {
                this._cgpa = cgpa;
            }
        }
        public void SetRollno(int rollno)
        {
            if (rollno < 1)
            {
                _rollno = 000;
            }
            else
            {
                this._rollno = rollno;
            }
        }
        public double CgpaPecentage()
        {
            return _cgpa = _cgpa * _cgpa;
        }
        public string GetName()
        {
            return this._name;
        }
        public double GetCgpa()
        {
            return this._cgpa;
        }
        public int GetRillno()
        {
            return this._rollno;
        }
        
    }
}
