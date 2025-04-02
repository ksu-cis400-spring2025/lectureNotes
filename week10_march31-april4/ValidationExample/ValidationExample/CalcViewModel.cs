using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class CalcViewModel : INotifyPropertyChanged
    {

        private uint _shirts = 0;
        public uint Shirts
        {
            get => _shirts;
            set
            {
                
                if (value > 10)
                {
                    _shirts = 0;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));
                    throw new InvalidOperationException("shirts must be 0-10");
                }

                _shirts = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));


                //throw exception if #shirts is invalid (more than 10)

                //how to make sure cost is updated on GUI?
            }
        }

        public decimal Cost
        {
            get
            {
                //$10 each for up to 5 shirts, $8 each after that
                if (Shirts <= 5) return 10 * Shirts;
                else return 5 * 10 + (Shirts - 5) * 8;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
