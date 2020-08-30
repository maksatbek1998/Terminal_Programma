using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace звук.Class
{
    public static class Naudio
    {
        private static NAudio.Wave.BlockAlignReductionStream stream = null;
        public static NAudio.Wave.DirectSoundOut output = null;

        public static void Sound(string name)
        {
            
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(@"C:\medical\sound\kg\" + name + ".mp3"));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
        }
    }
}
