using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount smetchica = new BankAccount();
            smetchica.Deposit(100);
            smetchica.Withdraw(52);
            Console.WriteLine(smetchica.Balance);

            Person Aleks = new Person();
            Aleks.Name = "Александра Христова";
            Aleks.Age = 17;
            Aleks.IntroduceYourself();
            BankAccount Aleks2 = new BankAccount();
            Aleks2.ID = 1;
            Aleks2.Balance = 2500;
            Aleks.Accounts.Add(Aleks2);
            Aleks.ShowBalance();


            Person Geri = new Person();
            Geri.Name = "Гергана";
            Geri.Age = 17;
            Geri.IntroduceYourself();
            BankAccount Geri2 = new BankAccount();
            Geri2.ID = 2;
            Geri2.Balance = 1000;
            Geri.Accounts.Add(Geri2);
            Geri.ShowBalance();


            Person Kris = new Person();
            Kris.Name = "Кристина";
            //Kris.Age = 16;
            Kris.IntroduceYourself();
            BankAccount Kris2 = new BankAccount();
            Kris2.ID = 3;
            Kris2.Balance = 2000;
            Kris.Accounts.Add(Kris2);
           // Kris2.Print();
            Kris.ShowBalance();

            //Person unknown = new Person();
            //Console.WriteLine("Кое е твоето име?");
            //unknown.Name = Console.ReadLine();
            //Console.WriteLine("Имаш ли 17?");
            //Console.WriteLine($"Ти си {unknown.Name}!!");


        }
    }
}
