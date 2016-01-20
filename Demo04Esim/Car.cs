using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04Esim
{
    class Car
    {
        //Maxspeed
        private readonly int MaxSpeed = 200;

        //member field
        private int speed;

        //Property
        public int Speed
        {
          get
            {
                return speed;
            }
            set
            {
                if (value <= MaxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much speed. Speed set to MAX");
                    speed = MaxSpeed;
                }
            }
        }

        
    }
}
