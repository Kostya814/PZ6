using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public Student(string name) 
        { 
            _name = name;
        }
        private string _name;
        public string Name
        { 
            get =>  _name; 
        }
    }
}
