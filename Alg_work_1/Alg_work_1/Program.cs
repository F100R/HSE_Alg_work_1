﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_work_1
{
    class Program
    {
        //поиск Xn в цикле for
        public static int GetXn_For(int N)
        {
            int X0 = 0;
            int X1 = 0;
           int  Xn = 1;
            if (N < 0) N = 0;

            for (int i = 0; i < N ; i++)
            {
                X0 = X1;
                X1 = Xn;

                Xn = 12 - 2 * X0 + 3 * X1;
               


            }

            return X1;
        }

        public static double GetXn_N(int N)
        {
            double Xn = 0;
            Xn = -13 + 13 * Math.Pow(2, N) - 12 * N;

            return Xn;
        }

        static void Main(string[] args)
        {
            int N = 2;
            Console.WriteLine(GetXn_For(N).ToString()+"  "+ GetXn_N(N).ToString());
      
        }
    }
}
