using _6_InterfaceOrnek2.KaraFirin;
using _6_InterfaceOrnek2.Personeller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_InterfaceOrnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           SiniflariAl();
        }

        private void SiniflariAl()
        {
            var classes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var item in classes)
            {
                if (item.Name.Contains("Base"))
                {
                    listBox1.Items.Add(item.Name);

                    foreach (PropertyInfo prop in item.GetProperties())
                    {
                        Label lbl = new Label();
                        lbl.Text = prop.Name;
                        lbl.Name = "lbl" + prop.Name;
                        lbl.Width = flpPersonel.Width / 3;
                        flpPersonel.Controls.Add(lbl);
                       
                        if (prop.PropertyType.BaseType.FullName == typeof(System.Enum).FullName)
                        {
                            var values = Enum.GetValues(prop.PropertyType);
                           //var qwe =  prop.GetValue(item);
                            ComboBox combo = new ComboBox();
                            combo.Name = "cmb" + prop.Name;
                            combo.Width = flpPersonel.Width * 2 / 3;
                            foreach (var val in values)
                            {
                                combo.Items.Add(val);

                            }
                            combo.SelectedIndex = 0;
                            flpPersonel.Controls.Add(combo);

                        }
                        if (prop.PropertyType.FullName == typeof(System.String).FullName)
                        {
                            TextBox textBox = new TextBox();
                            textBox.Name = "txt" + prop.Name;
                            textBox.Width = flpPersonel.Width * 3 / 4;
                            flpPersonel.Controls.Add(textBox);
                        }
                        if (prop.PropertyType.FullName == typeof(System.DateTime).FullName)
                        {
                            DateTimePicker dtp = new DateTimePicker();
                            dtp.Name = "dtp" + prop.Name;
                            dtp.Width = flpPersonel.Width * 3 / 4;
                            flpPersonel.Controls.Add(dtp);
                        }
                        if (prop.PropertyType.FullName == typeof(System.Decimal).FullName)
                        {
                            NumericUpDown upDown = new NumericUpDown();

                            upDown.Name = "nmr" + prop.Name;
                            upDown.Maximum = 100000;
                            upDown.Width = flpPersonel.Width * 3 / 4;
                            flpPersonel.Controls.Add(upDown);
                        }
                        if (prop.PropertyType.FullName == typeof(System.Boolean).FullName)
                        {
                            RadioButton rdr1 = new RadioButton();

                            rdr1.Name = "rdrBayan";
                            rdr1.Width = flpPersonel.Width * 3 / 4;
                            rdr1.Text = "Bayan";
                            flpPersonel.Controls.Add(rdr1);
                            rdr1 = new RadioButton();
                            rdr1.Name = "rdrErkek";
                            rdr1.Text = "Erkek";
                            rdr1.Width = flpPersonel.Width * 3 / 4;
                            flpPersonel.Controls.Add(rdr1);
                        }
                    }
                }
                
            }
        }

        private void EkranOlustur()
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HamurUstasi hasanUsta = new HamurUstasi();
            hasanUsta.Ad = "Hasan";
            hasanUsta.Soyad = "Yilmaz";
            
            IHamurYogurabilir yogurabilir = new YogurmaMakinasi();

            YogurmaMakinasi amakinasi = new YogurmaMakinasi();
            amakinasi.MakinaAdi = "Siemens";

            Firin karaFirin = new Firin();
            
            listBox1.Items.Add(karaFirin.EkmekUret(hasanUsta));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
