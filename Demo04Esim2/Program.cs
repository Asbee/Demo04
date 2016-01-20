using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04Esim2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = "Kirsi";
            person.LastName = " Pernel";
            person.Age = 20;
            person.Address = " Kuja 20";
            person.PhoneNumber = " 0094405";
            Console.WriteLine(person.ToString());

            Teacher teacher = new Teacher("Jussi","Konsoli","456");
            teacher.Address = "asdsadsad";
            teacher.Age = 40;
            teacher.PhoneNumber = "040440";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Kalle", "Mallikas", "12323");
            student.Address = "koaskdo 20";
            student.Age = 20;
            student.PhoneNumber = "040404";
            Console.WriteLine(student.ToString());



            Console.WriteLine("Press enter to continue ");
            Console.ReadLine();

            
        }
    }
}
