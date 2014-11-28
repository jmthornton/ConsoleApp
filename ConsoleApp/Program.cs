using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = Matrix<double>.Build.Random(6, 5);
            var n = Matrix<double>.Build.Random(5, 3);

            var v = m * n;

            Console.WriteLine(v);
            Console.WriteLine(v.Transpose());

            Console.WriteLine("Done.  Press a key...");
            Console.ReadKey();
        }
    }
}