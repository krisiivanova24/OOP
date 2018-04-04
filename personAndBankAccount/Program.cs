using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAndBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, double> accs = new Dictionary<int, double>();
            //List<string> all = new List<string>();
            //string input = Console.ReadLine();
            //while (input != "End")
            //{
            //    all.Add(input);
            //    input = Console.ReadLine();
            //}
            //List<string> split = new List<string>();
            //int id = 0;
            //bool hh = true;
            //for (int i = 0; i < all.Count; i++)
            //{
            //    split = all[i].Split(' ').ToList();
            //    switch (split[0])
            //    {
            //        case "Creat":
            //            {
            //                if (!accs.ContainsKey(int.Parse(split[1])))
            //                {
            //                    BankAccount smetka = new BankAccount();
            //                    smetka.ID = int.Parse(split[1]);
            //                    smetka.Balance = 0;
            //                    accs[smetka.ID] = smetka.Balance;


            //                }
            //                break;
            //            }
            //        case "Deposit": {
            //                double rr = 0.0;
            //                if (accs.ContainsKey(int.Parse(split[1])))
            //                {
            //                    hh = accs.TryGetValue(int.Parse(split[1]), out rr);
            //                }
                            
            //                break;
            //            }

            //    }
            //}
            Person human = new Person();
            human.Name = Console.ReadLine();
            human.Age = int.Parse(Console.ReadLine());

            BankAccount humanS = new BankAccount();
            humanS.ID = int.Parse(Console.ReadLine());
            humanS.Balance = double.Parse(Console.ReadLine());

            humanS.Deposit(double.Parse(Console.ReadLine()));
            humanS.WithDraw(double.Parse(Console.ReadLine()));

            human.Accounts.Add(humanS);
            human.Introduce();
            human.ShowBalance(); ;



            Person human2 = new Person();
            human2.Name = Console.ReadLine();
            human2.Age = int.Parse(Console.ReadLine());

            BankAccount human2S = new BankAccount();
            human2S.ID = int.Parse(Console.ReadLine());
            human2S.Balance = double.Parse(Console.ReadLine());

            human2S.Deposit(double.Parse(Console.ReadLine()));
            human2S.WithDraw(double.Parse(Console.ReadLine()));

            human2.Accounts.Add(human2S);
            human2.Introduce();
            human2.ShowBalance();

        }
    }
}
