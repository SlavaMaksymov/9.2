using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _9._2.Entity;
using _9._2.Servises;


namespace _9._2

{
    internal class Program
    
    {
        static void Main(string[] args)

        {
            Category toysCategory = new Category("toys");
            List<Good> products = new List<Good>();

            Good ball = new Good("ball", 300);

            Good doll = new Good("doll", 400);

            Good duck = new Good("duck", 50);


            toysCategory.AddGoods(ball);
            toysCategory.AddGoods(doll);
            toysCategory.AddGoods(duck);

            toysCategory.ShowGoods();

            string relPath = "../../SaveCategory.json";

            SaveToFile saveToFile = new SaveToFile(relPath);
            //saveToFile.save(doll);
            saveToFile.save(toysCategory);
        }
    }
}
