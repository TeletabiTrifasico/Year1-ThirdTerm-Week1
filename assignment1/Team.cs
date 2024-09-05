using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment1
{
    internal class Team
    {
        public List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }
        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }
        public void PrintAllTeamMembers()
        {
            foreach (Programmer programmer in programmers)
            {
                programmer.Print();
            }
        }
    }
}
