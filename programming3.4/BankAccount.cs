﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
    class BankAccount
    {
        int id;
        double balance;

        public int ID {
            get { return this.id; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Inavlid ID!!!!");
                }
                this.id = value; }
        }
        public double Balance {
            get { return this.balance; }
            set {
                if (balance < 0)
                {
                    Console.WriteLine("Inavlid balance!!!!");
                }
                this.balance = value; }
        }

        public void Deposit(double amount) {
            this.balance += amount;
        }
        public void Withdraw(double amount) {
            this.balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Your ID is {id}, your balance is {balance}");
        }
    }
}
