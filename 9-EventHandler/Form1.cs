using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_EventHandler
{

    public delegate void OlayTip(object sender, EventArgs args);
    
    public delegate void EventTip1(int a, object b);
    public partial class Form1 : Form
    {
        /*
         Events(Olaylar) kullanicinin fare ile tiklamasi , klavyeden bir tusa basilmasi
        gibi işletim sistemi uzerinde gerceklesen eylemlerdir. Bir bilesen uzerinde meydana gelen olaylari takip eden ve bunlari yakalayan mekanizmaya EventHandler denir.
         
         
         */

        public static string Mesaj { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba("Toyota", 80);

            //araba.HizAsimi += new HizAsimiEventHandler(HizLimit);
            //araba.HizAsimi += CezaKes;
            //araba.HizAsimi += AilesineHaberVer;

           
            
            //araba.HareketEdiyorum += 
            //araba.HareketEdiyorum += trafikPolisi.HizKontrolEt;
           
        

            


           

            //for (int i = 0; i < 5; i++)
            //{
            //    araba.Hiz += 20;
            //}
            
        }
        public void HizLimit()
        {
            listBox1.Items.Add(Mesaj);
        }

        public void AilesineHaberVer()
        {
            listBox1.Items.Add(Mesaj);
        }

        public void CezaKes()
        {
            listBox1.Items.Add("2500 Tlş Hiz Asim Cevasi kesildi");
        }

        private void listBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
