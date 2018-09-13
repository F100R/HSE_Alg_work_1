using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простой вызов
           int X0 = 0;
            int X1 = 0;
            int Xn = 1;
            int N = 3;

            for (int i = 0; i < N+1; i++)
            {
                X0 = X1;
                X1 = Xn;
                Xn=12-2*X0+3*X1;

            }
            Console.WriteLine(X0);
        }
    }
}
