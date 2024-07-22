using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2.Entity
{
    public class Good
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string link { get; set; }

        public Good(string name, double price) {
            id = (new Random()).Next(1, 1000);
            System.Threading.Thread.Sleep(1000);
            this.name = name;
            this.price = price;
        }

        public string GetName(Good good)
        {
            return name;
        }
    }
}
