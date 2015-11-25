using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class File
    {
        private string address;
        private long size;
        private string type;
        private string name;

        public File(string data)
        {
            string temp = data;
            address = temp.Substring(0, temp.IndexOf('\t'));
            temp = temp.Substring(temp.IndexOf('\t')+1, temp.Length - temp.IndexOf('\t')-1);
            size = Int64.Parse(temp.Substring(0, temp.IndexOf('\t')));
            temp = temp.Substring(temp.IndexOf('\t')+1, temp.Length - temp.IndexOf('\t')-1);
            name = temp.Substring(0, temp.IndexOf('\t'));
            temp = temp.Substring(temp.IndexOf('\t')+1, temp.Length - temp.IndexOf('\t')-1);
            type = temp;
        }

        public string Address()
        {
            return address;
        }
        public long Size()
        {
            return size;
        }
        public string Type()
        {
            return type;
        }
        public string Name()
        {
            return name;
        }

        public void SetAddress(string i)
        { address = i; }
        public void SetSize(long i)
        { size = i; }
        public void SetType(string i)
        { type = i; }
        public void SetName(string i)
        { name = i; }
    }
}
