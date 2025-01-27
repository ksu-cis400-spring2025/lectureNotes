using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LabRoom
    {
        //public int Computers = 20;

        //I want a default of 20 computers
        //want to be able to change it to 10-30

        private int _computers = 20;
        public int Computers {
            get
            {
                return _computers;
            }
            set
            {
                if (value >= 10 && value <= 30)
                {
                    _computers = value;
                }
            }
        }

        //public bool Windows = true;

        //only set whether or not Windows when creating
        //the lab

        public bool Windows { get;  } = true;

        public LabRoom(bool useWindows)
        {
            Windows = useWindows;
        }

        //have a drinks policy

        public static bool DrinksAllowed { get; set; }

        static LabRoom()
        {
            DrinksAllowed = true;
        }
    }
}
