using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSH
{
    partial class Compositors
    {
        public static bool operator ==(Compositors other, string another)
        {
            int res = 0;
            int sc = another.Length;
            for (int i = 1; i <= another.Length; ++i)
            {
                try
                {
                    if (other.mNameCompositor[i - 1] == another[sc - i])
                        res++;
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.GetBaseException());
                    break;
                }
            }
            if (res == another.Length)
                return true;
            return false;
        }
        public static bool operator !=(Compositors other, string another)
        {

            int res = 0;
            int sc = another.Length;
            for (int i = 1; i <= 5; ++i)
            {
                if (other.mNameCompositor[i - 1] == another[sc - i])
                    res++;
            }
            if (res != 5)
                return false;
            return true;
        }
        public static Compositors operator /(Compositors other, string another)
        {
            int n = other.mNameCompositor.Length;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                if (other.mNameCompositor[i] != another[i])
                {
                    res += other.mNameCompositor[i];
                }
            }
            other.SetNameCompositor(res);
            return other;
        }
        public static Compositors operator /(Compositors other, Compositors another)
        {
            int n = other.mNameCompositor.Length;
            string res = "";
            for (int i = 0; i < n; i++)
            {
                if (other.mNameCompositor[i] != another.mNameCompositor[i])
                {
                    res += other.mNameCompositor[i];
                }
            }
            other.SetNameCompositor(res);
            return other;
        }

    }
}
