using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "coolzatbox" && textBox2.Text == "helloredwiki")
            {
                SelectMod sm = new SelectMod();
                sm.Show();
            }
            else
            {
                MessageBox.Show("암호나 아이디가 틀립니다.");
            }
        }
    }
}
