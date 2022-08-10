using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookVSLinQ
{
    public partial class FormUser : Form
    {
        private List<Person> persons = new List<Person>();
        public List<Person> Persons { get { return persons; } set { persons = value; } }
        public FormUser()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            persons.Add(completeAdd());
            string data = "";
            for (int i = 0; i < persons.Count; i++)
            {
                data += persons[i].ToString();
            }
            IOFile file = new IOFile();
            file.writeFileBegin(data);
            this.Close();
        }

        public Person completeAdd()
        {
            string name = textBoxName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string typePhone = radioButtonCellPhone.Checked ? "Cell Phone" : "Line Land";
            DateTime time = dateTimePicker1.Value;
            Person person = new Person(name, email, phoneNumber, typePhone, time);

            return person;
        }

    }
}
