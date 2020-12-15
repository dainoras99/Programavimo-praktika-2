using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademinė_sistema
{
    class Grade
    {
        public int Id { get; private set; }
        public int grade { get; private set; }
        public DateTime Date { get; private set; }
        public int Studentid { get; private set; }
        public int Subjectid { get; private set; }

        public Grade(int id, int grade, DateTime date, int studentid, int subjectid)
        {
            Id = id;
            this.grade = grade;
            Date = date;
            Studentid = studentid;
            Subjectid = subjectid;
        }
    }
}
