using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using _9._2.Entity;

namespace _9._2.Servises
{
    internal class SaveToFile

    {
        private string path = string.Empty;
        public SaveToFile(string path) 
        {
            this.path = path;
        }

        public void save(Category category) 
        {
            using (StreamWriter streamWriter = new StreamWriter(this.path, false))
            {
                string json = JsonSerializer.Serialize(category);
                streamWriter.WriteLine(json);
            }
        
        }

        public void save(Good good)
        {
            using (StreamWriter streamWriter = new StreamWriter(this.path, false))
            {
                string json = JsonSerializer.Serialize(good);
                streamWriter.WriteLine(json);
            }

        }

        public void save(string text)
        { }

        public Category load()

        {
            Category category = null;
            using (StreamReader streamReader = new StreamReader(this.path))
            {
                string json = streamReader.ReadLine();
                //category = JsonSerializer.Deserialize<Category>(json);
            }
            return category;
        }
    }
}
