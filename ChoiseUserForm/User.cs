using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Media
{
    public class User
    {
        private string login;
        private string password;
        private int theme;
        private List<Opener> UsersOpener=new List<Opener>();

        public User()
        {
            login = "";
            password = "";
            theme = 1;
        }
        public User(string A)
        {
            login = A;
            password = "";
            theme = 1;
        }
        public User(string A, string B)
        {
            login = A;
            password = B;
            theme = 1;
        }
        public User(string A, string B, int C)
        {
            login = A;
            password = B;
            theme = C;
        }

        public void SetPassword(string a)
        {
            this.password = a;
        }
        public bool ComparePassword(string pass)
        {
            return this.password == pass;
        }

        public string Login()
        {
            return login;
        }
        public void SetLogin(string log)
        {
            login = log;
        }

        public int Theme()
        {
            return theme;
        }
        public void SetTheme(int i)
        {
            theme = i;
        }

        public void WriteOut(StreamWriter outp)
        {
            string sum = "";
            for (int i = 0; i < this.login.Length; i++)
            {
                int chr = (int)this.login[i];
                for (int j = 0; j < 8; j++)
                    if (chr / Math.Pow(2, 7 - j) >= 1)
                    {
                        chr -= (int)(Math.Pow(2, 7 - j) + 0.1);
                        sum += '1';
                    }
                    else
                        sum += '0';
            }
            sum += "00000000";
            for (int i = 0; i < this.password.Length; i++)
            {
                int chr = (int)this.password[i];
                for (int j = 0; j < 8; j++)
                    if (chr / Math.Pow(2, 7 - j) >= 1)
                    {
                        chr -= (int)(Math.Pow(2, 7 - j) + 0.1);
                        sum += '1';
                    }
                    else
                        sum += '0';
            }
            sum += "00000000" + this.theme;
            outp.WriteLine(sum);
            WriteOutOpeners();
        }
        public void ReadFrom(string sum)
        {
            this.login = "";
            this.password = "";
            int slash = 0;
            for (int i = 0; i < sum.Length && slash < 2; i += 8)
            {
                int chr = 0;
                for (int j = 0; j < 8; j++)
                    if (sum[i + j] == '1')
                        chr += (int)(Math.Pow(2, 7 - j) + 0.1);
                if (chr == 0)
                    slash++;
                else
                    if (slash == 0)
                        this.login += (char)chr;
                    else
                        this.password += (char)chr;
            }
            char a = sum[sum.Length - 1];
            sum = "";
            sum += a;
            this.theme = Int16.Parse(sum);
        }

        public void AddOpener(Opener a)
        {
            UsersOpener.Add(a);
        }
        public void ChangeOpener(Opener a)
        {
            UsersOpener[UsersOpener.FindIndex(r=>r.TypeOfFile()==a.TypeOfFile())]=a;
        }
        public void DeleteOpener(Opener a)
        {
            UsersOpener.Remove(a);
        }
        public Opener SearchOpener(string type)
        {
            return UsersOpener.Find(r => r.TypeOfFile() == type);
        }
        public void AddOrChangeOpener(Opener a)
        {
            if (UsersOpener.Find(r => r.TypeOfFile() == a.TypeOfFile()) == null)
                AddOpener(a);
            else
                ChangeOpener(a);
        }
        public void ReadOpeners()
        {
            if (System.IO.File.Exists(@"cd..\\..\\..\\..\\Resources\\UsersOpeners\\" + login + ".data"))
            {
                StreamReader inp = new StreamReader(@"cd..\\..\\..\\..\\Resources\\UsersOpeners\\" + login + ".data");
                UsersOpener.Clear();
                while (!inp.EndOfStream)
                    UsersOpener.Add(new Opener(inp.ReadLine()));
                inp.Close();
                inp.Dispose();
            }
        }
        public void WriteOutOpeners()
        {
            StreamWriter outpopener = new StreamWriter(@"cd..\\..\\..\\..\\Resources\\UsersOpeners\\" + login + ".data", false);
            foreach (var i in UsersOpener)
                outpopener.WriteLine(i.Address() + '\t' + i.Name() + '\t' + i.TypeOfFile());
            outpopener.Close();
            outpopener.Dispose();
        }

        public static bool operator == (User A, User B)
        {
            return (A.login == B.login && A.password == B.password);
        }
        public static bool operator != (User A, User B)
        {
            return ! (A == B);
        }
    }
}
