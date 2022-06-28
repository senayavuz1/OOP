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
    public partial class IslemciFrm : Form
    {
        public IslemciFrm()
        {
            InitializeComponent();
        }

        private void IslemciFrm_Load(object sender, EventArgs e)
        {

            //1.Yol
            //foreach (var item in MarkaBul("CPU"))
            //{
            //    cmbCpu.Items.Add(item);
            //}

            //2. Yol

            cmbCpu.Items.AddRange(MarkaBul("CPU").ToArray());
            cmbCpu.SelectedIndex = 0;
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
