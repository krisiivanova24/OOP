using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming3._4
{
     class Person
    {
        //harakteristiki na klasa
        private string name;
        private int age=16 ;
        private List<BankAccount> accounts ;

         public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }
        //pechat
        public void IntroduceYourself()
        {
            Console.WriteLine($"Аз се казвам {name} и съм на {age}");
        }

        //sumira vs smetki
        public void ShowBalance() {
            double suma = 0;
            for (int i = 0; i < this.Accounts.Count; i++)
            {
                suma += this.Accounts[i].Balance;
            }
            Console.WriteLine($"Balance for {this.Name} is {suma:f2}");
        }

    }
    }

