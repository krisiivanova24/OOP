using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testClient
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            string[] inputs = Console.ReadLine().Split(' ').ToArray();
            string command = inputs[0];
            switch (command)
            {
                case "Creat": {
                        BankAccount smetka = new BankAccount();
                        smetka.ID = int.Parse(inputs[1]);
                        smetka.Balance = 0;
                        
                        accounts.Add(smetka);
                        break;
                }
                case "Deposit": {
                        int nomerSmetka = int.Parse(inputs[1]);
                        double amount = double.Parse(inputs[2]);
                        if (accounts.IndexOf(nomerSmetka) != -1)
                        {

                        }
                        break;
                }
            }
            BankAccount smetchica = new BankAccount();
            smetchica.Deposit(100);
            smetchica.Withdraw(52);
            Console.WriteLine(smetchica.Balance);
        }
    }
}
