using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    class Program
    {
        // initialize delegate type  
        public delegate int DelSquare(int i);
        static void Main(string[] args)
        {
            // first you need to initialize delegate type object reference
            // pass method (square ) as a reference

            // Code 1: Enable when you need
            //DelSquare objRef = Square;
            //// invoke 
            // var result = objRef(2);
            //Console.WriteLine(result);
            //var result1 = objRef.Invoke(5);
            //Console.WriteLine(result1);

            // Code 2: Enable when you need
            // anonymous method technique
            //DelSquare objRef = delegate(int i) { return i * i; };
            //var result = objRef.Invoke(4);
            //Console.WriteLine(result);


            // Code 3: Enable when you need
            // Function Technique
            //Func<int , int> objRef = delegate(int i) { return i * i; };
            //var result = objRef(5);
            //Console.WriteLine(result);

            // Code 4: Enable when you need
            // Lambda Expression
            Func<int, int> objRef = i => i * i;
            var result = objRef(5);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int Square(int i)
        {
            return i * i;
        }
    }
}
