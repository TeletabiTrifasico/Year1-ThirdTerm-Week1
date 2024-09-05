using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Programmer
    {
        public string name;
        public Specialty specialty;

        public Programmer(string name)
        {
            this.name = name;
            this.specialty = Specialty.Unknown;
        }
        public Programmer(string name, Specialty specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Specialty: {specialty}");
        }
    }
}
