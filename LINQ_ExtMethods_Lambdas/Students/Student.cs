using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public enum Specialty    { CST, SoftwareArchitechure, Cleaner    }

    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public int MobilePhone { get; set; }
        public string PermanentAddress { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty? Specialty { get; set; }

        public Student()
        {

        }

        public Student(string firstName, string secondName, string lastName, string permanentAddress, int SSN, int mobilePhone,
                        string email, string course, Specialty spec)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.MobilePhone = mobilePhone;
            this.PermanentAddress = permanentAddress;
            this.Email = email;
            this.Course = course;
            this.Specialty = spec;
        }

        public override string ToString()
        {
            StringBuilder messageBuilder = new StringBuilder();

            messageBuilder.AppendWithSpace(FirstName);
            messageBuilder.AppendWithSpace(SecondName);
            messageBuilder.AppendWithSpace(LastName);
            messageBuilder.AppendWithSpace(SSN.ToString());

            if(MobilePhone != 0)
                messageBuilder.AppendWithSpace(MobilePhone.ToString());

            if(PermanentAddress != null)
                messageBuilder.AppendWithSpace(PermanentAddress);

            if(Email != null)
                messageBuilder.AppendWithSpace(Email);

            if(Course != null)
                messageBuilder.AppendWithSpace(Course);

            if(Specialty != null)
                messageBuilder.AppendWithSpace(Specialty.ToString());
            
            return messageBuilder.ToString().Trim();
        }
    }
}
