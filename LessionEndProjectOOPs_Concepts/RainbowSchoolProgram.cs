using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndProjectOOPs_Concepts
{
    class RainbowSchoolProgram
    {
        public static void Do()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student() { Name = "Vatsal", ClassAndSection = "CSE-A" });
            students.Add(new Student() { Name = "Ajay", ClassAndSection = "CSE-B" });
            students.Add(new Student() { Name = "Yogesh", ClassAndSection = "CSE-F" });
            students.Add(new Student() { Name = "Rashi", ClassAndSection = "CSE-E" });

            Console.WriteLine("\nStudents in a class\n");
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetInfo());
            }

            List<Teacher> teachers = new List<Teacher>();

            teachers.Add(new Teacher() { Name = "Madhu", ClassAndSection = "CSE-B", SubjectCode = 101, SubjectName = "Maths" });
            teachers.Add(new Teacher() { Name = "Amit", ClassAndSection = "CSE-A", SubjectCode = 345, SubjectName = "DBMS" });
            teachers.Add(new Teacher() { Name = "Bibek", ClassAndSection = "CSE-F", SubjectCode = 543, SubjectName = "Data Structures" });
            teachers.Add(new Teacher() { Name = "Mayank", ClassAndSection = "CSE-E", SubjectCode = 222, SubjectName = "DAA" });

            Console.WriteLine("\nSubjects taught by a teacher\n");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.GetInfo());
            }
        }
    }
}
