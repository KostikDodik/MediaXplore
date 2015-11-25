using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    public class Mp3Tag
    {
        private string id;         //  3
        private string title;      //  30
        private string artist;     //  30
        private string album;      //  30
        private string year;       //  4 
        private string comment;    //  30
        private string genre;      //  1

        public Mp3Tag(File Music)
        {
            FileStream fs = System.IO.File.OpenRead(Music.Address());
            if (fs.Length >= 128)
            {
                byte[] btID = new byte[3];         
                byte[] btTitle = new byte[30];     
                byte[] btArtist = new byte[30];     
                byte[] btAlbum = new byte[30];      
                byte[] btYear = new byte[4];       
                byte[] btComment = new byte[30];    
                byte[] btGenre = new byte[1];      
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(btID, 0, 3);
                fs.Read(btTitle, 0, 30);
                fs.Read(btArtist, 0, 30);
                fs.Read(btAlbum, 0, 30);
                fs.Read(btYear, 0, 4);
                fs.Read(btComment, 0, 30);
                fs.Read(btGenre, 0, 1);
                id = Encoding.Default.GetString(btID);

                if (id.Equals("TAG"))
                {
                    title = Encoding.Default.GetString(btTitle);
                    artist = Encoding.Default.GetString(btArtist);
                    album = Encoding.Default.GetString(btAlbum);
                    year = Encoding.Default.GetString(btYear);
                    comment = Encoding.Default.GetString(btComment);
                    genre = Encoding.Default.GetString(btGenre);
                }
                fs.Close();
            }
        }
        public Mp3Tag(string data)
        {
            FileStream fs = System.IO.File.OpenRead(data.Substring(0,data.IndexOf('\t')));
            if (fs.Length >= 128)
            {
                byte[] btID = new byte[3];         //  3
                byte[] btTitle = new byte[30];     //  30
                byte[] btArtist = new byte[30];    //  30 
                byte[] btAlbum = new byte[30];     //  30 
                byte[] btYear = new byte[4];       //  4 
                byte[] btComment = new byte[30];   //  30 
                byte[] btGenre = new byte[1];      //  1
                fs.Seek(-128, SeekOrigin.End);
                fs.Read(btID, 0, 3);
                fs.Read(btTitle, 0, 30);
                fs.Read(btArtist, 0, 30);
                fs.Read(btAlbum, 0, 30);
                fs.Read(btYear, 0, 4);
                fs.Read(btComment, 0, 30);
                fs.Read(btGenre, 0, 1);
                id = Encoding.Default.GetString(btID);

                if (id.Equals("TAG"))
                {
                    title = Encoding.Default.GetString(btTitle);
                    artist = Encoding.Default.GetString(btArtist);
                    album = Encoding.Default.GetString(btAlbum);
                    year = Encoding.Default.GetString(btYear);
                    comment = Encoding.Default.GetString(btComment);
                    genre = Encoding.Default.GetString(btGenre);
                }
                fs.Close();
            }
        }

        public string Id() 
        { return id; }
        public string Title()
        { return title; }
        public string Artist()
        { return artist; }
        public string Album()
        { return album; }
        public string Year()
        { return year; }
        public string Comment()
        { return comment; }
        public string Genre() 
        { return genre; }

        public void SetId(string a)
        {id=a;}
        public void SetTitle(string a)
        {title=a;}
        public void SetArtist(string a)
        {artist=a;}
        public void SetAlbum(string a)
        {album=a;}
        public void SetYear(string a) 
        {year=a;}
        public void SetComment(string a) 
        {comment=a;}
        public void SetGenre(string a)
        {genre=a;}
    }
}
            