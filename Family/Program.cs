using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personAndBankAccount;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            Family group = new Family();
            for (int i = 0; i < n; i++)
            {                
                string[] input = Console.ReadLine().Split().ToArray();
                Person newP = new Person();
                newP.Name = input[0];
                newP.Age = int.Parse(input[1]);
                group.AddMember(newP);

            }
           // Person kris = new Person();
           // kris.Name = "Kristina";
           // kris.Age = 16;

           // Person toni = new Person();
           // toni.Name = "Antonina";
           // toni.Age = 10;

           // Person kati = new Person();
           // kati.Name = "Kati";
           // kati.Age = 24;

           // Person toli = new Person();
           // toli.Name = "Toli";
           // toli.Age = 3;

            
           // group.AddMember(kris);
           // group.AddMember(toni);
           // group.AddMember(kati);
           // group.AddMember(toli);
           //// kati.Introduce();
            group.GetOldestMember();

            group.Members.OrderBy(x => x.Name)
                           .ThenBy(x => x.Age)
                           .ToList()
                           .ForEach(x => Console.WriteLine(x));
        }
    }
}
