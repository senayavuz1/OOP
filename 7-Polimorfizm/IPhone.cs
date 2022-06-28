using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _7_Polimorfizm
{
    public class IPhone : TelefonBase 
    {
        public override void CallRing()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\..\Sounds\iphone.wav"))
            {
                player.Play();
            }
        }
    }
}
