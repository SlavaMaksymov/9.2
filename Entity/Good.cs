using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2.Entity
{
    internal class Good
    {
        int id { get; set; }
        string name { get; set; }
        double price { get; set; }
        string link { get; set; }

        public Good(string name, double price) {
            id = (new Random()).Next(1, 1000);
            this.name = name;
            this.price = price;
        }

        public string GetName(Good good)
        {
            return name;
        }
    }
}
