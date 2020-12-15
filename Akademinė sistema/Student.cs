using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Student(int id, string name, string surname, DateTime birthDate, string username, string password)
        {
            Validation(name, surname, birthDate);
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Username = username;
            Password = password;
        }
        public void Validation(string name, string surname, DateTime birthDate)
        {
            if (name.Trim(' ').Equals(""))
                throw new Exception("Laukai negali likti tušti");
            if (surname.Trim(' ').Equals(""))
                throw new Exception("Laukai negali likti tušti");
            if (DateTime.Now < birthDate)
                throw new Exception("Bloga data");
        }
    }
}
