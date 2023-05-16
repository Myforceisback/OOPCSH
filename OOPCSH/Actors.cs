using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSH
{
    class Actors : Film
    {
        private string mNameActror;
        public Actors()
        {
            mNameActror = "By default NameActor";
            mNameClass = "Actors Class";
        }

        public new void input()
        {
            base.input();
            Console.Write("Name Actors - ");
            mNameActror = Console.ReadLine();
        }

        public new bool output()
        {
            base.output();
            Console.WriteLine("Name Actor - " + mNameActror);
            return true;
        }
        public string Actor
        {
            get { return mNameActror; }
            set { mNameActror = value; }
        }
    }
}
