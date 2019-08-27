using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles
{
    /// <summary>
    /// SUMMARY
    /// "O stands for OCP (Open closed principle):- Extension should be preferred over modification."
    /// 1. Extension should be preferred over modification.
    /// 2. I have added a simple customer type property to the class. This property decided if this is a “Gold” ora “Silver” customer.
    /// 3. Depending on the same it calculates discount. Have a look at the “getDiscount” function which returns discount accordingly. 1 for Gold customer and 2 for Silver customer.
    /// 4. The problem is if we add a new customer type we need to go and add one more “IF” condition in the “getDiscount” function, in other words we need to change the customer class.
    /// 5. If we are changing the customer class again and again, we need to ensure that the previous conditions with new one’s are tested again , existing client’s which are referencing this class are working properly as before.
    /// 6. In other words we are “MODIFYING” the current customer code for every change and every time we modify we need to ensure that all the previous functionalities and connected client are working as before.
    /// 7. How about rather than “MODIFYING” we go for “EXTENSION”. In other words every time a new customer type needs to be added we create a new class as shown in the below. So whatever is the current code they are untouched and we just need to test and check the new classes.
    /// 
    /// </summary>
    /// 

    #region


    class OpenClosedPrincipleCustomer
    {
        private int _CustType;

        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }

        public double getDiscount(double TotalSales)
        {
            if (_CustType == 1)
            {
                return TotalSales - 100;
            }
            else
            {
                return TotalSales - 50;
            }
        }
    }

    #endregion

    #region 

    /// <summary>
    /// SUMMARY
    /// 1. Putting in simple words the “Customer” class is now closed for any new modification but it’s open for extensions when new customer types are added to the project.
    /// </summary>
    class Customer
    {
        public virtual double getDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }

    class SilverCustomer : Customer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 50;
        }

    }

    class goldCustomer : SilverCustomer
    {
        public override double getDiscount(double TotalSales)
        {
            return base.getDiscount(TotalSales) - 100;
        }
    }

    #endregion

}
