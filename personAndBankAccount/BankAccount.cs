using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAndBankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;


        public int ID
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inavlid ID!!!!");
                }
                this.id = value;
            }
        }
        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (balance < 0)
                {
                    Console.WriteLine("Inavlid balance!!!!");
                }
                this.balance = value;
            }
        }
        public void Deposit(double sum)
        {
            this.Balance += sum;
        }
        public void WithDraw(double sum)
        {
            this.Balance -= sum;
        }

        public void Print()
        {
            Console.WriteLine($"Your ID is {this.ID}, your balance is {this.Balance}");
        }
        public BankAccount(int id)
        {
            this.ID = id;
            this.Balance = 0;
        }
        public BankAccount() {

        }
    }
}
