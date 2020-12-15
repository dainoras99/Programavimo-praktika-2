using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    public class Subject
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public Subject(int id, string title, string description)
        {
            Id = id;
            Description = description;
            Title = title;
        }
    }
}
