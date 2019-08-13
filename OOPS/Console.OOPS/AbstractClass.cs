using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{
    /// <summary>
    /// SUMMARY 
    /// 1. Abstract classes are those classes, which create using Abstract Keyword. Abstract class contains both Abstract method and Non Abstract Method. Abstract Methods are those methods, which is only declared not defined. We cannot create the object of Abstract Class. We have to inherit abstract class in another class and define the abstract methods.
    /// 2. As we know that, we cannot create the object of Abstract class. It is very important question of interview that whether we can have constructor in Abstract class or not? Yes, we can have constructor in Abstract class and we can call this constructor from derived class.
    /// 3. It is very important questions for interview that can we have static method in Abstract Class? As we know that, we cannot create the object of Abstract class and static method cannot be called with object.  Therefore, we can create the static method in Abstract class and call it with the help of class name
    /// </summary>
    public abstract class AbstractBaseClass
    {
        public int counter = 0;
        public AbstractBaseClass()
        {
            counter++;
            Console.WriteLine("I am Abstract Class Contructor.");
        }
        public int Sum(int x, int y) {
            return x + y;
        }

        public abstract int Sub(int x, int y);

        public static void ShowMessage() {
            Console.WriteLine("Static Method from Abstract Class.");
        }
    }

    public class ChildInheritAbstractClass : AbstractBaseClass {
        public ChildInheritAbstractClass() : base()
        {
            Console.WriteLine("I am in Child Class Contructor.");
        }
        public override int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
