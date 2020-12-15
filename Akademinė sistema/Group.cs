using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    public class Group
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
