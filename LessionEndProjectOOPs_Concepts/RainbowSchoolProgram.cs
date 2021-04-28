using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndProjectOOPs_Concepts
{
    public class RainbowSchoolProgram
    {
        static List<Student> student1 = new List<Student>();
        static List<Teacher> teacher1 = new List<Teacher>
        {
            new Teacher() { Name = "Madhu", ClassAndSection = "CSE-B", SubjectCode = 101, SubjectName = "Maths" },
            new Teacher() { Name = "Amit", ClassAndSection = "CSE-A", SubjectCode = 345, SubjectName = "DBMS" },
            new Teacher() { Name = "Bibek", ClassAndSection = "CSE-F", SubjectCode = 543, SubjectName = "Data Structures" },
            new Teacher() { Name = "Mayank", ClassAndSection = "CSE-E", SubjectCode = 222, SubjectName = "DAA" }
        };

        public static string AddStudent(Student student)
        {
            student1.Add(new Student() { Name = student.Name, ClassAndSection = student.ClassAndSection});
            return "Data added successfully";
        }

        public static List<Student> GetStudentData()
        {
            return student1;
        }

        public static string AddTeacher(Teacher teacher)
        {
            teacher1.Add(new Teacher() { Name = teacher.Name, ClassAndSection = teacher.ClassAndSection, SubjectCode = teacher.SubjectCode, SubjectName = teacher.SubjectName });
            return "Added Data Successfully";
        }

        public static List<Teacher> GetTeacherData()
        {
            return teacher1;
        }
    }
}
