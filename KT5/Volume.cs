using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5
{
    class Volume
    {
        private int MaxVolume = 9;
        private int LowVolume = 0;
        private int volume;

        public int Volumee
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume && value >= LowVolume)
                {
                    volume = value;
                }
                else
                {
                    Console.WriteLine("Thats not possible!!! ");
                    volume = LowVolume;
                }
            }
        }
    }
}
