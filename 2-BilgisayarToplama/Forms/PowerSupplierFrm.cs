using _1_BilgisayarKutuphanesi.Bilesenler;
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
    public partial class PowerSupplierFrm : Form
    {

        List<PowerSupplier> powerSuppliers = new List<PowerSupplier>();
        ContextMenuStrip menuStrip = new ContextMenuStrip();
        int satir;
        
        public PowerSupplierFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PowerSupplier ps = new PowerSupplier();
            ps.Marka = cmbMarka.Text;
            ps.Model = txtModel.Text;
            ps.Fiyat = decimal.Parse(maskFiyat.Text);
            ps.GarantiTarihi = dtGaranti.Value;
            ps.Watt = txtWatt.Text;

        }

        private void PowerSupplierFrm_Load(object sender, EventArgs e)
        {
            DataGridDoldur();
        }

        public void DataGridDoldur()
        {
            string[] gelenVeriler = File.ReadAllLines(Parametreler.PowerSupplierDosyasi);

            foreach (var item in gelenVeriler)
            {
                PowerSupplier pw = new PowerSupplier();
                pw.Marka = item.Split(";")[1];
                pw.Model= item.Split(";")[2];
                pw.Kategori = item.Split(";")[3];
                pw.Fiyat = decimal.Parse(item.Split(";")[4]);
                pw.GarantiTarihi = DateTime.Parse(item.Split(";")[5]);
                pw.Watt = (item.Split(";")[6]);
                powerSuppliers.Add(pw);

            }
            dataGridView1.DataSource = powerSuppliers;

            string[] markalar = File.ReadAllLines(Parametreler.MarkalarDosyasi);

            foreach (var item in markalar)
            {
                string[] temp = item.Split(";");
                if (temp[0] == "Power Supply")
                    cmbMarka.Items.Add(temp[1]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows[e.RowIndex].Cells.Count; i++)
            {
               txtWatt.Text=  dataGridView1.Rows[e.RowIndex].Cells["Watt"].Value.ToString();
                dtGaranti.Value= Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["GarantiTarihi"].Value.ToString());
                maskFiyat.Text= dataGridView1.Rows[e.RowIndex].Cells["Fiyat"].Value.ToString();
                cmbMarka.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["Marka"].Value.ToString();
                txtModel.Text = dataGridView1.Rows[e.RowIndex].Cells["Model"].Value.ToString();
            }
        }
        
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(e.Button== MouseButtons.Right)
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
