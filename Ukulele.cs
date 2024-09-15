using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Ukulele : MusicalInstrument
    {
        private string name;
        private string description;

        public Ukulele(string na, string desc)
        {
            name = na;
            description = desc;
        }
        public void Sound()
        {
            Console.WriteLine("Ukulele sounds");
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
            Console.WriteLine("Ukulele history...");
        }
    }
}
