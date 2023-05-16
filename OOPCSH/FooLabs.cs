using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OOPCSH
{
    partial class Labs
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct sMusic
        {
            public int sStud;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)] 
            public string sNameFilm;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sProd;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sGenre;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameMusic;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameClass;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct sActors
        {
            public int sStud;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameFilm;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sProd;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sGenre;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameActor;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameClass;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct sCompositors
        {
            public int sStud;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameFilm;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sProd;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sGenre;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameMusic;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameCompositor;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sNameClass;
        }

        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool InpMus(ref sMusic cl);
        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool OtpMus(ref sMusic cl);

        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool InpAct(ref sActors cl);
        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool OtpAct(ref sActors cl);

        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool InpCom(ref sCompositors cl);
        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern bool OtpCom(ref sCompositors cl);

        [DllImport(@"D:\PSU\3 course\2\OOP\OOPCSH\x64\Debug\DLLCs.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern void intFilm(ref int Stud);

        void IMusic(ref Music cl)
        {
            bool checkI;
            sMusic mus = new sMusic();
            checkI = InpMus(ref mus);
            if (checkI != true)
                Console.WriteLine("Что-то пошло не так в IMusic");
            cl.NameFilm = mus.sNameFilm;
            cl.Genre = mus.sGenre;
            cl.NameMusic = mus.sNameMusic;
            cl.Stud = mus.sStud;
            cl.Prod = mus.sProd;
        }
        void OMusic(ref Music cl)
        {
            bool checkO;
            sMusic mus = new sMusic();
            mus.sNameFilm = cl.NameFilm;
            mus.sGenre = cl.Genre;
            mus.sNameMusic = cl.NameMusic;
            mus.sStud = cl.Stud;
            mus.sProd = cl.Prod;
            
            checkO = OtpMus(ref mus);
            if (checkO != true)
                Console.WriteLine("Что-то пошло не так в OMusic");
        }
        void IActors(ref Actors cl)
        {
            bool checkI;
            sActors act = new sActors();
            checkI = InpAct(ref act);
            if (checkI != true)
                Console.WriteLine("Что-то пошло не так в IActors");
            cl.NameFilm = act.sNameFilm;
            cl.Genre = act.sGenre;
            cl.Actor = act.sNameActor;
            cl.Stud = act.sStud;
            cl.Prod = act.sProd;
        }
        void OActors(ref Actors cl)
        {
            bool checkO;
            sActors act = new sActors();
            act.sNameFilm = cl.NameFilm;
            act.sGenre = cl.Genre;
            act.sNameActor = cl.Actor;
            act.sStud = cl.Stud;
            act.sProd = cl.Prod;
            checkO = OtpAct(ref act);
            if (checkO != true)
                Console.WriteLine("Что-то пошло не так в OActors");

        }
        void ICompositors(ref Compositors cl)
        {
            bool checkI;
            sCompositors com = new sCompositors();
            checkI = InpCom(ref com);
            if (checkI != true)
                Console.WriteLine("Что-то пошло не так в IMusic");
            cl.NameFilm = com.sNameFilm;
            cl.Genre = com.sGenre;
            cl.NameMusic = com.sNameMusic;
            cl.Compositor = com.sNameCompositor;
            cl.Stud = com.sStud;
            cl.Prod = com.sProd;
        }
        void OCompositors(ref Compositors cl)
        {
            bool checkO;
            sCompositors com = new sCompositors();

            com.sNameFilm = cl.NameFilm;
            com.sGenre = cl.Genre;
            com.sNameMusic = cl.NameMusic;
            com.sNameCompositor = cl.Compositor;
            com.sStud = cl.Stud;
            com.sProd = cl.Prod;
            checkO = OtpCom(ref com);
            if (checkO != true)
                Console.WriteLine("Что-то пошло не так в OMusic");
        }
    }
}
