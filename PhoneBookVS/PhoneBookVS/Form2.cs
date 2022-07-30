using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookVS
{
    public partial class Form2 : Form
    {
        private List<Member> lists;
        private int index;

        public Form2()
        {
            InitializeComponent();
            lists = new List<Member>();
            index = -1;
        }

        public void repair(List<Member> list, int index)
        {
            for (int i = 0; i < list.Count; i++)
            {
                this.lists.Add(list[i]);
            }
            this.index = index;
            Member member = list[index];
            this.textBoxOfName.Text = member.getName();
            this.textBoxEmail.Text = member.getEmail();
            this.textBoxPhoneNumber.Text = member.getPhoneNumber().getPhoneNumber();
            if (member.getPhoneNumber().getTypePhone() == "Cell Phone")
            {
                this.cellPhone.Checked = true;
            } else
            {
                if (member.getPhoneNumber().getTypePhone() == "Line Land")
                {
                    this.cellPhone.Checked = true;
                }
            }
        }

        public Member getMemberFromForm()
        {
            string name = textBoxOfName.Text;
            string email = textBoxEmail.Text;
            string phone_number = textBoxPhoneNumber.Text;
            string phone_type = "";
            if (lineLand.Checked == true)
            {
                phone_type = "Line Land";
            }
            else
            {
                if (cellPhone.Checked == true)
                {
                    phone_type = "Cell Phone";
                }
                else
                {
                    phone_type = "unknow";
                }
            }
            DateTime date = dateTimePickerDateOfBirth.Value;
            PhoneNumber phone = new PhoneNumber(phone_number, phone_type);
            return new Member(name, phone, email, date);
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = getMemberFromForm();
                if (index == -1 && lists.Count == 0)
                {
                    index = 0;
                    lists.Add(member);
                    index = -1;
                } 
                else
                {
                    this.lists[index] = member;
                    index = -1;
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("have a error");
            }
            SaveFileTxt saveFileTxt = new SaveFileTxt();
            saveFileTxt.writeFileBegin("");
            for (int i = 0; i < this.lists.Count; i++)
            {
                saveFileTxt.writeFile(this.lists[i].ToString());
                MessageBox.Show(this.lists[i].ToString());
            }

            this.Close();
        }

    }
}
