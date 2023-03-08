using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE12
{
    public class MyClass
    {
        string myString;
        string MyString
        {
            set { myString = value; }
        }
        public virtual string GetString()
        {
            return myString;
        }
    }

    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            // calls base operator of GetString and adds text to teh returned string
            return base.GetString() + " output from the derived class.";
        }
    }
}
