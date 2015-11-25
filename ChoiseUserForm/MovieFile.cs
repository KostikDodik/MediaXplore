using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class MovieFile: File
    {
        private int audioBitreit;
        private int videoBitreit;
        private float length;
        public MovieFile(string data)
            :base(data)
        {
        }

        public int AudioBitreit()
        { return audioBitreit; }
        public int VideoBitreit()
        { return videoBitreit; }
        public float Length()
        { return length; }

        public void SetAudioBitreit(int i)
        { audioBitreit = i; }
        public void SetVideoBitreit(int i)
        { videoBitreit = i; }
        public void SetLength(float i)
        { length = i; }
    }
}
