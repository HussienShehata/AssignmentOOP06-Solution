using System.Security.Cryptography.X509Certificates;
using AssignmentOOP06.First_Project;
using AssignmentOOP06.Second_Project;
using AssignmentOOP06.Third_Project;

namespace AssignmentOOP06
{
    internal class Program

    {
        public static void DiscountTypeAndTotal(string discountName, decimal price, int quantity, decimal discountWay)
        {
            decimal discountAmount;
            if (discountName is not null)
            {

                if (discountName == "Precentage Discount")
                {

                    PrecentageDiscount discount = new PrecentageDiscount();
                    discount.DiscountName = discountName;
                    Console.WriteLine(discount.DiscountName);
                    discount.Precentage = discountWay;
                    discountAmount = discount.CalculateDiscount(price, quantity);
                    Console.WriteLine($"The discount on this recipt is : {discountAmount}");
                }
                else if (discountName == "Flat Discount")
                {
                    FlatDiscount discount = new FlatDiscount();
                    discount.DiscountName = discountName;
                    Console.WriteLine(discount.DiscountName);
                    discount.FixedAmount = discountWay;
                    discountAmount = discount.CalculateDiscount(price, quantity);
                    Console.WriteLine($"The discount on this recipt is : {discountAmount}");
                }
                else if (discountName == "Buy One Get One Discount")
                {
                    BuyOneGetOneDiscount discount = new BuyOneGetOneDiscount();
                    discount.DiscountName = discountName;
                    Console.WriteLine(discount.DiscountName);
                    //discount.Precentage = discountWay;
                    discountAmount = discount.CalculateDiscount(price, quantity);
                    Console.WriteLine($"The discount on this recipt is : {discountAmount}");
                }
                else
                {
                    Console.WriteLine("The entered discount type is not valid \nPlease try again");
                }
            }
            else
                Console.WriteLine("Please try again");
        }
        static void Main(string[] args)
        {

            #region First project

            #region No.2
            //Point3D p = new Point3D(10,10,10);
            //Console.WriteLine(p); 
            #endregion

            #region No.3
            //int x, y, z; 
            //Point3D p1 = new Point3D();
            //Point3D p2 = new Point3D();

            //Console.WriteLine("Enter coordinate X :");
            //int.TryParse(Console.ReadLine(), out x);
            //Console.WriteLine("Enter coordinate Y :");
            //int.TryParse(Console.ReadLine(), out y);

            //Console.WriteLine("Enter coordinate Z :");
            //z= Convert.ToInt32(Console.ReadLine());

            //p1.X = x;
            //p1.Y = y;
            //p1.Z = z;
            //Console.WriteLine(p1);


            //int a, b, c;

            //Console.WriteLine("Enter coordinate A :");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter coordinate B :");
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinate C :");
            //c = Convert.ToInt32(Console.ReadLine());


            //p2.X = a;
            //p2.Y = b;       
            //p2.Z = c;

            //Console.WriteLine(p2); 
            #endregion




            #region No.4



            //  //if (p1 == p2) // doesnt work because it compares referneces

            //  //    Console.WriteLine("The two points are equal");

            //  //else 
            //  //    Console.WriteLine("The two point are not equal");




            //Point3D p3 = new(1, 2, 3);
            //Point3D p4 = new(1, 2, 3);
            //if (p3.Equals(p4))
            //{
            //    Console.WriteLine("These two points are equal");
            //}
            //else
            //    Console.WriteLine("These two points are not equal");

            #endregion



            #region No.5

            //Point3D[] arrP =
            //{
            //    new Point3D(10,12,10),
            //    new Point3D(11,9,3),
            //    new Point3D(1,2,4),
            //    new Point3D(10,8,5)
            //};

            //Point3D.Sort(arrP);
            //Console.WriteLine("Array after sorting");
            //Point3D.ArrPrint(arrP);

            #endregion

            #region No.6

            // Point3D[] arrP2;

            // arrP2 = (Point3D[])arrP.Clone();
            // Console.WriteLine("Deep copy of the array");
            //Point3D.ArrPrint(arrP2);

            #endregion


            #endregion


            #region Second Project

            //double sum, sub, mult, division; 

            //sum= Mathematics.Add(5, 6);
            //Console.WriteLine(sum);

            //sub = Mathematics.Subtract(10.5, 2);
            //Console.WriteLine(sub);

            //mult = Mathematics.Multiply(5.5, 6);
            //Console.WriteLine(mult);

            //division = Mathematics.Divide(10, 2);
            //Console.WriteLine(division);

            #endregion


            #region Third Project

            decimal price;
            int amount;
            decimal discountPayment;
            string? discountWay;

            Console.WriteLine("Enter price : ");
            decimal.TryParse(Console.ReadLine(),out price);

            Console.WriteLine("Enter amount :");
            int.TryParse(Console.ReadLine(),out amount);

            Console.WriteLine("Enter Discount Name : ");
            discountWay = Console.ReadLine();
            Console.WriteLine("Enter discount :");
            decimal.TryParse(Console.ReadLine(), out discountPayment);



            DiscountTypeAndTotal(discountWay,price,amount,discountPayment);

            Console.Clear();
            #endregion

        }
    }
}
