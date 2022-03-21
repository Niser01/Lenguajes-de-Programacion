/*M=(A^t A)^-1 A^t*/
using System;

using MathNet.Numerics.LinearAlgebra;

namespace MoonePenrose
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Here the program will ask the user to input the amount of rows and columns that they need
            the A Matrix to be, this input is converted int integer with the Int32.Parse() method. and
            then used to create the matrix later in the program
            */
            int a = 0;
            Console.WriteLine("Please enter the amount of rows of the A Matrix:");
            a = Int32.Parse(Console.ReadLine());
            int b = 0;     
            Console.WriteLine("Please enter the amount of columns of the A Matrix:");
            b = Int32.Parse(Console.ReadLine());


            /*Here are all the algebraic procedures to get the Moore-Penrose inverse using the MathNet library
            and its methods to facilitate working with arrays*/
            
            Matrix<double> m = Matrix<double>.Build.Random(a, b);
            Matrix<double> mt = m.Transpose();            
            Matrix<double> mtmult= mt*m;
            Matrix<double> mtmulinv = mtmult.Inverse();
            Matrix<double> InvMoorePenrose = mtmulinv*mt;

            /*Here are displayed the for loops to print the arrays, one nested loop to print the original array A,
            and the second to print the result of the Moore-Penrose inverse. for this to work properly if you change the 
            Matirx size you also have to change the constraints of the loops.*/

            Console.WriteLine("This is the A Matrix:");
            Console.WriteLine();
            for (int f = 0; f < a; f++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(m[f, c] + " ");
                }
                Console.WriteLine();
            }      
            Console.WriteLine();
            Console.WriteLine("This is the Moore-Penrose inverse Matrix:");
            Console.WriteLine();
            for (int f = 0; f < a; f++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(InvMoorePenrose[f, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
