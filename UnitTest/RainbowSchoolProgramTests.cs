using NUnit.Framework;
using LessionEndProjectOOPs_Concepts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LessionEndProjectOOPs_Concepts.Tests
{
    [TestFixture()]
    public class RainbowSchoolProgramTests
    {
        [Test()]
        public void AddStudentTest()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Vatsal",
                ClassAndSection = "CSE-A"
            };
            string expectedResult = "Data added successfully";
            //Act
            string result = RainbowSchoolProgram.AddStudent(student);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]
        public void GetStudentDataTest()
        {
            var result = RainbowSchoolProgram.GetStudentData();

            Assert.IsTrue(result.Count == 1);
        }

        [Test()]
        public void DeleteStudentTest()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Vatsal",
                ClassAndSection = "CSE-A"
            };

            //Act
            var result = RainbowSchoolProgram.DeleteStudentData(student);

            //Assert
            Assert.IsTrue(result);
        }

        [Test()]
        public void AddTeacherTest()
        {
            //Arrange
            Teacher teacher = new Teacher()
            {
                Name = "Amit Kumar Mishra",
                ClassAndSection = "CSE-A",
                SubjectName = "DBMS",
                SubjectCode = 342
            };
            string expectedResult = "Added Data Successfully";
            //Act
            string result = RainbowSchoolProgram.AddTeacher(teacher);
            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]
        public void GetTeacherDataTest()
        {
            var result = RainbowSchoolProgram.GetTeacherData();

            Assert.IsTrue(result.Count == 5);
        }
    }
}