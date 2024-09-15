using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Product : Money
    {
        private string name;
        private Money price;
        public Product(string na, int un, int ce) : base(un,ce)
        {
            name = na;
            price = new Money(un, ce);
        }
        public void DecreasePrice(int un, int ce)
        {
            price.DecreaseMoney(un, ce);
        }
        public void ShowProduct()
        {
            Console.WriteLine($"Product: {name}");
            price.ShowMoney();
        }
    }
}
