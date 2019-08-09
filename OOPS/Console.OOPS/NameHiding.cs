using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMAMRY
    /// 1. In inheritance, if we need to hide the base class function into derived class then we use the concept of name hiding.
    /// 2. In the following example, we have created Abc class which is our base class and Pqr Class which is our derived class. In the base class Abc we have declared sum function and hide it in derived class by using new keyword. If we do not use new keyword, we will get warning but it does not affect programme.
    /// 3. Now when we create the object of Pqr class and call the sum function, it will call the derived class function.
    /// 4. Therefore, we simply hides the base class function into derived class.
    /// </summary>
    class NameHidingBase
    {
        public int sum(int x, int y)
        {
            Console.WriteLine("Base Class Method.");
            return (x + y);
        }
    }

    class NameHidingChild : NameHidingBase
    {
        public new int sum(int x, int y)
        {
            Console.WriteLine("Child Class Method.");
            return (x + y) * 2;
        }
    }
}
