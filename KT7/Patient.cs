using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT7
{
    class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public Patient()
        {

        }
        public override string ToString()
        {
            return "Patient Firstname: " + FirstName + " Patient Lastname: " + LastName + " Age: " + Age + " Height: " + Height + " Weight: " + Weight + " ";
        }

    }
}
