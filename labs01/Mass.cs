using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Mass
    {
        public static int[] A = new int[5];
        public static double[,] B = new double[3, 4];

        public void SetValueA()
        {
            string s;
            for (int i = 0; i < 5; i++)
            {
                s = Console.ReadLine();
                A[i] = Convert.ToInt32(s);
            }
        }

         public static Random rnd = new Random();

        public static int rows = B.GetUpperBound(0) + 1;
        public static int columns = B.Length / rows;
        public void SetValueB()
        {
            
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   


                    B[i, j] = rnd.NextDouble() * 100;
                }
                
            }
        }


        public void PrintA()
        {
            foreach (int i in A)
            {
                Console.Write(i + " ");
            }

        }

        public void PrintB()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }

        }

    }
}
