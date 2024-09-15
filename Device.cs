using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Device
    {
        public string name;
        public string description;
        public Device(string na,string desc)
        {
            name = na;
            description = desc;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound.");
        }
        public virtual string Show()
        {
            return name;
        }
        public virtual string Desc()
        {
            return description;
        }
    }
}
