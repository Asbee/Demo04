using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            Patient patient = new Patient();
            Doctor doctor = new Doctor("Matti Meikalainen");

            while(true)
            {
                Console.WriteLine("Hospital Database");
                Console.WriteLine("1. Add your patient info ");
                Console.WriteLine("2. Go to see doctor and check your patient data. ");
                Console.WriteLine("3. Exit Hospital ");
                Console.Write("Choose :" );
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (n1 == 1)
                {
                    Console.Write("First Name: ");
                    patient.FirstName = Console.ReadLine();
                    Console.Write("Last Name: ");
                    patient.LastName = Console.ReadLine();
                    Console.Write("Age: ");
                    patient.Age = int.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    patient.Height = int.Parse(Console.ReadLine());
                    Console.Write("Weight: ");
                    patient.Weight = int.Parse(Console.ReadLine());

                }
                if (n1 == 2)
                {
                    Console.WriteLine("Doctor is checking your patient info...");
                    Console.WriteLine("Doctor name is: " + doctor.ToString());
                    Console.WriteLine(patient.ToString());
                }
                if (n1 == 3)
                {
                    Console.WriteLine("You left hospital");
                    break;
                }
            }

        }
    }
}
