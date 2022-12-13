using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoLayout
    {
        public bool WriteTask(string filepath, List<string> content)
        { 
            File.AppendAllLines(filepath, content);
            return true;
        } 


        public string RemoveTask(string path, string content)
        {
            File.Delete(content); 
            return content;
        }

        public List<string> ReadTask(string filepath)
        {
            if (!File.Exists(filepath))
                File.Create(filepath);
            return File.ReadAllLines(filepath).ToList();
        }
    }
}
