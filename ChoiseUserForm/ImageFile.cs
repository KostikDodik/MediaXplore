using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class ImageFile:File
    {
        private float pixelsperduim;
        private int[] resolution;

        public ImageFile(string d)
            : base(d)
        {
        }

     public float Pixelsperduim()
     {return pixelsperduim; }
     public int[] Resolution()
     { return resolution; }


    public void SetPixelsperduim(float i)
    { pixelsperduim=i;}
    public void SetResolution(int[] i) 
    { resolution = i; }
    }
}
