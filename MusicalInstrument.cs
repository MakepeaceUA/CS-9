using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal interface MusicalInstrument
    {
        public abstract void Sound();
        public abstract string Show();
        public abstract string Desc();
        public abstract void History();
    }
}
