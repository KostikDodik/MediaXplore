using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class MusicFile : File
    {
        private int bitreit;
        private float length;
        private Mp3Tag tag;

        public MusicFile(string data)
            :base(data)
        {
            tag = new Mp3Tag(data);
        }
                
        public int Bitreit()
        { return bitreit; }
        public float Length()
        { return length; }
        public Mp3Tag Tag()
        { return tag; }

        public void SetBitreit(int i)
        { bitreit = i; }
        public void SetLength(float i)
        { length = i; }
        public void SetTag(Mp3Tag i)
        { tag = i; }
    }
}
