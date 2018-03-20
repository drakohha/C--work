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
        public static int[] M = new int[6];
        public static int[] N = new int[6];
        public static int[] MN= new int[6] ;
        public static int[,] TT = new int[5, 5];

        public static int rows = B.GetUpperBound(0) + 1;
        public static int columns = B.Length / rows;

        public static int rows_2 = TT.GetUpperBound(0)+1;
        public static int columns_2 = TT.Length / rows_2;

        public static int Max = 0;
        public static int Min = 100;
        public static int sum = 0;
        public static double sum_2 = 0.0;
        public static int pr = 0;
        public static double pr_2 = 0.0;
        public static double Max_2 = 0;
        public static double Min_2 = 100;


        public int[] GetmassM()
        {
            return M;
        }
        public int[] GetmassA()
        {
            return A;
        }
        public double[,] GetmassB()
        {
            return B;
        }

        public int[] GetmassN()
        {
            return N;
        }
        public int[,] GetmassTT()
        {
            return TT;
        }

        public int[] GetmassMN()
        {
            return MN;
        }

        public int FindMax( int[] X)
        {
            Max = X.Max();
            return Max;
        }


        public int Summ(int[] X)
        {
            sum = 0;
            foreach(int i in X)
            {
                sum += i;
            }
            return sum;
        }

        public double Summ_2(double[,] X)
        {
            sum_2 = 0.0;
            foreach (double i in X)
            {
                sum_2 += i;
            }
            return sum_2;
        }


        public int FindMax_2(int[,] Z)
        {
            Max = 0;
            foreach(int i in Z)
            {
                if (i > Max)
                {
                    Max = i;
                }
                

            }
            return Max;
        }


        public double FindMax_3(double[,] Z)
        {
            Max_2 = 0.0;
            foreach (double i in Z)
            {
                if (i > Max_2)
                {
                    Max_2 = i;
                }


            }
            return Max_2;
        }


        public int FindMin(int [] Z)
        {
            Min = Z.Min();
            return Min;
        }
        public double FindMin_2(double [,] Z)
        {
            Min_2 = 100.0;
            foreach (double i in Z)
            {
                if (i < Min_2)
                {
                    Min_2 = i;
                }


            }
            return Min_2;
        }


        public void SetValueTT()
        {

            for (int i = 0; i < rows_2; i++)
            {
                for (int j = 0; j < columns_2; j++)
                {



                    TT[i, j] = rnd.Next(-100,100);
                }

            }
        }

        public void PrintTT() {
            for (int i = 0; i < rows_2; i++)
            {
                for (int j = 0; j < columns_2; j++)
                {
                    Console.Write($"{TT[i, j]} ");
                }
                Console.WriteLine();
            }

        }


        public void SetValueM()
        {
            string s;
            for (int i = 0; i < 6; i++)
            {
                s = Console.ReadLine();
                M[i] = Convert.ToInt32(s);
            }
        }

        public void SetValueN()
        {
            string s;
            for (int i = 0; i < 6; i++)
            {
                s = Console.ReadLine();
                N[i] = Convert.ToInt32(s);
            }
        }

        public void SetValueMN()
        {
            int k = 0;
            foreach(int i in M)
            {
                foreach(int j in N)
                {
                    if (i == j)
                    {
                        MN[k] = i;
                        k++;
                        break;

                    }
                }
            }
        }

        public void PrintMN()
        {
            foreach (int i in MN)
            {
                if (i != 0)
                {
                    Console.Write(i + " ");
                }
               
            }


        }


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

        public int FindIndexMin(int[,] Z)
        {
            int min_4=0;
            int min = 100;
            int kkk = 0;

            foreach(int i in Z)
            {
                kkk++;
                if (i < min)
                {
                    min = i;
                    min_4 = kkk;
                }
            }

            return min_4;
        }

        public int FindIndexMax(int[,] Z)
        {
            int max_4 = 0;
            int max = 100;
            int kkk = 0;

            foreach (int i in Z)
            {
                kkk++;
                if (i > max)
                {
                    max = i;
                    max_4 = kkk;
                }
            }

            return max_4;
        }


        public int summ_3(int min_4 , int max_4,int[,] Z)
        {
            sum = 0;
            int kk =0;
            foreach(int i in Z)
            {
                kk++;
                if(kk>=min_4 && kk <= max_4)
                {
                    sum += i;
                }
            }
            return sum;
        }


       
        public int proiz(int[] Z)
        {
            pr = 1;
            foreach(int i in Z)
            {
                pr *= i;
            }
            return pr;
        }

        public double proiz_2(double[,] Z)
        {
            pr_2 = 1;
            foreach (double i in Z)
            {
                pr_2 *= i;
            }
            return pr_2;
        }


        public int Sum_chet_A(int[] Z)
        {
            int sum_6 = 0;
            foreach(int i in Z)
            {
                if (i % 2 == 0)
                {
                    sum_6 += i;
                }
            }
            return sum_6;
        }

        public double Sum_neChet_B(double[,] Z)
        {
            double sum_7 = 0.0;
            
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; i++)
                {
                    if (j % 2 != 0)
                    {
                        sum_7 += Z[i, j];
                    }
                }
            }

            return sum_7;
        }

    }
}
