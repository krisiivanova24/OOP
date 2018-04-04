using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theOldestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            List<Person> all = new List<Person>();
            List<string> inputs = new List<string>();            
            for (int i = 0; i < num; i++)
            {
                string line = Console.ReadLine();
                inputs.Add(line);                
            }

            for (int i = 0; i < inputs.Count; i++)
            {

            }
        }
    }
}
