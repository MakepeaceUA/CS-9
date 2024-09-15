using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Money
    {
        private int units;
        private int cents;
        public Money(int un = 0, int ce = 0)
        {
            units = un;
            cents = ce;
            Normalize();
        }
        public void ShowMoney()
        {
            Console.WriteLine($"{units}.{cents}");
        }
        public void SetMoney(int un, int ce)
        {
            units = un;
            cents = ce;
            Normalize();
        }
        private void Normalize()
        {
            if (cents >= 100)
            {
                units += cents / 100;
                cents = cents % 100;
            }
            else if (cents < 0)
            {
                units -= (Math.Abs(cents) / 100) + 1;
                cents = 100 - (Math.Abs(cents) % 100);
            }
        }
        public void DecreaseMoney(int un, int ce)
        {
            units -= un;
            cents -= ce;
            Normalize();
        }
    }
}
