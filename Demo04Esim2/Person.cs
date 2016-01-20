﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04Esim2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age {get;set;}
        public string PhoneNumber { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public  void Personmethod()
        {
            Console.WriteLine("Person does something...");
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Age + " " + Address + " " + PhoneNumber + " ";
        }


        

        
        
    }
}