using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Cello : MusicalInstrument
    {
        private string name;
        private string description;

        public Cello(string na, string desc)
        {
            name = na;
            description = desc;
        }
        public void Sound()
        {
            Console.WriteLine("Cello sounds");
        }
        public string Show()
        {
            return name;
        }
        public string Desc()
        {
            return description;
        }
        public void History()
        {
            Console.WriteLine("Cello history...");
        }
    }
}
