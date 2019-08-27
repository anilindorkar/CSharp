using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    public class Base {
    }

    public class Derived : Base {

    }

    /// <summary>
    /// SUMMARY
    /// 1. Any object can be implicitly convert to Object type.
    /// 2. Having Base type left and Derived type on right is legal;
    /// 3. Can not assign object type directly to any other object. Compile time error
    /// 4. A base type created from derived type can not directly assign to derived type new variable. Compile time error
    /// </summary>
    public class CallDerived {
        public void InheritObjects() {
            Object o = new Base();
            Base b1 = new Derived();
            // Derived d1 = o;
            // Derived d2 = b1;
            //Derived d3 = new Base();
        }
    }
}
