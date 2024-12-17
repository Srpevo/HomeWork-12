using HomeWork_12.Core.Classes.Student;
using HomeWork_12.Core.Exceptions.InvalidEmailException;
using HomeWork_12.Core.Exceptions.InvalidPasswordException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12.Core.Classes.Login
{
    internal static class StudentLogin
    {
        public static bool Login(List<Student.Student> students, string email, string password)
        {
            var student = students.FirstOrDefault(x => x.Email == email);

            if (student == null)
                throw new InvalidEmailException("Invalid Email");

            if (student.Password != password)
                throw new InvalidPasswordException("Invalid Password");

            return true;
        }

    }
}
