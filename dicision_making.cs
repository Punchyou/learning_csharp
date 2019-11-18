using System;

namespace DecisionMakingApp {
    class DecisionMaking {
        static void Main(string[] arg) {

            int a = 30;
            int b = 394;

            if (a == b) {
                Console.WriteLine("A = B");
            
            } else if (b > a) {
                Console.WriteLine("A is not equal to B");
            }
        
            Console.ReadKey();
        }
    }
}