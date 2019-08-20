using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY
    /// 1.  An Abstract class has been created using Abstract keyword while interface has been created using interface keyword.
    /// 2.	Abstract class can have both abstract and non-abstract method which means we can also define methods inside abstract class. But in interface we can only declare methods.
    /// 3.	We can’t declare variables in interface. But can declare inside abstract class. Note: - we can declare properties inside interface.
    /// 4.	A class can inherit only one abstract class but it can implement more than one interfaces.
    /// 5.	We don’t specify any access specifier inside interface but in abstract class we can.
    /// 6. Abstract class must be added before the interface while doing inheritance.
    /// </summary>
    class AbstractClassandInterface : cal, idef
    {
        public int sum(int x, int y)
        {
            throw new NotImplementedException();
        }
        public override int div(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    public interface idef
    {
        int sum(int x, int y);
    }

    public abstract class cal
    {
        //we only declare method
        public abstract int div(int x, int y);
        //declare and define method
        public int mul(int x, int y)
        {
            return x * y;
        }
    }

}
