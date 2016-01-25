using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT7
{
    class Doctor : Patient
    {
        private string v;

        public string Dname { get; set; }

        public Doctor()
        {

        }
        public Doctor(string dname)
        {
            Dname = dname;
            
        }
        public override string ToString()
        {
            return Dname;
        }
    }
}
