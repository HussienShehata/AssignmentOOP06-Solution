using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.Third_Project
{
    internal class BuyOneGetOneDiscount : Discount
    {
        #region Methods



        
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if(quantity>1)
                return (price/2)*(quantity/2);
            else
                return price*quantity;
        }



        #endregion
    }
}
