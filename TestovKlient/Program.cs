using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personAndBankAccount;

namespace TestovKlient
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> acc = new Dictionary<int, BankAccount>();
            string[] input = Console.ReadLine().Split().ToArray();
            string command = input[0];
            while (command != "End")
            {
                switch (command)
                {
                    case "Create":
                        {
                            if (acc.ContainsKey(int.Parse(input[1])))
                            {
                                Console.WriteLine("Account already exists");
                            }
                            else
                            {
                                BankAccount newAcc = new BankAccount(int.Parse(input[1]));
                                acc.Add(newAcc.ID, newAcc);
                            }
                            break;
                        }
                    case "Deposit":
                        {
                            int nomerSmetchica = int.Parse(input[1]);
                            double money = double.Parse(input[2]);
                            if (acc.ContainsKey(nomerSmetchica))
                            {
                                acc[nomerSmetchica].Deposit(money);//acc[nomerSmetchica] = value!!!!!!!!!!
                            }
                            else
                            {
                                Console.WriteLine("Account already exists");
                            }
                            break;
                        }
                    case "Withdraw":
                        {
                            int nomerSmetchica = int.Parse(input[1]);
                            double money = double.Parse(input[2]);
                            //Console.WriteLine(money);
                            if (acc.ContainsKey(nomerSmetchica))
                            {
                                if (acc[nomerSmetchica].Balance < money)
                                {
                                    Console.WriteLine("Insufficient balance");
                                }
                                else
                                {
                                    //Console.WriteLine("vliza");
                                    acc[nomerSmetchica].WithDraw(money);//acc[nomerSmetchica] = value!!!!!!!!!!
                                }

                            }
                            else
                            {
                                Console.WriteLine("Account already exists");
                            }
                            break;
                        }
                    case "Print":
                        {
                            int nomerSmetchica = int.Parse(input[1]);

                            if (acc.ContainsKey(nomerSmetchica))
                            {
                                acc[nomerSmetchica].Print();//acc[nomerSmetchica] = value!!!!!!!!!!
                            }
                            else
                            {
                                Console.WriteLine("Account already exists");
                            }
                            break;
                        }

                }
                input = Console.ReadLine().Split().ToArray();
                command = input[0];
            }

        }

    }
}
