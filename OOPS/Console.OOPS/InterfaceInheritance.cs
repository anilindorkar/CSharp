using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY
    /// 1. Interface in C# is basically a contract in which we declare only signature. The class which implemented this interface will define these signatures. Interface is also a way to achieve runtime polymorphism. We can add method, event, properties and indexers in interface
    /// </summary>
    class InterfaceInheritance : Idef1
    {
        //define the methods in the class which declared in interface
        public int sum(int x, int y)
        {

            return x + y;

        }
        public int mul(int p, int q)
        {

            return p + q;
        }
    }

    public interface Idef1
    {
        //singnature of methods

        int sum(int x, int y);
        int mul(int x, int y);
    }


    /*
    More than one Interface having Same Method
        OR
    Runtime Polymorphism

    1. Now let’s move to the more than one interface. We can implement more than one interface in one class. This is the way to achieve the multiple inheritance.

    2. Create two interfaces and create same method in both and implement in same class.

    3. As you can see that we implemented two interfaces into one class. We give one definition to the method. We will not get any error as in interface we only declared the method. That is only signature. So we can give one common definition to all same method having same signature. When we create the object of implementation class we can easily call sum method without any error.
     */

    public class Implementation2 : Indef1, Indef2
    {
        //define the methods in the class which declared in Idef1 and Idef2
        public int sum(int x, int y)
        {
            return x + y;
        }
    }

    public class Implementation3 : Indef1, Indef2
    {
        //implementation of Idef1 method
        int Indef1.sum(int x, int y)
        {

            return x + y;

        }

        //implementation of Idef2 method
        int Indef2.sum(int x, int y)
        {

            return 2 * (x + y);

        }
    }

    /// <summary>
    /// SUMMARY
    /// 1. As you can see that we create reference variable of type idef1 and idef2 and instantiate it with implementation class. This is also a way to achieve runtime polymorphism as at runtime we decide which method will be executed.
    /// </summary>
    public class RuntimePoly {

        public void CallRunTimePoly() {
            Implementation3 imp = new Implementation3();
            Indef1 inter1 = imp;
            Indef2 inter2 = imp;
            Console.WriteLine("Run Time Poly : Interface one {0}", inter1.sum(2, 4));
            Console.WriteLine("Run Time Poly : Interface two {0}", inter2.sum(2, 4));
        }

    }

    public interface Indef1
    {
        //singnature of methods

        int sum(int x, int y);
    }

    public interface Indef2
    {
        int sum(int x, int y);
    }

}
