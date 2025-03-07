using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje20
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public string mesaj1,mesaj2,mesaj3;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(mesaj1);
            comboBox1.Items.Add(mesaj2);
            comboBox1.Items.Add(mesaj3);
        }
    }
}
