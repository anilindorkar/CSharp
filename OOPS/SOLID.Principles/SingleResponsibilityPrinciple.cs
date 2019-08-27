using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles
{
    /// <summary>
    /// SUMMARY
    /// A class should take care of only one responsibility.
    /// </summary>
    class SingleResponsibilityPrinciple
    {
        #region Problem
        /// <summary>
        /// SUMMARY : 
        /// " S stands for SRP (Single responsibility principle):- A class should take care of only one responsibility."
        /// 1. The customer class is doing things WHICH HE IS NOT SUPPOSED TO DO. 
        /// 2. Customer class should do customer datavalidations, call the customer data access layer etc , but if you see the catch block closely it also doing LOGGING activity. 
        /// 3. In simple words its over loaded with lot of responsibility.
        /// 4. So tomorrow if add a new logger like event viewer I need to go and change the “Customer”class, that’s very ODD.
        //  5. It’s like if “JOHN” has a problem why do I need to check “BOB”.
        /// </summary>
        class Customer
        {
            public void Add()
            {
                try
                {
                    // Database code goes here
                }
                catch (Exception ex)
                {
                    System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
                }
            }
        }
        #endregion

        #region Solution
        class FileLogger
        {
            public void Handle(string error)
            {
                System.IO.File.WriteAllText(@"c:\Error.txt", error);
            }
        }

        class CustomerSRP
        {
            private FileLogger obj = new FileLogger();
            public virtual void Add()
            {
                try
                {
                    // Database code goes here
                }
                catch (Exception ex)
                {
                    obj.Handle(ex.ToString());
                }
            }
        }
        #endregion

    }
}
