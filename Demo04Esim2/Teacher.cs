using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04Esim2
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }

        public Teacher(string firstName, string LastName, string room) 
            : base(firstName,LastName)
        {
            Room = room;
        }
        public void TeacherMethod()
        {
            Console.WriteLine("Teacher does something...");
        }
            public override string ToString()
        {
            return base.ToString() + " " + Room;
        }

    }
}
