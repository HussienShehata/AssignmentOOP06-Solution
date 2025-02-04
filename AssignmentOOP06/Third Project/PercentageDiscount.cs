using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.Third_Project
{
    internal class PrecentageDiscount : Discount
    {
        #region attributes


        private decimal precentage;



        #endregion

        #region properties

        public decimal Precentage
        {
            get { return precentage; }
            set
            {
                if (value > 0 && value <= 50)
                {
                    precentage = value;
                }
                else
                   Console.WriteLine("The discount precentage is incorrect ");
            }
        }
        #endregion

        #region constructors 

        public PrecentageDiscount()
        {
            
        }

      

        #endregion

        #region Methods
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * (decimal)quantity * (Precentage/100);
        } 
        #endregion
    }
}
