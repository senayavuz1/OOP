using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm
{
    public class TelefonBase
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public virtual void CallRing()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory+@"\..\..\..\Sounds\default.wav"))
            {
                player.Play();
            }
        }
    }
}
