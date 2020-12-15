using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    public class Admin : Student
    {
        public Admin(int id, string name, string surname, DateTime birthDate, string username, string password) : base(id, name, surname, birthDate, username, password)
        {

        }
    }
}
