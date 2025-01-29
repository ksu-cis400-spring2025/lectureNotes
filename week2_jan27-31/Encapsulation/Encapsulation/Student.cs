using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        public string Name { get; }

        public string Major { get; set; } = "Undecided";

        private List<int> _scores = new();

        public void AddScore(int s)
        {
            _scores.Add(s);
        }


        public Student(string name)
        {
            Name = name;
        }
    }
}
