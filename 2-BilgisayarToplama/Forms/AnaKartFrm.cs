using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_BilgisayarToplama.Forms
{
    public partial class AnaKartFrm : Form
    {
        public AnaKartFrm()
        {
            InitializeComponent();
        }

        private void AnaKartFrm_Load(object sender, EventArgs e)
        {
            cmbAnaKart.Items.AddRange(MarkaBul("AnaKart").ToArray());
            cmbAnaKart.SelectedIndex = 0;
        }
        private List<string> MarkaBul(string marka)
        {


            List<string> markalar = new List<string>();

            string[] gelenler = File.ReadAllLines(Parametreler.MarkalarDosyasi);

            foreach (var item in gelenler)
            {
                if (item.Split(";")[0] == marka)
                    markalar.Add(item.Split(";")[1]);
            }



            return markalar;
        }
    }
}
