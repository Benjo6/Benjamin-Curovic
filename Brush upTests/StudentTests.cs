using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brush_up;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up.Tests
{
    [TestClass()]
    public class StudentTests
    { 
        private Student student = new Student("Ib", "Ølstykke", 1, Gender.Male);
        [TestMethod()]
        public void TestStudentConstructor()
        {
            Student st = new Student("Ib", "Roskilde", 1, Gender.Male);
            Assert.AreEqual("Ib", st.Name);
            Assert.AreEqual("Roskilde", st.Address);
            Assert.AreEqual(Gender.Male, st.Gender);
            Assert.AreEqual(1, st.Semester);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterLav()
        {
            student.Semester = 0;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSemesterHøj()
        {
            student.Semester = 9;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNavnNull()
        {
            student.Name = null;
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNavnKort()
        {
            student.Name = "T";
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddressNull()
        {
            student.Address = null;
        }
    }
}