using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Trombone : MusicalInstrument
    {
        private string name;
        private string description;

        public Trombone(string na, string desc)
        {
            name = na;
            description = desc;
        }
        public void Sound()
        {
            Console.WriteLine("Trombone sounds");
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
            Console.WriteLine("Trombone history...");
        }
    }
}
