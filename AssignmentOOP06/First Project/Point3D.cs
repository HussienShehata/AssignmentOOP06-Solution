using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.First_Project
{
    internal class Point3D : ICloneable
    {
        #region properties

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #endregion


        #region Constructor

        public Point3D()
        {
            
        }

        public Point3D(int x , int y , int z)
        {
            X = x;  
            Y = y;
            Z = z;
        }

        #endregion

        #region Ovveride
        public override string ToString()
        {
            return $"Point Coordinates : ({X},{Y},{Z})";
        }



        public override bool Equals(object? obj)
        {
            Point3D? point= (Point3D?)obj;
            if (obj is not null)
            {
                return this.X == point.X && this.Y == point.Y && this.Z == point.Z; //(this.X=point.X) && (this.Y==point.Y) && (this.Z==point.Z) ;
            }
            else 
                return false ;
        }
        #endregion


        #region Methods

        public static void Sort(Point3D[] arrP)
        {
            Point3D temp;
            for (int i = 0; i < arrP.Length; i++)
            {
                for (int j = i+1;j<arrP.Length; j++)
                {
                    if (arrP[i].X.CompareTo(arrP[j].X)>0)
                    {
                        temp = arrP[i];
                        arrP[i] = arrP[j];
                        arrP[j] = temp;
                    }
                    else if(arrP[i].X == arrP[j].X && arrP[i].Y.CompareTo(arrP[j].Y)>0)
                           {
                        temp = arrP[i];
                        arrP[i] = arrP[j];
                        arrP[j] = temp;

                    };
                }  

            }

         
        }

        public static void ArrPrint(Point3D[] arr)
        {
            foreach (Point3D point in arr )
            {
                Console.WriteLine(point);

            };
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }




        #endregion



    }
}
