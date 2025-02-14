using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Snake : IAnimal
    {
        public uint Legs => throw new NotImplementedException();

        public string Sound()
        {
            throw new NotImplementedException();
        }
    }
}
