using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testAPP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Year");
            dt.Columns.Add("Type");
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
