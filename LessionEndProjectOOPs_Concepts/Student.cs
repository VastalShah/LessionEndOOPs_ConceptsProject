using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LessionEndProjectOOPs_Concepts
{
    class Student : IPerson
    {
        public string Name { get; set; }

        public string ClassAndSection { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name}, Class And Section: {ClassAndSection}";
        }
    }
}
