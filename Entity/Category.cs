using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _9._2.Entity
{
    internal class Category
    {
        int id;
        string name;

        List<Good> products;

        public Category (string name) 
        {
            id = (new Random()).Next(1, 100);
            this.name = name;
            products = new List<Good>();
        }
    }
}
