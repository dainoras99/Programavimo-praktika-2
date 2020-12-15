using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    public class Professor : Student
    {
        public string degree { get; private set; }
        public Professor(int id, string degree, string name, string surname, DateTime birthDate, string username, string password) : base(id, name, surname, birthDate, username, password)
        {
            this.degree = degree;
        }
    }
}
