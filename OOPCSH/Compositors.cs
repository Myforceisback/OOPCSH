using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSH
{
    partial class Compositors : Music
    {
        private string mNameCompositor;

        public Compositors()
        {
            mNameCompositor = "By default NameCompositor";
            mNameClass = "Compositor Class";
        }

        public string GetNameCompositor()
        {
            return mNameCompositor;
        }

        public void SetNameCompositor(string NameCompositor)
        {
            this.mNameCompositor = NameCompositor;
        }

        public new void input()
        {
            base.input();
            Console.Write("Name Compositor - ");
            mNameCompositor = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Name Compositor - " + mNameCompositor);
        }
        public string Compositor
        {
            get { return mNameCompositor; }
            set { mNameCompositor = value; }
        }
    }
}
