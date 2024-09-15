using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car : Device
    {
        private string name;
        private string descriprion;

        public Car(string na, string desc) : base(na, desc)
        {
            name = na;
            descriprion = desc;
        }
        public override void Sound()
        {
            Console.WriteLine("Car is coming");
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
