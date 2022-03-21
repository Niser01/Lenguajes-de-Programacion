/*M=(A^t A)^-1 A^t*/

using System;

using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace MoonePenrose
{
    class Program
    {


        static void Main(string[] args)
        {
            /*Here are all the algebraic procedures to get the Moore-Penrose inverse using the MathNet library
            and its methods to facilitate working with arrays*/
            
            Matrix<double> m = Matrix<double>.Build.Random(3, 4);
            Matrix<double> mt = m.Transpose();            
            Matrix<double> mtmult= mt*m;
            Matrix<double> mtmulinv = mtmult.Inverse();
            Matrix<double> InvMoorePenrose = mtmulinv*mt;

            /*Here are displayed the for loops to print the arrays, one nested loop to print the original array A,
            and the second to print the result of the Moore-Penrose inverse. for this to work properly if you change the 
            Matirx size you also have to change the constraints of the loops.*/

            Console.WriteLine("This is the A Matrix:");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(m[f, c] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();

            Console.WriteLine("This is the Moore-Penrose inverse Matrix:");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(InvMoorePenrose[f, c] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}


