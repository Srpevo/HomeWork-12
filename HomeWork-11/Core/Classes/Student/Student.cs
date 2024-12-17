using HomeWork_12.Core.Base.Person;
using HomeWork_12.Core.Interfaces.Istudent;

namespace HomeWork_12.Core.Classes.Student
{
    internal class Student : Person, Istudent
    {

        public Student(int id, string? name, string? surname, string? email, string password, string? universityName) : base(id, name, surname)
        {
            Email = email;
            Password = password;
            UniversityName = universityName;
        }

        public Student() { }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UniversityName { get; set; } 
    }
}
