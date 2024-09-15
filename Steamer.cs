using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Steamer : Device
    {
        private string name;
        private string descriprion;

        public Steamer(string na, string desc) : base(na, desc)
        {
            name = na;
            descriprion = desc;
        }
        public override void Sound()
        {
            Console.WriteLine("Steamer is swiming");
        }
        public override string Show()
        {
            return name;
        }
        public override string Desc()
        {
            return descriprion;
        }
    }
}
