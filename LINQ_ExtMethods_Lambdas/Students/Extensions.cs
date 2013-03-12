using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students;

namespace StudentInitializers
{
    public static class StudentInitializers
    {
        public static Student AddThreeNames(this Student student, string first, string second, string last)
        {
            student.FirstName = first;
            student.SecondName = second;
            student.LastName = last;
            return student;
        }

        public static Student AddFirstName(this Student student, string first)
        {
            student.FirstName = first;
            return student;
        }

        public static Student DefaultThreeNames(this Student student)
        {
            student.FirstName = "AAA";
            student.SecondName = "BBB";
            student.LastName = "CCC";
            return student;
        }

        public static Student AddSSN(this Student student, int SSN = 99999999)
        {
            student.SSN = SSN;
            return student;
        }

        public static Student AddMobilePhone(this Student student, int mobPhone = 1111111111)
        {
            student.MobilePhone = mobPhone;
            return student;
        }

        public static Student AddAddress(this Student student, string address = "default")
        {
            student.PermanentAddress = address;
            return student;
        }

        public static Student AddEmail(this Student student, string email = "default")
        {
            student.Email = email;
            return student;
        }

        public static Student AddCourse(this Student student, string course = null)
        {
            student.Course = course;
            return student;
        }

        public static Student AddSpecialty(this Student student, Specialty spec)
        {
            student.Specialty = spec;
            return student;
        }

    }
}

namespace Students
{
    public static class StringBuilderExtensions
    {
        public static void AppendWithSpace(this StringBuilder builder, string message)
        {
            builder.Append(message);
            builder.Append(" ");
        }
    }
}