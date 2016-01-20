using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04Esim2
{
    class Student : Person
    {
        public string Studentid { get; set; }

        public Student()
         {
         }
        public Student(string firstname,string lastname,string studentidi) 
            : base(firstname,lastname)
        {
            Studentid = studentidi;
        }
        public void StudentMethod()
        {
            Console.WriteLine("Student does something...");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Studentid;
        }
    }
}
