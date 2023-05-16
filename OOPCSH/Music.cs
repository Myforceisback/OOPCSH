using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSH
{
    [Serializable]
    class Music : Film
    {
        protected string mNameMusic;

        public Music()
        {
            mNameMusic = "By default NameMusic";
            mNameClass = "Music Class";
        }
        public Music(string nameMus, int Stud, string NameFilm, string Prod, string Genre)
        {
            mNameMusic = nameMus;
            mNameFilm = NameFilm;
            mStud = Stud;
            mProd = Prod;
            mGenre = Genre;
            mNameClass = "Music Class";
        }

        public Music(List<Music> temp)
        {
           foreach (var item in temp)
           {
                mNameFilm = item.NameFilm;
                mProd = item.Prod;
                mStud = item.Stud;
                mGenre = item.Genre;
                mNameMusic = item.NameMusic;
                break;
           }
           mNameClass = "Music Class";
        }

        public new void input()
        {
            base.input();
            Console.Write("Name Music - ");
            mNameMusic = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Name Music - " + mNameMusic); 
        }

        public string NameMusic
        {
            get { return mNameMusic; }
            set { mNameMusic = value; }
        }
    }
}
