using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje24
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20,10);
            btn.Location = btnkonum;
            btn.Name = "Buton1";
            btn.Text = "Tikla";
            btn.BackColor = Color.AliceBlue;
            btn.Height = 50;
            btn.Width = 40;

            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();

            Point lblkonum = new Point(20, 200);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhabalar";
            lbl.BackColor = Color.AliceBlue;
            lbl.Height = 100;
            lbl.Width = 100;

            

            for (int i = 0; i < 10; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i * 20);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
            
            this.Controls.Add(btn);
            this.Controls.Add(lbl);

        }
    }
}
