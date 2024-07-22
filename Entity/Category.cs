using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _9._2.Entity
{
    internal class Category
    {
        int id { get; set; }
        string name { get; set; }

        public static List<Good> products { get; set; }

        public Category (string name) 
        {
            id = (new Random()).Next(1, 100);
            this.name = name;
            products = new List<Good>();
            
        }

        public void ShowGoods(List<Good> elements) {
            for (int i=0; i < products.Count; i++)
                Console.WriteLine(products[i].GetName(products[i]));
        }

        public void AddGoods(Good good) {
            
            products.Add(good);
        }

    }
}
