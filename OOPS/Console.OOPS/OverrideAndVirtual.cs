using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SUMMARY 
// As it shows the difference between new and override that override extends the method in derived class but new only hides the method of base class in derived class.
// 1. if new keyword used then it will call the base method if left side variable type is base.
// 2. if override keyword is used then it is going to always call child method.
namespace ConsoleApp.OOPS
{
    public class baseClass
    {
        public virtual string ShowWelcome()
        {
            return "Welcome From Base.";
        }

        public string ShowHello() {
            return "Hello From Base.";
        }
    }

    public class derivedClass : baseClass
    {
        
        public new string ShowHello() {
            return "Hello From Derived";
        }

        public override string ShowWelcome()
        {
            return "Welcome From Derived.";
        }
    }
}
