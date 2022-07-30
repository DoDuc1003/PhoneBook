using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PhoneBookVS
{
    internal class SaveFileTxt
    {
        private const string HEAD = "/PhoneBookVs/PhoneBookVs/data/";
        private string file_read_data = "store";
        private const string FILE_NAME_EXTENSION = ".txt";
        private int index = 1;
        private string data;
        public SaveFileTxt(string file_read_data, int index, string data) 
        {
            this.file_read_data = file_read_data;
            this.index = index;
            this.data = data;
        }
        public SaveFileTxt()
        {
            this.ReadData();
        }

        private void ReadData()
        {
            try
            {
                using (StreamReader file = new StreamReader(HEAD + file_read_data + FILE_NAME_EXTENSION))
                {
                    data = file.ReadToEnd();
                    file.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("have some error in read file txt");
                MessageBox.Show(e.Message);
            }
        }

        private void writeFile()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(HEAD + file_read_data + FILE_NAME_EXTENSION))
                {
                    file.WriteLine(index);
                    file.Write(data);
                    MessageBox.Show(data);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("have some error in write file txt");
                MessageBox.Show(e.Message);
            }
        }
        public void writeFile(string s)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(HEAD + file_read_data + FILE_NAME_EXTENSION, true))
                {
                    file.Write(s + '\n');
                    //MessageBox.Show(data);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("have some error in write file txt");
                MessageBox.Show(e.Message);
            }
        }

        public void writeFileBegin(string s)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(HEAD + file_read_data + FILE_NAME_EXTENSION, false))
                {
                    file.Write(s);
                    //MessageBox.Show(data);
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("have some error in write file txt");
                MessageBox.Show(e.Message);
            }
        }

        public string getData()
        {
            return data;
        }
    }
}
