using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSH
{
    [Serializable]
     class Film : Abstract, Interface
    {
        protected int mStud;
        protected string mNameFilm;
        protected string mProd;
        protected string mGenre;
        protected string mNameClass;
        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void intFilm(ref int Stud);
        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void strFilm([MarshalAs(UnmanagedType.LPWStr)]StringBuilder NameFilm, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder Prod, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder sbGenre);
        public Film()
        {
            mStud = 0;
            mNameFilm = "by default NameFilm";
            mProd = "by default Prod";
            mGenre = "by default Genre";
            mNameClass = "Main Class";
        }
        public Film(int _stud)
        {
            this.mStud = _stud;
            mNameFilm = "by default NameFilm";
            mProd = "by default Prod";
            mGenre = "by default Genre";
            mNameClass = "Main Class";
        }
        public Film(int _stud, string _NameFilm)
        {
            this.mStud = _stud;
            this.mNameFilm = _NameFilm;
            mProd = "by default Prod";
            mGenre = "by default Genre";
            mNameClass = "Main Class";
        }

        public void SetInt()
        {
            intFilm(ref mStud);
        }

        public void SetString()
        {
            StringBuilder sbNameFilm = new StringBuilder(10);
            StringBuilder sbProd = new StringBuilder(10);
            StringBuilder sbGenre = new StringBuilder(10);
            strFilm(sbNameFilm, sbProd, sbGenre);
            this.mNameFilm = sbNameFilm.ToString();
            this.mProd = sbProd.ToString();
            this.mGenre = sbGenre.ToString();
        }
        public void input()
        {
            Console.Write("Studio - ");
            this.mStud = Int32.Parse(Console.ReadLine());
            Console.Write("Film name - ");
            this.mNameFilm = Console.ReadLine();
            Console.Write("Producer - ");
            this.mProd = Console.ReadLine();
            Console.Write("Genre - ");
            this.mGenre = Console.ReadLine();
        }
        public override void output()
        {
            Console.WriteLine(this.mNameClass);
            Console.WriteLine("Studio - " + this.mStud);
            Console.WriteLine("Film name - " + this.mNameFilm);
            Console.WriteLine("Producer - " + this.mProd);
            Console.WriteLine("Genre - " + this.mGenre);
        }

        public string NameFilm
        {
            get { return mNameFilm; }
            set { mNameFilm = value; }
        }
        public int Stud
        {
            get { return mStud; }
            set { mStud = value; }
        }
        public string Prod
        {
            get { return mProd; }
            set { mProd = value; }
        }
        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }
    }
}
