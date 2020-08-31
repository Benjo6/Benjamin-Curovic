using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brush_up;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        private Teacher teacher = new Teacher("Ib", "Ølstykke", 1, Gender.Male);
        [TestMethod()]
        public void TestTeacherConstructor()
        {
            Teacher t = new Teacher("Ib", "Roskilde", 1, Gender.Male);
            Assert.AreEqual("Ib", t.Name);
            Assert.AreEqual("Roskilde", t.Address);
            Assert.AreEqual(Gender.Male, t.Gender);
            Assert.AreEqual(1, t.Salary);
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSalaryLow()
        {
            teacher.Salary = -1;
        }
    }
}