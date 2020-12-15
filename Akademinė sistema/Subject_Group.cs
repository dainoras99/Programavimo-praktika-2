using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    class Subject_Group
    {
        public int Group_id { get; private set; }
        public int Subject_id { get; private set; }
        public Subject_Group(int group_id, int subject_id)
        {
            Group_id = group_id;
            Subject_id = subject_id;
        }
    }
}
