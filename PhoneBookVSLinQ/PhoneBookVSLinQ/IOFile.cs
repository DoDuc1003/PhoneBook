using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PhoneBookVSLinQ
{
    public class IOFile
    {
        private string path;
        private string data;
        private const string FILE_NAME_EXTENSION = ".txt";
        public string Data { get { return data; } set { data = value; } }
        public IOFile(string path = "store")
        {
            this.path = path;
            this.ReadData();
        }
        public void ReadData()
        {
            try
            {
                using (StreamReader file = new StreamReader(path + FILE_NAME_EXTENSION))
                {
                    data = file.ReadToEnd();
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("have some error in read file txt");
                MessageBox.Show(e.Message);
            }
        }

        private void writeFile()
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path + FILE_NAME_EXTENSION))
                {
                    //file.WriteLine(index);
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
                using (StreamWriter file = new StreamWriter(path + FILE_NAME_EXTENSION, true))
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
                using (StreamWriter file = new StreamWriter(path + FILE_NAME_EXTENSION, false))
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


    }
}
