using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public enum Mark
    {
        Пять,
        Четыре,
        Три,
        Два
    }
    class Certificate
    {
        private Student _student;
        private Subject _subject;
        private Mark _mark;
        public Certificate(Student student, Subject subject, Mark mark)
        {
            _student = student;
            _subject = subject;
            _mark = mark;
        }
        public Mark mark
        {
            get=> _mark;
        }
        public Student student
        { 
            get => _student;
        }
        public Subject subject
        {
            get => _subject;
        }
        public Student getStudent() 
        {
            return _student;
        }
        public Subject getSubject()
        {
            return _subject;
        }
        public Mark getMark()
        {
            return _mark;
        }


    }
    
}
