using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Kettle : Device
    {
        public Kettle(string na, string desc) : base(na,desc)
        {
            name = na;
            description = desc;
        }
        public override void Sound()
        {
            Console.WriteLine("Kettle is boiling");
        }
        public override string Show()
        {
            return name;
        }
        public override string Desc()
        {
            return description;
        }
    }
}
