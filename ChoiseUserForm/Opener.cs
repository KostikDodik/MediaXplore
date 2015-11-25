using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Opener
    {
        private string address;
        private string name;
        private string typeOfFile;

        public Opener()
        {
            address = "";
            name = "";
            typeOfFile = "";
        }
        public Opener(string data)
        {
            string temp = data;
            address = temp.Substring(0, temp.IndexOf('\t'));
            temp = temp.Substring(temp.IndexOf('\t') + 1, temp.Length - temp.IndexOf('\t') - 1);
            name = temp.Substring(0, temp.IndexOf('\t'));
            temp = temp.Substring(temp.IndexOf('\t') + 1, temp.Length - temp.IndexOf('\t') - 1);
            typeOfFile = temp;
        }

        public string Address()
        { return address; }
        public string Name()
        { return name; }
        public string TypeOfFile()
        { return typeOfFile; }

        public void SetAddress(string i)
        { address = i; }
        public void SetName(string i)
        { name = i; }
        public void SetTypeOfFile(string i)
        { typeOfFile = i; }
    }
}
