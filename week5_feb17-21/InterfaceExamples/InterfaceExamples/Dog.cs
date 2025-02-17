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

        //want legs to be 2-4

        private uint _legs = 4;
        public uint Legs
        {
            get => _legs;
            set
            {
                if (value >= 2 && value <= 4)
                {
                    _legs = value;
                }
            }
        }

        public string Name { get; init; }

        public uint Age { get; set; } = 0;

        //derived property - value comes from
        //other fields/properties

        public uint PeopleYears
        {
            get
            {
                if (Age == 0) return 0;
                else if (Age == 1) return 15;
                else
                {
                    return 24 + 5 * (Age-2);
                }
            }
        }

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