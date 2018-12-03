using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            var userList = users.Get().FirstOrDefault(u => u.name.Equals(login));
            Console.WriteLine(userList.name);
            if (userList.name!=null)
            {
                Class1.n = userList.name;
                Class1.y = userList.year;
                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Ji");
            }
            
        }
        
    }
}
