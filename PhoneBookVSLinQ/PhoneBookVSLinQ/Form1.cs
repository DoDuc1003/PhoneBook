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
    public partial class Form1 : Form
    {
        private bool reload = false;
        public bool Reload { get { return reload; } set { reload = value; } }
        private FormUser formUser;
        private IOFile file = new IOFile();
        private List<Person> persons = new List<Person>()
        {
            new Person("Do Duc", "duc@gmail.com", "023", "Cell Phone", DateTime.Now),
            new Person("Duc Do", "duc1@gmail.com", "024", "Line Land", DateTime.Now),
            new Person("Lam", "lamconan@gmail.com", "025", "Cell Phone", DateTime.Now),
            new Person("Quang", "quang@gmail.com", "025", "Cell Phone", DateTime.Now),
        };
        public List<Person> Persons { get { return persons; } set { persons = value; } }
        public Form1()
        {
            InitializeComponent();
            this.Load();
        }
        private void Load()
        {
            string data = "";
            for (int i = 0; i < persons.Count; i++)
            {
                Person person = persons[i];
                data += person.ToString();
                dataGridView1.Rows.Add(person.Name, person.Email, person.PhoneNumber, person.TypeNumber, person.Date.ToString(), false);
            }
            file.writeFileBegin(data);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            formUser = new FormUser();
            formUser.Persons = this.Persons;
            formUser.Show();
        }

        public void addPerson(Person person)
        {
            persons.Add(person);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            file.ReadData();
            string[] dataOfFile = file.Data.Split('\n');
            persons = null;
            persons = new List<Person>();
            for (int i = 0; i < dataOfFile.Length / 5; i ++)
            {
                string name = dataOfFile[i * 5 + 0];
                string email = dataOfFile[i * 5 + 1];
                string phone = dataOfFile[i * 5 + 2];
                string typeNumber = dataOfFile[i * 5 + 3];
                DateTime date = DateTime.Parse(dataOfFile[i * 5 + 4]);
                persons.Add(new Person(name, email, phone, typeNumber, date));
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    dataGridView1.Rows.Remove(row);
                }
                catch (Exception) { }
            }
            dataGridView1.Rows.Clear();
            for (int i = 0; i < persons.Count; i ++)
            {
                Person person = persons[i];
                dataGridView1.Rows.Add(person.Name, person.Email, person.PhoneNumber, person.TypeNumber, person.Date.ToString(), false);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<int> listClear = new List<int>();
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            for (int i = 0; i < persons.Count; i ++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                rows.Add(row);
                var x = (bool)row.Cells[5].Value;
                if (x == true)
                {
                    listClear.Add(i);
                    MessageBox.Show(i.ToString());
                }
            }
            DialogResult dialogResult = MessageBox.Show("Sure delete " + listClear.Count, "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                for (int i = listClear.Count - 1; i >= 0; i--)
                {
                    persons.Remove(persons[i]);
                    
                }
                string data = "";
                for (int i = 0; i < persons.Count; i++)
                {
                    Person person = persons[i];
                    data += person.ToString();

                }
                file.writeFileBegin(data);

            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
