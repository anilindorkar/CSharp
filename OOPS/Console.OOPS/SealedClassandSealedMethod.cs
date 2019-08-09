using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY
    /// 1. Sealed keyword is used to prevent a class from being inherited. It means if we declare class as a sealed class then we cannot further inherit it.
    /// 
    /// </summary>
    public sealed class SealedClass
    {
        public void ShowMessage() {
            Console.WriteLine("I AM Sealed Class Method.");
        }
    }

    /*
    public class ChildClassForSealed : SealedClass {
    }
    */

    //===============================================================

    /// <summary>
    /// SUMMARY
    /// 1. Sealed methods are used to prevent overridden method from further override. We cannot create sealed methods in base class.
    /// 2. In the above example in BaseSealedClass class we have declared sum as virtual method and override it in ChildOneClass class. But we also sealed it in ChildOneClass. If we try to override it in ChildTwoClass class, it will throw following error:-
    /// 3. 'ChildTwoClass.sum(int, int)': cannot override inherited member 'ChildOneClass.sum(int, int)' because it is sealed.

    /// </summary>
    public class BaseSealedClass {
        public virtual int sum(int x, int y)
        {
            return (x + y);
        }
    }

    public class ChildOneClass : BaseSealedClass
    {
        public sealed override int sum(int x, int y)
        {
            return (x + y);
        }
    }

    public class ChildTwoClass : ChildOneClass
    {
        /*
        public override int sum(int x, int y)
        {
            return (x + y);
        }
        */
    }

}
