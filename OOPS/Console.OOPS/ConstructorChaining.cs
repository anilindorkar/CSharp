using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.OOPS
{

    /// <summary>
    /// SUMMARY
    /// 1. When we inherit class into another class then object of base class is initialized first. If a class do not have any constructor then default constructor will be called. But if we have created any parameterized constructor then we have to initialize base class constructor from derived class.
    /// 2. We have to call constructor from another constructor.It is also known as constructor chaining.
    /// 3. When we have to call same class constructor from another constructor then we use this keyword.In addition, when we have to call base class constructor from derived class then we use base keyword.
    /// </summary>
    public class MyBaseClass
    {
        public int p, q;
        public MyBaseClass(int p1, int p2)
        {
            Console.WriteLine("Base Class Constructor");
            p = p1;
            q = p2;
        }
        public int sum(int x, int y)
        {
            return (x + y);
        }
    }

    public class MyChildClass : MyBaseClass
    {
        public int a;
        public MyChildClass(int a1, int p1, int p2) : base(p1, p2)
        {
            Console.WriteLine("Child Class Constructor");
            a = a1;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }
    }

    /// <summary>
    /// SUMMARY 
    /// 1. When we call default constructor then it is calling parameterized constructor and assign value to variable.
    /// 2. The constructor call with this keyword will get called first then the other one.
    /// </summary>
    public class SelfClass
    {
        public string companyName;
        public string companyId;
        public SelfClass() : this("Default Company")
        {
            Console.WriteLine("Parameter Less Constructor");
        }

        public SelfClass(string compname) : this(compname, "CID0001")
        {
            companyName = compname;
            Console.WriteLine("Parameter One Constructor");
        }

        public SelfClass(string compname, string companyid)
        {
            companyName = compname;
            companyId = companyid;
            Console.WriteLine("Parameter Two Constructor");
        }
    }
}
