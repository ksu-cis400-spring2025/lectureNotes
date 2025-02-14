using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Dog : IAnimal
    {
        public string Sound()
        {
            return "Woof";
        }

        public uint Legs { get; } = 4;

        public string Name { get; init; }

        //add PeopleYears property
        //0 dog -> 0 person
        //1 dog -> 15 person
        //2 dog -> 24 person
        //3 dog -> 29 person
        //4 dog -> 34 person
        //5 dog -> 39 person
        //etc.
    }
}