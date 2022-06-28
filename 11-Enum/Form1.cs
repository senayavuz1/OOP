using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartman.Items.AddRange(Enum.GetNames(typeof(sehirler)));
            cmbDepartman.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seciliIndex =(int) Enum.Parse(typeof(sehirler), cmbDepartman.Text);

            MessageBox.Show($"Secilen Departman {cmbDepartman.Text} index degeri :{seciliIndex}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetNames(typeof(sehirler)))
            {
                listBox1.Items.Add(item+"-"+ (int)Enum.Parse(typeof(sehirler),item) );
            }
        }
    }
}
