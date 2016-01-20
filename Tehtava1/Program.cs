using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            Console.WriteLine("You are at floor 1 ");
            while (true)
            {
                Console.Write("Which floor you wanna go? Choose between 1-5.");
                elevator.Floor = int.Parse(Console.ReadLine());
            }
        }
    }
}
