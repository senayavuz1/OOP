using _1_BilgisayarKutuphanesi.Bilesenler;
using _2_BilgisayarToplama.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_BilgisayarToplama
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void ıslemciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemciFrm frm = new IslemciFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void anaKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaKartFrm frm = new AnaKartFrm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void markaTanimlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarkaFrm frm = new();

            frm.MdiParent = this;
            frm.Show();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

           
            //PowerSupplier power = new PowerSupplier();
            //power.Marka = "Asus";
            //power.Model = "xyz";
            //power.Watt = 100;
            //power.Fiyat = 100;
            //MessageBox.Show(power.ToString());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PowerSupplierFrm frm = new PowerSupplierFrm();
            this.Height = frm.Height + 150;
            this.Width = frm.Width + 150;
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }


    public class A:object
    {

    }
}
