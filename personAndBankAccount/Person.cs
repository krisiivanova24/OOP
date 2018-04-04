using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personAndBankAccount
{
    class Person
    {
        private string name;
        private int age;
        List<BankAccount> accounts = new List<BankAccount>();
        
        public List<BankAccount> Accounts {
            get { return this.accounts; }
            set { this.accounts = value; }
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age {
            get { return this.age; }
            set { this.age = value; }
        }
        public void Introduce() {
            Console.WriteLine($"Name {name } - age {age}");
        }
        public void ShowBalance() {
            double suma = 0;
        for (int i = 0; i<this.Accounts.Count; i++)
			{
                suma += this.Accounts[i].Balance;
			}
            Console.WriteLine($"Balance for {this.Name} is {suma:f2}");
        }
    }
}
