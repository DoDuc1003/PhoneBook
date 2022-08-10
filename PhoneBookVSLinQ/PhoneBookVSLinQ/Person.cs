using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookVSLinQ
{
    public class Person
    {
        private string name;
        private string email;
        private string phoneNumber;
        private string typeNumber;
        private DateTime date;
        public Person(string name, string email, string phoneNumber, string typeNumber, DateTime date)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.typeNumber = typeNumber;
            this.date = date;
        }

        public string Name { get { return name; } set { this.name = value; } }
        public string Email { get { return email; } set { this.email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { this.phoneNumber = value; } }
        public string TypeNumber { get { return typeNumber; } set { this.typeNumber = value; } }
        public DateTime Date { get { return date; } set { this.date = value; } }
        public string ToString()
        {
            return this.Name + "\n" +
                this.Email + "\n" +
                this.PhoneNumber + "\n" +
                this.TypeNumber + "\n" +
                this.Date.ToString() + "\n";
        }
    }
}
