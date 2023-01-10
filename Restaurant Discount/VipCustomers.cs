using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride //DO NOT change the namespace name
{
    public class VipCustomer : Restaurant//DO NOT change the class name
    {
        //Implement your code here
        public override double Billing(double amount)
        {
            double result = (amount * 30) / 100;
            result = amount - result;
            return result;
        }
    }
}