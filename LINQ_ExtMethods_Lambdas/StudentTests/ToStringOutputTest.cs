using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentInitializers;
using Students;

namespace StudentTests
{
    [TestClass]
    public class ToStringOutputTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student stud = new Student()
                .AddThreeNames("lala", "papa", "fafa")
                .AddSSN(356444)
                .AddAddress("sesame street");

            Assert.AreEqual("lala papa fafa 356444 sesame street", stud.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            Student stud = new Student()
                .AddThreeNames("lala", "papa", "fafa")
                .AddSSN(356444)
                .AddAddress("sesame street")
                .AddCourse("Traktorizam")
                .AddSpecialty(Specialty.SoftwareArchitechure);

            Assert.AreEqual("lala papa fafa 356444 sesame street Traktorizam SoftwareArchitechure", stud.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            Student stud = new Student()
                .AddThreeNames("lala", "papa", "fafa")
                .AddSSN(356444)
                .AddAddress("sesame street")
                .AddCourse("Traktorizam")
                .AddSpecialty(Specialty.SoftwareArchitechure)
                .AddEmail("lala@kmail.com")
                .AddMobilePhone();

            Assert.AreEqual("lala papa fafa 356444 1111111111 sesame street lala@kmail.com Traktorizam SoftwareArchitechure", stud.ToString());
        }
    }
}
