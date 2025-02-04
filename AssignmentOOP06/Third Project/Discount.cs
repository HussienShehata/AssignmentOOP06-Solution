using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.Third_Project
{
    internal abstract class Discount
    {

        #region Properties

        public string? DiscountName {  get; set; }

        #endregion

        #region Methods

        public abstract decimal CalculateDiscount(Decimal price, int quantity);
        

       //public decimal TypeOfDiscount(string discountName)
       //{

       //}

        #endregion

    }
}
