using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY 
    /// 1. There is no access modifier of static constructor
    /// 2. There is only one static constructor in the class which means we can't overload the static constructor.
    /// 3. Static constructor can only initialize the static variable of the class.
    /// 4. We can’t pass any parameter to the static constructor.
    /// 5. Can not declare instance members in the statis class.
    /// 6. Instance member can be declared in the normal class only.
    /// </summary>
    public static class StaticConstructor
    {
        public static string className = "";
        // public string methodname = "";
        static StaticConstructor()
        {
            className = nameof(StaticConstructor);
        }       
    }
}
