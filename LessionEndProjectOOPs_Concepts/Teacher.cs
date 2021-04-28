using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndProjectOOPs_Concepts
{
    public class Teacher : Subject, IPerson
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Class And Section: {ClassAndSection}, Subject Name: {SubjectName}, Subject Code: {SubjectCode}";
        }
    }
}
