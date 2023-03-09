using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_PE14
{
    public interface myInterface
    {
        void interfaceMethod();
    }

    public class myClass : myInterface
    {
        public void interfaceMethod()
        {
            Console.WriteLine("output 1 = myClass");
        }
    }

    public class yourClass : myInterface
    {
        public void interfaceMethod()
        {
            Console.WriteLine("output 2 = yourClass");
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            myClass my = new myClass();
            yourClass your = new yourClass();
            MyMethod(my);
            MyMethod(your);
        }

        public static void MyMethod(object myObject)
        {
            myInterface myFace;
            myFace = myObject as myInterface;
            myFace.interfaceMethod();
        }
    }
}
