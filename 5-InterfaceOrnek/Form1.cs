using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_InterfaceOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            FutbolcuOlustur();

           
            
               

        }

        private void FutbolcuOlustur()
        {
            Kaleci muslera = new Kaleci();
            muslera.Adi = "muslera";
            muslera.Soyadi = "Fernando";
            muslera.Millimi = true;
            muslera.Hiz = 55;
            muslera.FormaNumarasi = "1";
            muslera.DogumTarihi = DateTime.Now.AddYears(-35);
            muslera.Agresiflik = 50;

            Defans takozRecep = new Defans();

            takozRecep.Adi = "Recep";
            takozRecep.Soyadi = "Takoz";
            takozRecep.Millimi = true;
            takozRecep.Hiz = 65;
            takozRecep.SutGucu = 85;
            takozRecep.Agresiflik = 70;

            Forvet cenkTosun = new Forvet();
            cenkTosun.Adi = "Cenk";
            cenkTosun.Soyadi = "Tosun";
            cenkTosun.Millimi = true;
            cenkTosun.Hiz = 80;
            cenkTosun.SutGucu = 80;
            cenkTosun.Hiz = 70;


            // Object Initilaize yontemi ile yeni bir sinif olusturma
            Forvet abubakar = new Forvet
            {
                Adi = "Abubakar",
                Agresiflik = 75,
                DogumTarihi = DateTime.Now.AddYears(-30),
                FormaNumarasi = "11",
                Hiz = 80,
                Millimi = true,
                Soyadi = "herneyse",
                SutGucu = 80
            };


            listBox1.Items.Add(muslera);
            listBox1.Items.Add(takozRecep);
            listBox1.Items.Add(cenkTosun);
            listBox1.Items.Add(abubakar);
            listBox1.Items.Add(DateTime.Now);
            listBox1.Items.Add("Deneme");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null)
            {
                IFutbolcu gelen = (IFutbolcu)listBox1.SelectedItem;
                foreach (var item in gelen.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    lbl.Text = item.Name + ":" + item.GetValue(gelen);
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
                

                if (gelen.GetType().GetInterface("IKaleci") != null)
                {
                    foreach (var item in gelen.GetType().GetMethods())
                    {
                        if (!item.Name.Contains("get") && !item.Name.Contains("set"))
                        {
                            Label lbl = new Label();

                            lbl.Text = item.Name + "";
                            lbl.AutoSize = false;
                            lbl.Width = flowLayoutPanel1.Width;
                            flowLayoutPanel1.Controls.Add(lbl);
                        }
                    }
                }
                else if (gelen.GetType().GetInterface("IForvet") != null)
                {
                    foreach (var item in gelen.GetType().GetMethods())
                    {
                        if (!item.Name.Contains("get") && !item.Name.Contains("set"))
                        { 
                        Label lbl = new Label();

                        lbl.Text = item.Name + "";
                        lbl.AutoSize = false;
                        lbl.Width = flowLayoutPanel1.Width;
                        flowLayoutPanel1.Controls.Add(lbl);
                        }
                    }

                }
            }
           
        }
    }
}
