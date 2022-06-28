using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_Polimorfizm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TelefonBase telefon = new TelefonBase();
            //telefon.CallRing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Samsung samsung = new Samsung();
            samsung.CallRing();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPhone phone = new IPhone();
            phone.CallRing();
        }
    }
}
