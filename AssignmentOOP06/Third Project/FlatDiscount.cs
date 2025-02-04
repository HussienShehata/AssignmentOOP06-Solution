using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.Third_Project
{
    internal class FlatDiscount : Discount
    {
        #region Properties
        public decimal FixedAmount { get; set; }
        #endregion


        #region Constructor 

        
        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity - FixedAmount;
        } 
        #endregion
    }
}
