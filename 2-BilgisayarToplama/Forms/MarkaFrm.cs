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
    public partial class MarkaFrm : Form
    {
        string[] gelenVeriler;
        public MarkaFrm()
        {
            InitializeComponent();
        }

        private void MarkaFrm_Load(object sender, EventArgs e)
        {
            Doldur2();
        }
       public void Doldur()
        {
            //Array.Clear(gelenVeriler,0,gelenVeriler.Length);
            gelenVeriler = DosyaOku();
            foreach (var item in gelenVeriler)
            {
                if (!cmbMarka.Items.Contains(item.Split(";")[0]))
                {
                    cmbMarka.Items.Add(item.Split(";")[0]);
                }


            }
            cmbMarka.SelectedIndex = 0;
        }

        public void Doldur2()
        {
            //Array.Clear(gelenVeriler,0,gelenVeriler.Length);
            gelenVeriler = DosyaOku();
            foreach (var item in gelenVeriler)
            {
                if (!cmbMarka.Items.Contains(item.Split(";")[0]))
                {
                    cmbMarka.Items.Add(item.Split(";")[0]);
                }


            }
            cmbMarka.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string kategori = cmbMarka.Text;
            string marka = txtMarka.Text;
            if (DosyaOku(kategori, marka))
            {
                MessageBox.Show($"{kategori} , {marka} vardir .. Kayit Yapilamaz");
            }
            else
            {
                DosyaYaz(kategori, marka);
            }

            
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategori = cmbMarka.Text;
            listBox1.Items.Clear();
            foreach (var item in gelenVeriler)
            {

                if (item.Split(";")[0] == kategori &&
                    !listBox1.Items.Contains(item.Split(";")[1]))
                {
                    listBox1.Items.Add(item.Split(";")[1]);

                }

            }
         
        }

        public string[] DosyaOku()
        {
            

          string[] gelenler =  File.ReadAllLines(Parametreler.MarkalarDosyasi);


            return gelenler;

        }
        public bool DosyaOku(string kategori ,string marka)
        {
            List<string> kategoriler = new List<string>();

            string[] gelenler = File.ReadAllLines(Parametreler.MarkalarDosyasi);

            foreach (var item in gelenler)
            {
                var gelen = item.Split(";");

                if (kategori.ToUpper() ==gelen[0].ToUpper() && marka.ToUpper()== gelen[1].ToUpper())
                {
                    return true;
                }

            }
            return false;

        }
        public bool DosyaYaz(string kategori, string marka)
        {

            string satir = kategori + ";" + marka;
            StreamWriter rdr = File.AppendText(Parametreler.MarkalarDosyasi);
            //rdr.Write(satir);
            rdr.WriteLine(satir);

            rdr.Close();
            
            
            return true;

           
        }
        public bool DosyadanSil(string kategori, string marka)
        {

           
            string[] satirlar  = File.ReadAllLines(Parametreler.MarkalarDosyasi);
            List<string> yeniKayitlar = new List<string>();
            string yeniDosya = Parametreler.MarkalarDosyasi + ".temp";
            
            foreach (var item in satirlar)
            {
                string kat = item.Split(";")[0];
                string mr = item.Split(";")[1];

                if (!(kategori == kat && marka == mr))
                    yeniKayitlar.Add(kat + ";" + mr);
                      
            }
            
            File.WriteAllLines(yeniDosya, yeniKayitlar.ToArray());
            File.Delete(Parametreler.MarkalarDosyasi);
            File.Move(yeniDosya, Parametreler.MarkalarDosyasi);

            Doldur();
            return true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
         

            DosyadanSil(cmbMarka.Text, listBox1.SelectedItem.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtMarka.Text = listBox1.SelectedItem.ToString();
        }
    }
}
