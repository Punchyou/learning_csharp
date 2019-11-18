using System;

namespace FactorialApplication{
    class FactorialClass{
        public double Factorial(double a) {

            double result;

            if (a == 1) {
                result = 1;
            } else {
                result = Factorial(a-1) * a;
            }
            return result;
        }

        static void Main() {
            FactorialClass fact = new FactorialClass();
            Console.WriteLine("The factorial of 8 is: {0}", fact.Factorial(8));
            Console.ReadKey();
        }
    }

    
    
}