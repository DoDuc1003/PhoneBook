using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookVS;
namespace PhoneBookVS
{
    public partial class Form1 : Form
    {
        List<Member> member = new List<Member>();
        //public static Form Instance;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void doSomething()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    dataGridView1.Rows.Remove(row);
                }
                catch (Exception) { }
            }
            dataGridView1.Rows.Clear();
            member = null;
            member = new List<Member>();
            SaveFileTxt txt = new SaveFileTxt();
            string[] data = txt.getData().Split('\n');
            for (int i = 0; i < data.Length / 5; i++)
            {
                string name = data[5 * i + 0];
                string phone_number = data[5 * i + 1];
                string type = data[5 * i + 2];
                string email = data[5 * i + 3];
                
                //string dt = data[5 * i + 4].Split(' ')[0];
                DateTime dt1 = Convert.ToDateTime(data[5 * i + 4]);
                Member newMenber = new Member(name, new PhoneNumber(phone_number, type), email, dt1);
                member.Add(newMenber);
                dataGridView1.Rows.Add((i + 1).ToString(), name, phone_number, type, email, dt1);
            }

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("click double this here");
        }


        private void ButtonAddClick(object sender, EventArgs e)
        {            
            string name = this.textBox1.Text;
            DateTime dt = dateTimePicker1.Value.Date;
            string type = this.textBox3.Text;
            string phone_number = this.textBox2.Text;
            Member member = new Member(name, new PhoneNumber(phone_number, type), "abc@gmail.com", dt);
            dataGridView1.Rows.Add("xx", member.getName(), member.getPhoneNumber().getPhoneNumber(),
                member.getPhoneNumber().getTypePhone(), member.getEmail(), member.GetDateOfBirth().Day);
        }

        protected void GridView1_SelectedIndexChanging(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("double in header row " + e.RowIndex);
            Form2 form = new Form2();
            int row = e.RowIndex;
            //dataGridView1[1, row].Value = "test";
            form.repair(member, row);
            member[row] = form.getMemberFromForm();
            form.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 formtwo = new Form2();
            formtwo.Show();
        } 

        public List<Member> getMemberList()
        {
            return this.member;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //int cel = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            string s = dataGridView1.CurrentRow.ToString();
            MessageBox.Show(s.Substring(24, s.Length - 26));
            int indexDelete = Convert.ToInt32(s.Substring(24, s.Length - 26));
            MessageBox.Show("index = " + indexDelete.ToString());
            this.member.RemoveAt(indexDelete);
            SaveFileTxt saveFileTxt = new SaveFileTxt();
            saveFileTxt.writeFileBegin("");
            for (int i = 0; i < this.member.Count; i++)
            {
                saveFileTxt.writeFile(this.member[i].ToString());
                MessageBox.Show(this.member[i].ToString());
            }
            this.Form1_Load(sender, e);

        }
    }
}
