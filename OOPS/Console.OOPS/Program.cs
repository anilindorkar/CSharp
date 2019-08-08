using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    class Program
    {
        static void Main(string[] args)
        {


            // OverrideAndNew();

            // ContructorChaining();

            SelfConstructorCall();

            Console.ReadLine();
        }

        public static void SelfConstructorCall() {
            SelfClass sclass = new OOPS.SelfClass();            
        }

        public static void ContructorChaining() {
            MyChildClass mychildClass = new MyChildClass(1, 2, 3);
            Console.WriteLine(mychildClass.sub(4, 6));
        }
        /// <summary>
        ///  Override and New
        /// </summary>
        public static void OverrideAndNew() {
            #region Override Vs Virtual

            //Override Vs Virtual
            derivedClass objDer = new derivedClass();
            //Calling Child
            Console.WriteLine(objDer.ShowHello());
            //Calling Child
            Console.WriteLine(objDer.ShowWelcome());

            // As you can see that when I show method which used new keyword is showing base class method but when I show the method which used override then its shows the method of derived class.

            baseClass objBase = new derivedClass();
            //Calling Base : New Keyword
            Console.WriteLine(objBase.ShowHello());
            //Calling Child : Override Keyword.
            Console.WriteLine(objBase.ShowWelcome());
            #endregion
        }
    }
}
