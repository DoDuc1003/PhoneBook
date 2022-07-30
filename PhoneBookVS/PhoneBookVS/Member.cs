using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookVS
{
    public class Member
    {
        private string name;
        private PhoneNumber phone_number;
        private string email;
        public DateTime date_of_birth;
        public Member(string name, PhoneNumber phone_number, string email, DateTime date_of_birth)
        {
            this.name = name;
            this.phone_number = phone_number;
            this.email = email;
            this.date_of_birth = date_of_birth;
        }

        public string getName()
        {
            return this.name;
        }

        public PhoneNumber getPhoneNumber()
        {
            return this.phone_number;
        }

        public string getEmail()
        {
            return this.email;
        }

        public DateTime GetDateOfBirth()
        {
            return this.date_of_birth;
        }

        public string ToString()
        {
            return name + "\n" + phone_number.ToString() + "\n" + email + "\n" + date_of_birth;
        }
    }

    public class PhoneNumber
    {
        private string phone_number;
        private string type_phone;
        public PhoneNumber(string phone_number, string type_phone)
        {
            this.phone_number = phone_number;
            this.type_phone = type_phone;
        }
        public string getPhoneNumber()
        {
            return phone_number;
        }

        public string getTypePhone()
        {
            return type_phone;
        }

        public void setPhoneNumber(string new_phone_number)
        {
            this.phone_number = new_phone_number;
        }

        public void setTypeNumber(string new_type_phone)
        {
            this.type_phone = new_type_phone;
        }
        
        public string ToString()
        {
            return this.getPhoneNumber() + "\n" + this.getTypePhone();
        }
    }
}
