using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using personAndBankAccount;

namespace Family
{
    class Family
    {
        private string name;
        private List<Person> members = new List<Person>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public List<Person> Members
        {
            get { return this.members; }
            set { this.members = value; }
        }
        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public void GetOldestMember()
        {
            Person oldest = this.Members.OrderByDescending(x => x.Age).First();

            Console.WriteLine(oldest);

        }
    }
}
